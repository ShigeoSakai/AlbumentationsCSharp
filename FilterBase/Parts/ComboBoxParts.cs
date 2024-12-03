using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    /// <summary>
    /// 単独コンボボックス
    /// </summary>
    public partial class ComboBoxParts : ComboBox,IParts, ISupportInitialize
    {
        /// <summary>
        /// 初期化終了か？
        /// </summary>
        private bool _initEnd = false;

        /// <summary>
        /// 引数名
        /// </summary>
        [Category("値入力")]
        public string ArgumentName { get; set; }

        /// <summary>
        /// Itemの型指定
        /// </summary>
        private string _itemTypeStr = "System.String";
        /// <summary>
        /// Itemの型指定プロパティ
        /// </summary>
        [Category("値入力")]
        public string ItemType 
        { 
            get => _itemTypeStr;
            set
            {
                if (string.IsNullOrEmpty(value))
                {   // デフォルトにする
                    _itemTypeStr = "System.String";
                    _ItemType = typeof(string);
                }
                else
                {
                    _itemTypeStr = value;

                    // デザインモードの時は、文字列を保存して終了 => EndInit()呼び出し時に型に変換
                    // デザインモードでない場合は、型を検索して、その型を格納する。
                    if ((PartsFunc.IsDesigneMode(this) == false) && (_initEnd))
                    {   // デザインモードでないので、型を検索
                        MappingComboBox();
                    }
                }
            }
        }
        /// <summary>
        /// Itemの型
        /// </summary>
        private Type _ItemType = typeof(string);

        /// <summary>
        /// デフォルト値
        /// </summary>
        [Category("値入力")]
        public string DefaultValue { get; set; } = string.Empty;

        /// <summary>
        /// 選択されている値
        /// </summary>
        [Category("値入力")]
        public object Value
        {
            get => GetValue();
            set => SetValue(value);
        }
        /// <summary>
        /// 説明分
        /// </summary>
        /// <remarks>
        /// System.ComponentModel.Design.MultilineStringEditorを使うには、
        /// 参照設定で、アセンブリ：System.Design を追加する
        /// </remarks>
        [Category("値入力"), Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]
        public virtual string Description { get; set; } = string.Empty;


        #region[バージョン情報]
        /// <summary>
        /// 最小バージョン
        /// </summary>
        private VersionInfo _minVersion = null;

        /// <summary>
        /// 最小バージョン
        /// </summary>
        [Category("バージョン")]
        public string MinVersion
        {
            get => ((_minVersion == null) ? null : _minVersion.ToString());
            set
            {
                if (value != null)
                    _minVersion = new VersionInfo(value);
                else
                    _minVersion = null;
                // Visibleを変更する
                this.Visible = CheckVersion();
            }
        }

        /// <summary>
        /// 最大バージョン
        /// </summary>
        private VersionInfo _maxVersion = null;

        /// <summary>
        /// 最大バージョン
        /// </summary>
        [Category("バージョン")]
        public string MaxVersion
        {
            get => ((_maxVersion == null) ? null : _maxVersion.ToString());
            set
            {
                if (value != null)
                    _maxVersion = new VersionInfo(value);
                else
                    _maxVersion = null;
                // Visibleを変更する
                this.Visible = CheckVersion();
            }
        }
        /// <summary>
        /// バージョン情報
        /// </summary>
        private VersionInfo _version;

        /// <summary>
        /// バージョンのチェック
        /// </summary>
        /// <returns>true:チェックOK</returns>
        private bool CheckVersion()
        {
            if (_version == null) return true;
            if ((_version.CompareTo(_minVersion) >= 0) &&
                (_version.CompareTo(_maxVersion) <= 0))
                return true;
            return false;
        }

        /// <summary>
        /// バージョン情報の設定
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public bool SetVersion(VersionInfo version)
        {
            _version = version;
            // Visibleを変更する
            this.Visible = CheckVersion();
            return this.Visible;
        }

        #endregion[バージョン情報]

        /// <summary>
        /// パラメータ変更イベント
        /// </summary>
        public event ParameterChangeEventHandler ParameterChange;
        /// <summary>
        /// パラメータ変更イベント発行
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        protected virtual void OnParameterChange(string name, object value)
        {
            ParameterChange?.Invoke(this, name, value);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ComboBoxParts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// サイズ変更
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            Width = PartsConst.FIXED_WIDTH - this.Margin.Left - this.Margin.Right;
            base.OnSizeChanged(e);
        }
        /// <summary>
        /// 値の取得
        /// </summary>
        /// <returns></returns>
        private object GetValue()
        {
            return this.SelectedItem;
        }
        /// <summary>
        /// 値の設定
        /// </summary>
        /// <param name="value"></param>
        private bool SetValue(object value)
        {
            if (this.Items.Count > 0)
            {
                foreach (object item in this.Items)
                {
                    if (item != null)
                    {
                        if (item is IComboBox cb_item)
                        {
                            if ((cb_item.ArgumentValue != null) && (cb_item.ArgumentValue.Equals(value)))
                            {
                                this.SelectedItem = item;
                                return true;
                            }
                        }
                        if (item.Equals(value))
                        {
                            this.SelectedItem = item;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns>true:チェックOK</returns>
        public bool Check(out string err_msg)
        {
            // 引数名未入力
            if (string.IsNullOrEmpty(ArgumentName))
            {
                err_msg = string.Format("プロパティ:ArgumentNameが入力されていません");
                return false;
            }
            if (this.SelectedItem == null)
            {
                err_msg = string.Format("コンボボックス({0})が選択されていません", this.Name);
                return false;
            }
            err_msg = string.Empty;
            return true;
        }
        /// <summary>
        /// 引数の取得
        /// </summary>
        /// <returns>引数の文字列。nullの場合はエラー。空白はパラメータなし</returns>
        public string GetArgument()
        {
            if (Check(out _))
            {
                if (this.SelectedItem != null)
                {
                    string arg_str = GetArgumentValue();
                    if (string.IsNullOrEmpty(arg_str) == false)
                        return ArgumentName + "=" + arg_str;
                }
            }
            // エラー
            return null;
        }
        /// <summary>
        /// 引数値を取得
        /// </summary>
        /// <returns></returns>
        public string GetArgumentValue()
        {
            if (this.SelectedItem != null)
            {
                string arg_str = this.SelectedItem.ToString();
                if ((_ItemType != null) && (this.SelectedItem.GetType() == _ItemType))
                {
                    // ArgumentValueプロパティがあれば、それを使う
                    PropertyInfo pInfo = _ItemType.GetProperty("ArgumentValue", typeof(string));
                    if (pInfo != null)
                    {
                        arg_str = (string)pInfo.GetValue(this.SelectedItem);
                    }
                }
                return arg_str;
            }
            return null;
        }

        /// <summary>
        /// 初期化開始
        /// </summary>
        public void BeginInit()
        {
            _initEnd = false;
        }
        /// <summary>
        /// コンボボックスに値を入れる
        /// </summary>
        private void MappingComboBox()
        {
            Type tp = PluginManager.GetTypeFromTypeName(_itemTypeStr);
            if (tp != null)
            {
                _ItemType = tp;

                // コンボボックス生成メソッドがあるか(デフォルト指定あり)
                MethodInfo info = tp.GetMethod("MakeComboBox", BindingFlags.Static | BindingFlags.Public, null,
                    new Type[] { typeof(ComboBox), typeof(string) }, null);

                if (info != null)
                {
                    info.Invoke(null, new object[] { this, DefaultValue });
                }
                else
                {   // デフォルト値指定なしを検索
                    info = tp.GetMethod("MakeComboBox", BindingFlags.Static | BindingFlags.Public, null,
                        new Type[] { typeof(ComboBox) }, null);
                    if (info != null)
                    {
                        info.Invoke(null, new object[] { this });
                    }
                }
            }
        }


        /// <summary>
        /// 初期化完了
        /// </summary>
        public void EndInit()
        {
            // デザインモードか判定
            if (PartsFunc.IsDesigneMode(this) == false)
            {   // デザインモードでない場合、文字列から型を設定
                MappingComboBox();
                _initEnd = true;
            }
        }
        /// <summary>
        /// 選択変更イベントハンドラ
        /// </summary>
        /// <param name="sender">送信元</param>
        /// <param name="index">選択インデックス</param>
        /// <param name="value">選択アイテム</param>
        public delegate void SelectChangeEventHander(object sender, int index, object value);

        /// <summary>
        /// 選択インデックスの変更イベント
        /// </summary>
        public event SelectChangeEventHander ComboSelectedIndexChanged;
        /// <summary>
        /// 選択インデックスの変更イベント発行
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        protected virtual void OnComboSelectedIndexChanged(int index, object value)
        {
            ComboSelectedIndexChanged?.Invoke(this, index, value);
        }
        /// <summary>
        /// 選択インデックスが変更になった
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            // イベント発行
            OnComboSelectedIndexChanged(this.SelectedIndex,this.SelectedItem);
        }
        /// <summary>
        /// 選択アイテムの変更イベント
        /// </summary>
        public event SelectChangeEventHander ComboSelectedItemChanged;
        /// <summary>
        /// 選択アイテムの変更イベント発行
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        protected virtual void OnComboSelectedItemChanged(int index, object value)
        {
            ComboSelectedItemChanged?.Invoke(this, index, value);
        }
        /// <summary>
        /// 選択アイテムが変更になった
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSelectedItemChanged(EventArgs e)
        {
            base.OnSelectedItemChanged(e);
            // イベント発行
            OnComboSelectedItemChanged(this.SelectedIndex, this.SelectedItem);
        }
        /// <summary>
        /// 選択確定イベント
        /// </summary>
        public event SelectChangeEventHander ComboSelectionChangeCommitted;
        /// <summary>
        /// 選択確定イベント発行
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        protected virtual void OnComboSelectionChangeCommitted(int index, object value)
        {
            ComboSelectionChangeCommitted?.Invoke(this, index, value);
        }
        /// <summary>
        /// 選択が確定した
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSelectionChangeCommitted(EventArgs e)
        {
            base.OnSelectionChangeCommitted(e);
            // イベント発行
            OnComboSelectionChangeCommitted(this.SelectedIndex, this.SelectedItem);
            // 変更イベント発行
            // イベント発行
            OnParameterChange((ArgumentName != null) ? ArgumentName : "Unknown", this.SelectedItem);
        }

        /// <summary>
        /// Tool Tipに説明文を追加する
        /// </summary>
        /// <param name="tip"></param>
        public virtual void SetToolTip(ToolTip tip)
        {
            if ((tip != null) && (string.IsNullOrEmpty(Description) == false))
                tip.SetToolTip(this, Description);
        }
        /// <summary>
        /// パラメータの設定
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool SetParameter(string text)
        {
            if (string.IsNullOrEmpty(text) == false)
            {
                string chk_value = text.Trim();
                return SetValue(chk_value);
            }
            return false;
        }
        /// <summary>
        /// 無効設定
        /// </summary>
        /// <returns></returns>
        public bool SetInvalid() { return true; }

    }
}
