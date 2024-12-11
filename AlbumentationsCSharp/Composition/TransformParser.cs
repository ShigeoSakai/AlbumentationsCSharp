using SSTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumentationsCSharp.Composition
{
    /// <summary>
    /// Python Transform解析クラス
    /// </summary>
    internal class TransformParser : SSTools.SimpleParser,IDisposable
    {
        /// <summary>
        /// Python関数クラス
        /// </summary>
        public class PythonFunc
        {
            /// <summary>
            /// ネームスペース
            /// </summary>
            public string NameSpcae { get; private set; }
            /// <summary>
            /// 関数名
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// 引数辞書
            /// </summary>
            public Dictionary<string, object> Argumnet { get; private set; } = new Dictionary<string, object>();
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="nameSpace">ネームスペース</param>
            /// <param name="name">関数名</param>
            public PythonFunc(string nameSpace, string name)
            {
                NameSpcae = nameSpace;
                Name = name;
            }
            /// <summary>
            /// 引数辞書を文字列に変換
            /// </summary>
            /// <param name="dict">引数辞書</param>
            /// <param name="level">レベル</param>
            /// <returns>変換された文字列</returns>
            private string DictionaryToString(Dictionary<string, object> dict, int level)
            {
                string offset = new string(' ', level * 4 + 2);
                string result = "";
                if ((dict != null) && (dict.Count > 0))
                {
                    foreach (KeyValuePair<string, object> keyValue in dict)
                    {
                        // 'キー値 = 'を生成
                        result += offset + keyValue.Key + " = ";
                        if (keyValue.Value != null)
                        {
                            if (keyValue.Value is PythonFunc pyFunc)
                            {   // Pythonの関数
                                result += Environment.NewLine + pyFunc.ToString(level + 1);
                            }
                            else if (keyValue.Value is Dictionary<string, object> sub_dict)
                            {   // 辞書(配列等)
                                result += Environment.NewLine + DictionaryToString(sub_dict, level + 1);
                            }
                            else if (keyValue.Value is string str)
                            {   // 文字列
                                result += "'" + str + "'" + Environment.NewLine;
                            }
                            else
                            {   // 値
                                result += keyValue.Value.ToString() + Environment.NewLine;
                            }
                        }
                        else
                        {   // 値がnull
                            result = "null" + Environment.NewLine;
                        }
                    }
                }
                return result;
            }
            /// <summary>
            /// 文字列変換
            /// </summary>
            /// <param name="level">レベル</param>
            /// <returns>変換された文字列</returns>
            public string ToString(int level)
            {
                string result = new string(' ', level * 4) + NameSpcae + "." + Name + "(" + Environment.NewLine;
                if (Argumnet.Count > 0)
                {
                    result += DictionaryToString(Argumnet, level);
                }
                result += new string(' ', level * 4) + ")" + Environment.NewLine;
                return result;
            }
            /// <summary>
            /// 文字列変換
            /// </summary>
            /// <returns>変換された文字列</returns>
            public override string ToString()
            {
                return ToString(0);
            }
        }
        /// <summary>
        /// 関数名とネームスペースを分割
        /// </summary>
        /// <param name="funcName">関数名</param>
        /// <param name="nameSpace">分割したネームスペース</param>
        /// <returns>分割した関数名</returns>
        private string GetFuncName(string funcName, out string nameSpace)
        {
            nameSpace = "";
            int pos = funcName.IndexOf('.');
            if (pos < 0)
            {   // ネームスペースなし
                return funcName;
            }
            string[] nameSpaces = funcName.Split('.');
            for (int i = 0; i < nameSpaces.Length - 1; i++)
                nameSpace += ((nameSpace.Length > 0) ? "." : "") + nameSpaces[i];
            return nameSpaces[nameSpaces.Length - 1];
        }
        /// <summary>
        /// Albumentationsのネームスペース
        /// </summary>
        private string AlbumentationsName;

        /// <summary>
        /// ルート関数
        /// </summary>
        public PythonFunc RootFunc = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">解析する文字列</param>
        public TransformParser(string text) : base(text)
        {
            // 解析結果のチェック
            if ((base.ErrorCode == ERROR_CODE.NONE) && (base.ParserResult != null))
            {
                object top = base.ParserResult;
                // 先頭の型
                if (top is NameAndValue nameAndValue)
                {   // tr = だった場合
                    top = nameAndValue.Value;
                }
                if ((top is FuncName func) &&
                    (CoreCompositionNode.IsCoreCompositionFunction(GetFuncName(func.Name, out string ns))))
                {   // 先頭がComposition関数なら...
                    AlbumentationsName = ns;
                    RootFunc = GetPythonFunc(func);
                }
            }
        }
        /// <summary>
        /// デストラクタ
        /// </summary>
        public void Dispose()
        {
            if (RootFunc != null)
            {
                if (RootFunc is PythonFunc func)
                {
                    func.Argumnet.Clear();
                }
                RootFunc = null;
            }
        }

        /// <summary>
        /// Python関数の取得
        /// </summary>
        /// <param name="obj">解析結果オブジェクト</param>
        /// <returns>Python関数クラス。関数でない場合はnull</returns>
        private PythonFunc GetPythonFunc(object obj)
        {
            if (obj != null)
            {
                if (obj is FuncName func)
                {
                    string funcName = GetFuncName(func.Name, out string ns);
                    PythonFunc pyFunc = new PythonFunc(ns, funcName);
                    if (func.Arguments != null)
                    {
                        // 関数のみ
                        if (func.Arguments is FuncName child_func)
                        {
                            pyFunc.Argumnet.Add("0", GetPythonFunc(func.Arguments));
                            return pyFunc;
                        }
                        // 名前付き引数のみ
                        if (func.Arguments is NameAndValue nameAndValue)
                        {
                            pyFunc.Argumnet.Add(nameAndValue.Name, GetPythonValue(nameAndValue.Value, true));
                            return pyFunc;
                        }
                        // 引数リスト
                        if (func.Arguments is List<object> list)
                        {
                            for (int index = 0; index < list.Count; index++)
                            {
                                if (list[index] != null)
                                {
                                    if (list[index] is FuncName a_child_func)
                                    {   // 関数
                                        pyFunc.Argumnet.Add(index.ToString(), GetPythonFunc(a_child_func.Arguments));
                                    }
                                    else if (list[index] is NameAndValue a_nameAndValue)
                                    {   // 名前付き引数
                                        pyFunc.Argumnet.Add(a_nameAndValue.Name, GetPythonValue(a_nameAndValue.Value, false));
                                    }
                                    else if (list[index] is List<object> a_list)
                                    {   // 無いはず

                                    }
                                    else
                                    {   // そのままの値
                                        pyFunc.Argumnet.Add(index.ToString(), GetPythonValue(list[index], true));
                                    }
                                }

                            }
                            return pyFunc;
                        }
                        else
                        {   // 単一値
                            pyFunc.Argumnet.Add("0", GetPythonValue(func.Arguments, true));
                            return pyFunc;
                        }
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// 値を取得
        /// </summary>
        /// <param name="obj">解析結果オブジェクト</param>
        /// <param name="child_expand">子の展開をするか</param>
        /// <returns>値のオブジェクト</returns>
        private object GetPythonValue(object obj, bool child_expand)
        {
            if (obj != null)
            {
                if (obj is FuncName child_func)
                {   // 関数
                    return GetPythonFunc(obj);
                }
                if (obj is NameAndValue nameAndValue)
                {   // 名前付き引数
                    return new Dictionary<string, object>() { { nameAndValue.Name, nameAndValue.Value } };
                }
                if (obj is ParenthesesOrBrackets parentheses)
                {   // 括弧の場合は、展開するかどうかを判断
                    if (child_expand)
                        return GetPythonValue(parentheses.Arguments, false);
                    else
                        return parentheses.ToString();
                }
                if (obj is List<object> list)
                {   // 引数リスト
                    Dictionary<string, object> result = new Dictionary<string, object>();
                    for (int index = 0; index < list.Count; index++)
                    {
                        if (list[index] is FuncName a_child_func)
                        {   // 関数
                            result.Add(index.ToString(), GetPythonFunc(a_child_func));
                        }
                        else if (list[index] is NameAndValue a_nameAndValue)
                        {   // 名前付き引数
                            result.Add(a_nameAndValue.Name, GetPythonValue(a_nameAndValue.Value, false));
                        }
                        else if (list[index] is ParenthesesOrBrackets a_parentheses)
                        {   // 括弧の場合は、展開するかどうかを判断
                            if (child_expand)
                                result.Add(index.ToString(), GetPythonValue(a_parentheses.Arguments, false));
                            else
                                result.Add(index.ToString(), a_parentheses.ToString());
                        }
                        else
                        {   // 値 ... 文字列に変換
                            result.Add(index.ToString(), list[index].ToString());
                        }
                    }
                    return result;
                }
                else
                {
                    return obj.ToString();
                }

            }
            return obj;
        }
        /// <summary>
        /// 文字列変換
        /// </summary>
        /// <returns>変換した文字列</returns>
        public override string ToString()
        {
            if (RootFunc == null)
                return "null";
            if (RootFunc is PythonFunc pyFunc)
            {
                return pyFunc.ToString();
            }
            return "Not Function";
        }
    }
}
