using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilterBase.Parts;

namespace FilterBase
{
    using BitwiseEnumerationEditor = SSTools.Enumerations.UI.BitwiseEnumerationEditor;
    using NonEnumerable = SSTools.Enumerations.NonEnumerableAttribute;

    /// <summary>
    /// フィルターベースクラス
    /// </summary>
    [DisplayName("BaseClass"), Description("フィルターベース")]
    public partial class BaseFilterControl : UserControl, ISupportInitialize
    {

        /// <summary>
        /// 変換できるターゲット
        /// </summary>
        [Flags]
        public enum TRANSFORM_TARGET : byte
        {
            IMAGE = 0x0001,
            MASK = 0x0002,
            BBOX = 0x0004,
            KEY_POINT = 0x0008,
            [NonEnumerable]
            ALL = IMAGE | MASK | BBOX | KEY_POINT,
        }

        /// <summary>
        /// フィルター名
        /// </summary>
        private string _filterName;
        /// <summary>
        /// 詳細
        /// </summary>
        private string _description;

        /// <summary>
        /// フィルタ名プロパティ
        /// </summary>
        [Category("値入力")]
        public string FilterName {
            get => _filterName;
            protected set
            {
                _filterName = value;
                LbTitle.Text = _filterName;
            }
        }
        /// <summary>
        /// 詳細プロパティ
        /// </summary>
        [Category("値入力"),Editor(typeof(System.ComponentModel.Design.MultilineStringEditor),typeof(UITypeEditor))]
        public virtual string Description { get => _description; }

        /// <summary>
        /// 変換対象
        /// </summary>
        [Category("値入力")]
        [Editor(typeof(SSTools.Enumerations.UI.BitwiseEnumerationEditor), typeof(UITypeEditor))]
        public TRANSFORM_TARGET Target { get; set; } = TRANSFORM_TARGET.ALL;


        /// <summary>
        /// 必須のターゲット
        /// </summary>
        private TRANSFORM_TARGET _require = TRANSFORM_TARGET.IMAGE;
        /// <summary>
        /// 必須のターゲット
        /// </summary>
        [Category("値入力")]
        [Editor(typeof(BitwiseEnumerationEditor), typeof(UITypeEditor))]
        public TRANSFORM_TARGET Require 
        { 
            get => _require;
            set 
            {
                _require = value;
            } 
        }
        /// <summary>
        /// パラメータ変更イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public delegate void ParameterChangeEventHandler(object sender, string name, object value);
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
        public BaseFilterControl()
        {
            InitializeComponent();

            // フィルタ名を設定
            DisplayNameAttribute attr = GetType().GetCustomAttribute<DisplayNameAttribute>();
            if (attr != null)
                FilterName = attr.DisplayName;
            // 詳細を取得
            DescriptionAttribute desc = GetType().GetCustomAttribute<DescriptionAttribute>();
            if (desc != null)
            {
                _description = desc.Description;
                HelpToolTip.SetToolTip(LbTitle, _description);
            }
        }

        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version"></param>
        public BaseFilterControl(VersionInfo version) : this() 
        {
            Version = version;
        }
        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                // ToopTipを全て削除
                HelpToolTip.RemoveAll();
            }
            base.Dispose(disposing);
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
                // Enableを変更する
                this.Enabled = CheckVersion();
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
                // Enableを変更する
                this.Enabled = CheckVersion();
            }
        }

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
        /// バージョン情報
        /// </summary>
        protected VersionInfo _version;
        /// <summary>
        /// バージョン情報設定
        /// </summary>
        [Category("バージョン")]
        public virtual VersionInfo Version
        {
            get => _version;
            set 
            { 
                _version = value;
                // コントロールにバージョンを設定
                SetVersion(_version);
            }
        }
        /// <summary>
        /// バージョンの設定
        /// </summary>
        /// <param name="version"></param>
        protected virtual void SetVersion(VersionInfo version)
        {
            // 自身のバージョンチェック
            this.Enabled = CheckVersion();
        }
        /// <summary>
        /// バージョンの設定
        /// </summary>
        /// <param name="version"></param>
        /// <param name="controls"></param>
        protected virtual void SetVersion(VersionInfo version, ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is IParts parts)
                    parts.SetVersion(version);
            }
        }
        #endregion [バージョン情報]

        /// <summary>
        /// Pythonスクリプトの出力
        /// </summary>
        /// <param name="albumemtation_name">Albumemtation名</param>
        /// <returns></returns>
        public virtual string GetPythonCommand(bool always_apply = false,string albumemtation_name = "A")
        {
            return string.Format("{0}.{1}({2})", albumemtation_name, this.Name, GetArguments(always_apply));

        }
        /// <summary>
        /// 引数の取得
        /// </summary>
        /// <returns></returns>
        protected virtual string GetArguments(bool always_apply = false)
        {
            if (always_apply)
                return "always_apply=True";

            float p = (float)NUDProbability.Value / 100.0F;
            return string.Format("p={0}", p);
        }

        /// <summary>
        /// 文字列変換
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _filterName;
        }
        /// <summary>
        /// パラメータのチェック
        /// </summary>
        /// <param name="err_msg"></param>
        /// <returns></returns>
        public virtual bool CheckParameter(out string err_msg)
        {
            err_msg = "";
            return true;
        }
        /// <summary>
        /// パラメータのチェック
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="err_msg"></param>
        /// <returns></returns>
        protected bool CheckParameter(ControlCollection controls,out string err_msg)
        {
            foreach (Control ctrl in controls)
            {
                // 表示されている+有効のもののみ
                if ((ctrl is IParts parts) && (ctrl.Visible) && (ctrl.Enabled))
                {
                    if (parts.Check(out err_msg) == false)
                        return false;
                }
            }
            err_msg = string.Empty;
            return true;
        }

        /// <summary>
        /// FlowLayoutPanelにある引数を全部取得する
        /// </summary>
        /// <param name="flp"></param>
        /// <returns></returns>
        protected string GetArguments(ControlCollection controls, bool always_apply = false)
        {
            string result = string.Empty;
            foreach (Control ctrl in controls)
            {
                // 表示されている+有効のもののみ
                if ((ctrl is IParts parts) && (ctrl.Visible) && (ctrl.Enabled))
                {
                    string arg = parts.GetArgument();
                    if (string.IsNullOrEmpty(arg) == false)
                        result += ((result.Length > 0) ? "," : "") + parts.GetArgument();
                }
            }
            if (always_apply)
            {
                result += ((result.Length > 0) ? "," : "") + "always_apply=True";
            }
            else
            {
                float p = (float)NUDProbability.Value / 100.0F;
                result += ((result.Length > 0) ? "," : "") + string.Format("p={0}", p);
            }
            return result;
        }

        /// <summary>
        /// ToolTipを設定する
        /// </summary>
        /// <param name="ctrls"></param>
        private void SetToolTip(ControlCollection ctrls)
        {
            if ((ctrls != null) && (ctrls.Count > 0))
            {
                foreach (Control ctrl in ctrls)
                {
                    if (ctrl is IParts parts)
                        parts.SetToolTip(HelpToolTip);
                    else if ((ctrl.Controls != null) && (ctrl.Controls.Count > 0))
                    SetToolTip(ctrl.Controls);
                }
            }
        }

        /// <summary>
        /// ToolTipを設定する
        /// </summary>
        protected virtual void SetToolTip()
        {
            SetToolTip(this.Controls);
        }
        /// <summary>
        /// 初期化開始
        /// </summary>
        public virtual void BeginInit()
        {
        }

        /// <summary>
        /// 初期化終了
        /// </summary>
        public virtual void EndInit()
        {
            // Tool Tipを設定する
            SetToolTip();
        }
    }
}
