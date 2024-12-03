using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    public partial class CheckBoxParts : CheckBox,IParts
    {
        /// <summary>
        /// 引数名
        /// </summary>
        [Category("値入力")]
        public string ArgumentName { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        [Category("値入力")]
        public string Title
        {
            get => this.Text;
            set => this.Text = value;
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

        /// <summary>
        /// チェックあり時の値
        /// </summary>
        private object _checkedValue = null;
        /// <summary>
        /// チェックあり時の値
        /// </summary>
        [Category("値入力")]
        public string CheckedValue 
        { 
            get => PartsFunc.GetObjectToString(_checkedValue); 
            set => PartsFunc.SetObjectFromString(ref _checkedValue, value);
        }

        /// <summary>
        /// チェックなし時の値
        /// </summary>
        private object _uncheckedValue = null;
        /// <summary>
        /// チェックなし時の値
        /// </summary>
        [Category("値入力")]
        public string UncheckedValue 
        {
            get => PartsFunc.GetObjectToString(_uncheckedValue);
            set => PartsFunc.SetObjectFromString(ref _uncheckedValue, value);
        }

        /// <summary>
        /// 未確定時の値
        /// </summary>
        private object _indeterminateValue = null;
        /// <summary>
        /// 未確定時の値
        /// </summary>
        [Category("値入力")]
        public string IndeterminateValue
        {
            get => PartsFunc.GetObjectToString(_indeterminateValue);
            set => PartsFunc.SetObjectFromString(ref _indeterminateValue, value);
        }


        /// <summary>
        /// 値
        /// </summary>
        private object _value;
        /// <summary>
        /// 値
        /// </summary>
        [Category("値入力")]
        public string Value
        {
            get => PartsFunc.GetObjectToString(_value);
            set
            {
                if (SetValue(ref _value, value))
                {
                    if(this.ThreeState)
                    {   // チェック状態変更
                        this.CheckState = GetValue3State(_value);
                    }
                    else
                    {   // チェック状態変更
                        this.Checked = GetValueBool(_value);
                    }
                }
            }
        }
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
        public CheckBoxParts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// サイズ変更
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            Width = PartsConst.FIXED_WIDTH - this.Margin.Right - this.Margin.Left;
            base.OnSizeChanged(e);
        }

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


        private object GetValueSub(object obj,object default_value)
        {
            if (obj != null)
                if (obj is string str)
                    if (string.IsNullOrEmpty(str) == false)
                        return str;
                    else
                        return default_value;
                else
                    return obj;
            return default_value;
        }


        /// <summary>
        /// 値を取得
        /// </summary>
        /// <returns></returns>
        private object GetValue()
        {
            if (this.ThreeState)
            {
                if (this.CheckState == CheckState.Checked)
                    return GetValueSub(_checkedValue,this.CheckState);
                else if (CheckState == CheckState.Unchecked)
                    return GetValueSub(_uncheckedValue,this.CheckState);
                return GetValueSub(_indeterminateValue,this.CheckState);
            }
            else if (this.Checked)
            {
                return GetValueSub(_checkedValue, this.Checked);
            }
            return GetValueSub(_uncheckedValue,this.Checked);
        }
        private bool SetValue(ref object obj,object value)
        {
            if ((obj != null) && (value != null))
            {
                if ((_checkedValue != null) && (_checkedValue.Equals(value)))
                {
                    obj = _checkedValue;
                    return true;
                }
                else if ((_uncheckedValue != null) && (_uncheckedValue.Equals(value)))
                {
                    obj = _uncheckedValue;
                    return true;
                }
                else if ((this.ThreeState) && (_indeterminateValue != null) &&
                    (_indeterminateValue.Equals(value)))
                {
                    obj = _indeterminateValue;
                    return true;
                }
                else if ((value is string str) && (PartsFunc.SetObjectFromString(ref obj, str)))
                {  // 変換OKなので何もしない
                    return true;
                }
            }
            else
            {
                obj = value;
                return true;
            }
            return false;
        }


        /// <summary>
        /// オブジェクトからCheckState値に変換
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private CheckState GetValue3State(object value)
        {
            if (value == null)
                return CheckState.Indeterminate;

            if ((_checkedValue != null) && (_checkedValue.Equals(value)))
                return CheckState.Checked;
            if ((_uncheckedValue != null) && (_uncheckedValue.Equals(value)))
                return CheckState.Unchecked;
            if ((_indeterminateValue != null) && (_indeterminateValue.Equals(value)))
                return CheckState.Indeterminate;

            if (value is bool b_val)
                if (b_val)
                    return CheckState.Checked;
                else 
                    return CheckState.Unchecked;

            return CheckState.Indeterminate;
        }
        /// <summary>
        /// オブジェクトからBool値に変換
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool GetValueBool(object value)
        {
            if (value == null)
                return false;

            if ((_checkedValue != null) && (_checkedValue.Equals(value)))
                return true;
            if ((_uncheckedValue != null) && (_uncheckedValue.Equals(value)))
                return false;

            if (value is bool b_val)
                return b_val;
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
            err_msg = string.Empty;
            return true ;
        }
        /// <summary>
        /// 引数の取得
        /// </summary>
        /// <returns>引数の文字列。nullの場合はエラー。空白はパラメータなし</returns>
        public string GetArgument()
        {
            if (Check(out _))
            {
                string arg_str = "";

                object value = GetValue();
                if (value != null)
                {
                    // ArgumentValueプロパティがあれば、それを使う
                    PropertyInfo pInfo = value.GetType().GetProperty("ArgumentValue", typeof(string));
                    if (pInfo != null)
                        arg_str = (string)pInfo.GetValue(value);
                    else if (value is bool b_val)
                    {   // PythonのTrue/Falseに変換
                        arg_str = (b_val) ? "True" : "False";
                    }
                    else
                        arg_str = value.ToString();


                    if (string.IsNullOrEmpty(arg_str) == false)
                    {
                        return ArgumentName + "=" + arg_str;
                    }
                }
            }
            // エラー
            return null;
        }
        /// <summary>
        /// チェック変更
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            if (this.Checked)
            {
                if (_checkedValue != null)
                    _value = _checkedValue;
                else
                    _value = this.Checked;
            }
            else
            {
                if (_uncheckedValue != null)
                    _value = _uncheckedValue;
                else
                    _value = this.Checked;
            }
            // イベント発行
            OnParameterChange((ArgumentName != null) ? ArgumentName : "Unknown", _value);
        }
        /// <summary>
        /// チェック状態変更
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCheckStateChanged(EventArgs e)
        {
            base.OnCheckStateChanged(e);
            if (this.CheckState == CheckState.Checked)
            {
                if (_checkedValue != null)
                    _value = _checkedValue;
                else
                    _value = this.CheckState;
            }
            else if (this.CheckState == CheckState.Unchecked)
            {
                if (_uncheckedValue != null)
                    _value = _uncheckedValue;
                else
                    _value = this.CheckState;
            }
            else
            {
                if (_indeterminateValue != null)
                    _value = _indeterminateValue;
                else
                    _value = this.CheckState;
            }
            // イベント発行
            OnParameterChange((ArgumentName != null) ? ArgumentName : "Unknown", _value);
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
        public bool SetParameter(string text)
        {
            if (string.IsNullOrEmpty(text) == false)
            {
                string chk_value = text.Trim();
                if (SetValue(ref _value, chk_value))
                {
                    if (this.ThreeState)
                    {   // チェック状態変更
                        this.CheckState = GetValue3State(_value);
                    }
                    else
                    {   // チェック状態変更
                        this.Checked = GetValueBool(_value);
                    }
                    return true; 
                }
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
