using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FilterBase.Enums
{
    public class EnumComboClass<T> where T : Enum
    {
        /// <summary>
        /// Enum値
        /// </summary>
        public T Value { get; private set; }
        /// <summary>
        /// 説明
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 引数の値
        /// </summary>
        public virtual string ArgumentValue
        {
            get
            {
                try
                {   // 整数値で取得
                    int enumValue = (int)Convert.ChangeType(Value, typeof(int));
                    return enumValue.ToString();
                }
                catch { }
                return "'" + Value.ToString() + "'";
            }
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private EnumComboClass() { }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value"></param>
        public EnumComboClass(T value)
        {
            Value = value;
            Name = GetName(value);
            Description = GetDescription(value);
        }
        /// <summary>
        /// 名前の取得
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected virtual string GetName(T value)
        {
            return value.ToString();
        }
        /// <summary>
        /// 説明の取得
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected virtual string GetDescription(T value)
        {
            FieldInfo info = typeof(T).GetField(value.ToString());
            if (info != null)
            {
                DescriptionAttribute desc = info.GetCustomAttribute<DescriptionAttribute>();
                if (desc != null)
                    return desc.Description;
            }
            return null;
        }
        /// <summary>
        /// 文字列変換
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// コンボボックスの生成サブ
        /// </summary>
        /// <param name="comboBox"></param>
        protected static int MakeComboBoxSub<CT>(ComboBox comboBox, Array list) where CT : EnumComboClass<T>
        {
            comboBox.Items.Clear();
            ConstructorInfo constInfo = typeof(CT).GetConstructor(new Type[] { typeof(T) });
            if (constInfo != null)
            {
                foreach (T item in list)
                {
                    comboBox.Items.Add(constInfo.Invoke(new object[] { item }));
                }
            }
            return comboBox.Items.Count;
        }
        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <param name="comboBox"></param>
        protected static void MakeComboBox<CT>(ComboBox comboBox) where CT : EnumComboClass<T>
        {
            if (MakeComboBoxSub<CT>(comboBox, typeof(T).GetEnumValues()) > 0)
                comboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <typeparam name="CT"></typeparam>
        /// <param name="comboBox"></param>
        /// <param name="flags"></param>
        /// <param name="default_item"></param>
        protected static void MakeComboBox<CT>(ComboBox comboBox, Array flags, T default_item) where CT : EnumComboClass<T>
        {
            bool default_set = false;
            if (MakeComboBoxSub<CT>(comboBox, flags) > 0)
            {
                for (int index = 0; index < comboBox.Items.Count; index++)
                {
                    if (comboBox.Items[index] is EnumComboClass<T> def_item)
                        if (def_item.Value.Equals(default_item))
                        {
                            comboBox.SelectedIndex = index;
                            default_set = true;
                            break;
                        }
                }
            }
            if (default_set == false)
                comboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <typeparam name="CT"></typeparam>
        /// <param name="comboBox"></param>
        /// <param name="flags"></param>
        /// <param name="default_item"></param>
        protected static void MakeComboBox<CT>(ComboBox comboBox, IEnumerable<T> flags, T default_item) where CT : EnumComboClass<T>
        {
            MakeComboBox<CT>(comboBox, (Array)flags.ToArray(), default_item);
        }
        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <typeparam name="CT"></typeparam>
        /// <param name="comboBox"></param>
        /// <param name="flags"></param>
        /// <param name="default_item"></param>
        protected static void MakeComboBox<CT>(ComboBox comboBox, T default_item) where CT : EnumComboClass<T>
        {
            MakeComboBox<CT>(comboBox,typeof(T).GetEnumValues(),default_item);
        }

        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="default_item"></param>
        protected static void MakeComboBox<CT>(ComboBox comboBox, Array list, string default_item) where CT : EnumComboClass<T>
        {
            if (MakeComboBoxSub<CT>(comboBox, list) > 0)
            {
                // 数値指定の場合
                int? default_int = null;
                if (int.TryParse(default_item, out int i_value))
                {
                    default_int = i_value;
                }

                bool default_set = false;
                for (int index = 0; index < comboBox.Items.Count; index++)
                {
                    if (comboBox.Items[index] is CT def_item)
                    {
                        if ((def_item.Value.ToString() == default_item) ||
                            (def_item.Name == default_item) ||
                            ((default_int.HasValue) &&
                            ((int)Convert.ChangeType(def_item.Value, typeof(int)) == default_int.Value)))
                        {
                            default_set = true;
                        }
                        if (default_set)
                        {
                            comboBox.SelectedIndex = index;
                            break;
                        }
                    }
                }
                if (default_set == false)
                {   // デフォルト値がインデックスかもしれないので...
                    if ((default_int.HasValue) && (default_int.Value >= 0) && (default_int.Value < comboBox.Items.Count))
                        comboBox.SelectedIndex = default_int.Value;
                    else
                        comboBox.SelectedIndex = 0;
                }
            }
        }
        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="default_item"></param>
        protected static void MakeComboBox<CT>(ComboBox comboBox, IEnumerable<T> list, string default_item) where CT : EnumComboClass<T>
        {
            MakeComboBox<CT>(comboBox, (Array)list.ToArray(), default_item);

        }
        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="default_item"></param>
        protected static void MakeComboBox<CT>(ComboBox comboBox, string default_item) where CT : EnumComboClass<T>
        {
            MakeComboBox<CT>(comboBox, typeof(T).GetEnumValues(), default_item);
        }

        protected static T GetComboBox<CT>(ComboBox comboBox, T defaultValue) where CT : EnumComboClass<T>
        {
            if ((comboBox.SelectedItem != null) && (comboBox.SelectedItem is EnumComboClass<T> item))
                return item.Value;
            return defaultValue;
        }
    }
}
