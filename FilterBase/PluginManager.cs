using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterBase
{
    public class PluginManager
    {
        /// <summary>
        /// アセンブリ-モジュールクラス
        /// </summary>
        private class AsmModule
        {
            /// <summary>
            /// アセンブリ
            /// </summary>
            public Assembly Assembly { get; private set; }
            // モジュール
            public Module Module { get; private set; }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="assembly"></param>
            /// <param name="module"></param>
            public AsmModule(Assembly assembly, Module module)
            {
                Assembly = assembly;
                Module = module;
            }
            /// <summary>
            /// 型を名前で検索
            /// </summary>
            /// <param name="type_name"></param>
            /// <returns></returns>
            public Type GetTypeFromTypeName(string type_name)
            {
                if (Module != null)
                {
                    Type type = Module.GetType(type_name);
                    if (type != null)
                        return type; ;

                    // ジェネリック対応処理
                    int index = type_name.IndexOf("<");
                    if (index >= 0)
                    {
                        type_name = type_name.Remove(index) + "`1";
                    }
                    foreach (var as_type in Assembly.GetTypes())
                    {
                        if (as_type.Name.Equals(type_name))
                        {
                            return as_type;
                        }
                    }
                }
                return null;
            }
        }
        /// <summary>
        /// DLLファイル名 -> アセンブリ辞書
        /// </summary>
        private static Dictionary<string, AsmModule> AssemblyDictionary = new Dictionary<string, AsmModule>();

        /// <summary>
        /// フィルタ管理クラス
        /// </summary>
        private class FilterManagementClass
        {
            /// <summary>
            /// フィルタ名
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// モジュール名
            /// </summary>
            public string ModuleName { get; private set; }
            /// <summary>
            /// カテゴリー名 ... コンボボックス表示名
            /// </summary>
            public string CategoryName { get; private set; }
            /// <summary>
            /// インデックス
            /// </summary>
            public int Index { get; private set; }
            /// <summary>
            /// フィルタ表示名
            /// </summary>
            public string DisplayName { get; private set; }
            /// <summary>
            /// フィルタの説明
            /// </summary>
            public string Description { get; private set; }
            /// <summary>
            /// フィルタの型
            /// </summary>
            public Type MethodType { get; private set; }
            /// <summary>
            /// アセンブリ識別子
            /// </summary>
            public string AsmName { get; private set; }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="name">名前</param>
            /// <param name="methodType">型</param>
            /// <param name="asmName">アセンブリ名</param>
            public FilterManagementClass(string name, Type methodType, string asmName)
            {
                Name = name;
                MethodType = methodType;
                AsmName = asmName;
                // カテゴリー
                ModuleCategoryAttribute moduleAttr = methodType.GetCustomAttribute<ModuleCategoryAttribute>();
                if (moduleAttr != null)
                {
                    ModuleName = moduleAttr.Module;
                    CategoryName = moduleAttr.Name;
                }
                IndexAttribute indexAttr = methodType.GetCustomAttribute<IndexAttribute>();
                // インデックス
                if (indexAttr != null)
                    Index = indexAttr.Index;
                else
                    Index = 0;
                // 表示名
                DisplayNameAttribute dispName = methodType.GetCustomAttribute<DisplayNameAttribute>();
                if (dispName != null)
                    DisplayName = dispName.DisplayName;
                // 説明
                DescriptionAttribute descriptionAttribute = methodType.GetCustomAttribute<DescriptionAttribute>();
                if (descriptionAttribute != null)
                    Description = descriptionAttribute.Description;
            }
            /// <summary>
            /// 文字列変換
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return DisplayName;
            }
        }

        /// <summary>
        /// カテゴリー別辞書
        /// </summary>
        private static Dictionary<string, List<FilterManagementClass>> CategoryDictionary = new Dictionary<string, List<FilterManagementClass>>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="path">プラグインパス</param>
        public static void LoadPlugins(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (string filename in Directory.EnumerateFiles(path, "*.dll"))
                {
                    AddPlugin(filename);
                }
            }
        }
        /// <summary>
        /// プラグインの追加
        /// </summary>
        /// <param name="filename">ファイル名</param>
        /// <returns>追加したフィルタ数</returns>
        public static int AddPlugin(string filename)
        {
            if (File.Exists(filename))
            {
                // キー
                string key = Path.GetFileNameWithoutExtension(filename);
                // 指定DLLが読み込まれていない場合のみ
                if (AssemblyDictionary.ContainsKey(key) == false)
                {
                    try
                    {
                        Assembly assembly = Assembly.LoadFrom(filename);
                        Module module = assembly.GetModule(Path.GetFileName(filename));
                        if ((assembly != null) && (module != null))
                        {
                            // 辞書に登録
                            AssemblyDictionary.Add(Path.GetFileNameWithoutExtension(filename),
                                new AsmModule(assembly, module));

                            int num = 0;
                            // 指定した名前空間のクラスをすべて取得
                            foreach (Type type in assembly.GetTypes()
                                .Where(p => p.IsSubclassOf(typeof(FilterBase.BaseFilterControl)))
                                .OrderBy(o => o.Name)
                                .Select(s => s))
                            {
                                FilterManagementClass info = new FilterManagementClass(type.Name, type, key);
                                // カテゴリー別辞書に登録
                                if (CategoryDictionary.ContainsKey(info.CategoryName) == false)
                                {   // リストを生成
                                    CategoryDictionary.Add(info.CategoryName, new List<FilterManagementClass>());
                                }
                                CategoryDictionary[info.CategoryName].Add(info);
                                num++;
                            }
                            return num;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return 0;
        }
        /// <summary>
        /// カテゴリー別のクラス(コンボボックス登録用)
        /// </summary>
        private class CategoryComboItem
        {
            /// <summary>
            /// カテゴリー名
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// フィルタ情報リスト
            /// </summary>
            public List<FilterManagementClass> MethodList { get; private set; }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="name">カテゴリー名</param>
            /// <param name="methodList">フィルタ情報リスト</param>
            public CategoryComboItem(string name, List<FilterManagementClass> methodList)
            {
                Name = name;
                MethodList = methodList;
                // Index,表示名順に並び替え
                MethodList.Sort((a, b) => { return (a.Index == b.Index) ? a.DisplayName.CompareTo(b.DisplayName) : a.Index - b.Index; });
            }
            /// <summary>
            /// 文字列変換
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return Name;
            }
        }
        /// <summary>
        /// カテゴリーコンボボックスの中身を作成
        /// </summary>
        /// <param name="combo">カテゴリーコンボボックス</param>
        /// <returns></returns>
        public static bool MakeCategoryComboBox(ComboBox combo)
        {
            combo.Items.Clear();
            if (CategoryDictionary.Count > 0)
            {
                foreach (string key in CategoryDictionary.Keys)
                {
                    combo.Items.Add(new CategoryComboItem(key, CategoryDictionary[key]));
                }
                combo.SelectedIndex = 0;
                return true;
            }
            return false;
        }
        /// <summary>
        /// フィルタコンボボックスの作成
        /// </summary>
        /// <param name="categoryCombo">カテゴリーコンボボックス</param>
        /// <param name="filterCombo">フィルターコンボボックス</param>
        public static void MakeMethodComboBox(ComboBox categoryCombo, ComboBox filterCombo)
        {
            if ((categoryCombo != null) && (categoryCombo.SelectedItem != null) &&
                (categoryCombo.SelectedItem is CategoryComboItem item))
            {
                filterCombo.Items.Clear();
                for (int index = 0; index < item.MethodList.Count; index++)
                {
                    filterCombo.Items.Add(item.MethodList[index]);
                }
                filterCombo.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// フィルタを生成
        /// </summary>
        /// <param name="value">フィルタ管理クラス</param>
        /// <returns>フィルタの実体</returns>
        public static FilterBase.BaseFilterControl GetFilterControl(object value)
        {
            if ((value != null) && (value is FilterManagementClass item))
            {
                return (FilterBase.BaseFilterControl)Activator.CreateInstance(item.MethodType);
            }
            return null;
        }
        /// <summary>
        /// 名前から型を検索する
        /// </summary>
        /// <param name="type_name"></param>
        /// <returns></returns>
        public static Type GetTypeFromTypeName(string type_name)
        {
            Type tp = Type.GetType(type_name);
            if (tp != null)
                return tp;

            // モジュールを検索
            foreach (AsmModule asm_module in AssemblyDictionary.Values)
            {
                tp = asm_module.GetTypeFromTypeName(type_name);
                if (tp != null) return tp;
            }
            // ジェネリック対応処理
            int index = type_name.IndexOf("<");
            if (index >= 0)
            {
                type_name = type_name.Remove(index) + "`1";
            }

            // タイプ検索
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (type.Name.Equals(type_name))
                    {
                        return type;
                    }
                }
            }

            return null;

        }
    }
}
