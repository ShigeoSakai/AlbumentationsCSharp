using FilterBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlbumentationsCSharp.Composition.TransformParser;

namespace AlbumentationsCSharp.Composition
{
    /// <summary>
    /// Core.Compositionノードクラス
    /// </summary>
    internal class CoreCompositionNode : TreeNode
    {
        /// <summary>
        /// 適用確率p
        /// </summary>
        private float p_value = 1.0F;
        /// <summary>
        /// 適用確率p
        /// </summary>
        public float P
        {
            get => p_value;
            set
            {
                p_value = value;
                Text = string.Format("{0} (p={1:#0.0#})", nodeName, p_value);
            }
        }
        /// <summary>
        /// ノード名
        /// </summary>
        private string nodeName { get;  set; }
        /// <summary>
        /// パラメータ辞書
        /// </summary>
        Dictionary<string, string> Argument = new Dictionary<string, string>();
        /// <summary>
        /// 文字列変換
        /// </summary>
        /// <returns>変換された文字列</returns>
        public override string ToString()
        {
            return string.Format("{0}(p={1:#0.00})", nodeName, P);
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">表示テキスト</param>
        public CoreCompositionNode(string text) : base(text) => nodeName = text;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">表示テキスト</param>
        /// <param name="argument">引数辞書</param>
        public CoreCompositionNode(string text, Dictionary<string, object> argument) : this(text)
        {
            if ((argument != null) && (argument.Count > 0))
            {
                // Trnasform
                string transkey = (argument.ContainsKey("transforms") ? "transforms" :
                    (argument.ContainsKey("0") ? "0" : null));

                if (transkey != null)
                {
                    object obj = argument[transkey];
                    // 入っているのはPythonFunc/Dictionary/そのままの値
                    if (obj == null)
                    {   // 何もしない
                    }
                    else if (obj is PythonFunc pyFunc)
                    {   // Python関数
                        Nodes.Add(GetNode(pyFunc.Name, pyFunc.Argumnet));
                    }
                    else if (obj is Dictionary<string, object> dict)
                    {   // 引数辞書
                        foreach (KeyValuePair<string, object> item in dict)
                        {
                            if (item.Value != null)
                            {
                                if (item.Value is PythonFunc sub_pyFunc)
                                    Nodes.Add(GetNode(sub_pyFunc.Name, sub_pyFunc.Argumnet));

                            }
                        }
                    }
                }

                // Pの値
                string p_key = (argument.ContainsKey("p") ? "p" : null);
                if ((p_key != null) && (float.TryParse(argument[p_key].ToString(), out float p_value)))
                    P = p_value;

                // 残りは辞書に
                foreach (KeyValuePair<string, object> kvp in argument)
                {
                    if ((kvp.Key != transkey) && (kvp.Key != p_key))
                        Argument.Add(kvp.Key, kvp.Value.ToString());
                }
            }
        }
        /// <summary>
        /// Treeノードの取得
        /// </summary>
        /// <param name="name">関数名</param>
        /// <param name="arguments">引数辞書</param>
        /// <returns></returns>
        public static TreeNode GetNode(string name, Dictionary<string, object> arguments)
        {
            // アセンブリ取得
            Assembly assm = Assembly.GetExecutingAssembly();
            foreach (Type nodeType in assm.GetTypes()
                .Where(p => p.IsSubclassOf(typeof(CoreCompositionNode))))
            {
                // Compositionクラスの名前を取得
                CompositionNameAttribute attr = nodeType.GetCustomAttribute<CompositionNameAttribute>();
                if ((attr != null) && (attr.Name == name))
                {   // 指定された名前のコンストラクタ情報を取得
                    ConstructorInfo ctor = nodeType.GetConstructor(new Type[] { typeof(Dictionary<string, object>) });
                    if (ctor != null)
                    {   // コンストラクタを呼び出して生成する
                        return ctor.Invoke(new object[] { arguments }) as CoreCompositionNode;
                    }
                }
            }
            // フィルターノードを返す
            return new FilterNode(name, arguments);
        }
        /// <summary>
        /// Compositionクラスかどうかを返す
        /// </summary>
        /// <param name="name">名前</param>
        /// <returns>true:Compositionクラスがある</returns>
        public static bool IsCoreCompositionFunction(string name)
        {
            // アセンブリ取得
            Assembly assm = Assembly.GetExecutingAssembly();
            foreach (Type nodeType in assm.GetTypes()
                .Where(p => p.IsSubclassOf(typeof(CoreCompositionNode))))
            {
                CompositionNameAttribute attr = nodeType.GetCustomAttribute<CompositionNameAttribute>();
                if ((attr != null) && (attr.Name == name))
                    return true;
            }
            return false;
        }

    }
    /// <summary>
    /// CompositionName属性クラス
    /// </summary>
    internal class CompositionNameAttribute : Attribute
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        public CompositionNameAttribute(string name) => Name = name;
    }

    // Compose,OneOf,OneOrOther,RandomOrder,SelectiveChannelTransform,Sequential,SomeOf

    /// <summary>
    /// Composeクラス
    /// </summary>
    [CompositionName("Compose")]
    internal class ComposeNode : CoreCompositionNode
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        public ComposeNode(Dictionary<string, object> argument) : base("Compose", argument) { }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        /// <param name="p">適用確率p</param>
        public ComposeNode(Dictionary<string, object> argument, float p) : this(argument) => P = p;
    }
    /// <summary>
    /// OneOfクラス
    /// </summary>
    [CompositionName("OneOf")]
    internal class OneOfNode : CoreCompositionNode
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        public OneOfNode(Dictionary<string, object> argument) : base("OneOf", argument) { }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        /// <param name="p">適用確率p</param>
        public OneOfNode(Dictionary<string, object> argument, float p) : this(argument) => P = p;
    }
    /// <summary>
    /// OneOrOtherクラス
    /// </summary>
    [CompositionName("OneOrOther")]
    internal class OneOrOtherNode : CoreCompositionNode
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        public OneOrOtherNode(Dictionary<string, object> argument) : base("OneOrOther")
        {   // 引数が特殊なので...
            throw new NotImplementedException();
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        /// <param name="p">適用確率p</param>
        public OneOrOtherNode(Dictionary<string, object> argument, float p) : this(argument) => P = p;
    }
    /// <summary>
    /// RandomOrderクラス
    /// </summary>
    [CompositionName("RandomOrder")]
    internal class RandomOrderNode : CoreCompositionNode
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        public RandomOrderNode(Dictionary<string, object> argument) : base("RandomOrder", argument) { }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        /// <param name="p">適用確率p</param>
        public RandomOrderNode(Dictionary<string, object> argument, float p) : this(argument) => P = p;
    }
    /// <summary>
    /// SelectiveChannelTransformクラス
    /// </summary>
    [CompositionName("SelectiveChannelTransform")]
    internal class SelectiveChannelTransformNode : CoreCompositionNode
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        public SelectiveChannelTransformNode(Dictionary<string, object> argument) : base("SelectiveChannelTransform", argument) { }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        /// <param name="p">適用確率p</param>
        public SelectiveChannelTransformNode(Dictionary<string, object> argument, float p) : this(argument) => P = p;
    }
    /// <summary>
    /// Sequentialクラス
    /// </summary>
    [CompositionName("Sequential")]
    internal class SequentialNode : CoreCompositionNode
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        public SequentialNode(Dictionary<string, object> argument) : base("Sequential", argument) { }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        /// <param name="p">適用確率p</param>
        public SequentialNode(Dictionary<string, object> argument, float p) : this(argument) => P = p;
    }
    /// <summary>
    /// SomeOfクラス
    /// </summary>
    [CompositionName("SomeOf")]
    internal class SomeOfNode : CoreCompositionNode
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        public SomeOfNode(Dictionary<string, object> argument) : base("SomeOf", argument) { }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argument">引数辞書</param>
        /// <param name="p">適用確率p</param>
        public SomeOfNode(Dictionary<string, object> argument, float p) : this(argument) => P = p;
    }
    /// <summary>
    /// フィルタークラス
    /// </summary>
    internal class FilterNode : TreeNode
    {
        /// <summary>
        /// ノード名
        /// </summary>
        private string nodeName;
        /// <summary>
        /// 適用確率p
        /// </summary>
        private float p_value = 1.0F;
        /// <summary>
        /// 適用確率p
        /// </summary>
        public float P
        {
            get => p_value;
            set
            {
                p_value = value;
                Text = string.Format("{0} (p={1:#0.0#})",nodeName,p_value);
            }
        }
        /// <summary>
        /// パラメータ辞書
        /// </summary>
        Dictionary<string, string> Argument = new Dictionary<string, string>();
        /// <summary>
        /// フィルター型
        /// </summary>
        public Type FilterType { get; private set; }
        /// <summary>
        /// 文字列変換
        /// </summary>
        /// <returns>変換された文字列</returns>
        public override string ToString()
        {
            return string.Format("{0}({1:#0.00}", Text, P);
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">フィルタ名</param>
        public FilterNode(string text) : base(text)
        {
            nodeName = text;
            FilterType = PluginManager.GetTypeFromTypeName(nodeName);
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">フィルタ名</param>
        /// <param name="arguments">引数辞書</param>
        public FilterNode(string text, Dictionary<string, object> arguments) : this(text)
        {
            if ((arguments != null) && (arguments.Count > 0))
            {
                foreach (KeyValuePair<string, object> arg in arguments)
                {
                    if ((arg.Key != null) && (arg.Value != null))
                    {
                        Argument.Add(arg.Key, arg.Value.ToString());
                        // pだったら...
                        if ((arg.Key == "p") && (float.TryParse(arg.Value.ToString(), out float p_val)))
                            P = p_val;
                    }
                }
            }
        }
        /// <summary>
        /// フィルタコントロールを取得する
        /// </summary>
        /// <returns></returns>
        public BaseFilterControl GetControl()
        {
            if (FilterType != null)
            {
                ConstructorInfo ctor_info = null;
                if (Argument.Count >0)
                {   // 引数ありのコンストラクタで生成
                    ctor_info = FilterType.GetConstructor(new Type[] { typeof(Dictionary<string, string>) });
                    if (ctor_info != null)
                        return (BaseFilterControl)ctor_info.Invoke(new object[] { Argument });
                }
                // 引数なしのコンストラクタで生成
                ctor_info = FilterType.GetConstructor(Type.EmptyTypes);
                if (ctor_info != null)
                    return (BaseFilterControl)ctor_info.Invoke(null);
            }
            return null;
        }
    }
}

