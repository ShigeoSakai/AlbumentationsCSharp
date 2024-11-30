using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing.Design;

namespace FilterBase.Parts
{
    /// <summary>
    /// パーツベースコントロール
    /// </summary>
    public partial class PartsBase : UserControl, IParts, ISupportInitialize
    {
        /// <summary>
        /// 有効チェックボックスの表示有無
        /// </summary>
        protected bool _useValid = false;
        /// <summary>
        /// 有効チェックボックスの表示有無
        /// </summary>
        [Category("値入力"), Description("有効・無効のチェックボックスを表示するかどうか")]
        public virtual bool UseValid
        {
            get { return _useValid; }
            set
            {
                if (_useValid != value)
                {
                    _useValid = value;
                    // レイアウトを実行
                    ExecLayout();
                }
            }
        }
        /// <summary>
        /// 無効時の値文字列
        /// </summary>
        [Category("値入力"), Description("無効時の値文字列。ブランクの場合は引数を生成しない")]
        public virtual string InvalidValue { get; set; } = string.Empty;

        /// <summary>
        /// ラベルタイトル
        /// </summary>
        private string _LabelTitle = string.Empty;
        /// <summary>
        /// ラベルタイトルプロパティ
        /// </summary>
        [Category("値入力")]
        public virtual string Title
        {
            get => _LabelTitle;
            set
            {
                _LabelTitle = value;
                // ラベルタイトルに設定
                SetTitleLabel();
            }
        }
        /// <summary>
        /// 必須入力
        /// </summary>
        private bool _Required = false;
        /// <summary>
        /// 必須入力プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual bool Required
        {
            get => _Required;
            set
            {
                _Required = value;
                // ラベルタイトルに設定
                SetTitleLabel();
            }
        }
        /// <summary>
        /// 引数名
        /// </summary>
        [Category("値入力")]
        public virtual string ArgumentName { get; set; } = string.Empty;

        /// <summary>
        /// 説明分
        /// </summary>
        /// <remarks>
        /// System.ComponentModel.Design.MultilineStringEditorを使うには、
        /// 参照設定で、アセンブリ：System.Design を追加する
        /// </remarks>
        [Category("値入力"),Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]

        public virtual string Description {  get; set; } = string.Empty;

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
        /// パラメータ変更イベント発行
        /// </summary>
        /// <param name="value"></param>
        protected virtual void OnParameterChange(object value)
        {
            ParameterChange?.Invoke(this, 
                (string.IsNullOrEmpty(ArgumentName) ? "Unknown" : ArgumentName),
                value);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PartsBase()
        {
            InitializeComponent();
        }
        /// <summary>
        /// サイズ変更
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            Width = PartsConst.FIXED_WIDTH;
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// ラベルタイトルの設定
        /// </summary>
        protected virtual void SetTitleLabel()
        {
            LbTitle.Text = _LabelTitle + (_Required ? "※" : "") + ":";
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

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns>true:チェックOK</returns>
        public virtual bool Check(out string err_msg)
        {
            // 引数名未入力
            if (string.IsNullOrEmpty(ArgumentName))
            {
                err_msg = string.Format("プロパティ:ArgumentNameが入力されていません");
                return false;
            }
            err_msg = string.Empty;
            return true;
        }
        /// <summary>
        /// 引数の取得
        /// </summary>
        /// <returns>引数の文字列。nullの場合はエラー。空白はパラメータなし</returns>
        public virtual string GetArgument()
        {
            if (Check(out _))
            {
                // 有効無効指定で、有効が設定、もしくは有効無効が設定されていない
                if (((_useValid) && (CbValid.Checked)) || (_useValid == false))
                {   // 値を取得
                    string value = GetArgumentValue();
                    if (string.IsNullOrEmpty(value) == false)
                        return string.Format("{0}={1}", ArgumentName, value);
                    else if (_Required == false)
                        return "";
                }
                else if ((_useValid) && (string.IsNullOrEmpty(InvalidValue) == false))
                {   // パラメータなし指定
                    return string.Format("{0}={1}", ArgumentName, InvalidValue);
                }
                else
                {   // パラメータなし
                    return "";
                }
            }
            // エラー
            return null;
        }
        /// <summary>
        /// 引数に設定する値を取得
        /// </summary>
        /// <returns></returns>
        protected virtual string GetArgumentValue()
        {
            return "";
        }
        /// <summary>
        /// ToolTipの設定
        /// </summary>
        /// <param name="tip"></param>
        /// <param name="ctrls"></param>
        protected virtual void SetToolTip(ToolTip tip,IEnumerable<Control> ctrls)
        {
            if ((tip != null) && (ctrls != null) && (string.IsNullOrEmpty(Description) == false))
            {
                foreach (Control item in ctrls)
                {
                    tip.SetToolTip(item, Description);
                }
            }
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
        }
        /// <summary>
        /// Tool Tipに説明文を追加する
        /// </summary>
        /// <param name="tip"></param>
        public virtual void SetToolTip(ToolTip tip)
        {
            if ((tip != null) && (this.Controls != null) && (string.IsNullOrEmpty(Description) == false))
            {
                foreach (Control item in this.Controls)
                {
                    tip.SetToolTip(item, Description);
                }
            }
        }
        /// <summary>
        /// ラベルのサイズが変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void LbTitle_SizeChanged(object sender, EventArgs e)
        {
            // レイアウトを実行
            ExecLayout();
        }
        /// <summary>
        /// レイアウト実行
        /// </summary>
        protected virtual void ExecLayout()
        {
            SuspendLayout();

            int y = 0;
            if (_useValid)
            {
                y += CbValid.Margin.Top;
                CbValid.Visible = CbValid.Enabled = true;
                CbValid.Location = new Point(3, y);
                y += CbValid.Height + CbValid.Margin.Bottom;
            }
            else
            {   // 有効チェックボックスを表示しない
                CbValid.Visible = CbValid.Enabled = false;
            }
            // ラベル一
            y += LbTitle.Margin.Top;
            LbTitle.Location = new Point(LbTitle.Margin.Left, y);

            ResumeLayout(false);
        }
        /// <summary>
        /// 有効・無効のチェックが変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbValid_CheckedChanged(object sender, EventArgs e)
        {
            // 変更を通知
            ValidCheckChange(CbValid.Checked);
        }
        /// <summary>
        /// 有効・無効のチェックが変わった事を通知
        /// </summary>
        /// <param name="isValid"></param>
        protected virtual void ValidCheckChange(bool isValid)
        {

        }
    }
}
