using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    /// <summary>
    /// ラベル付きコンボボックス
    /// </summary>

    public partial class ComboBoxWithLabelParts : PartsBase
    {
        /// <summary>
        /// 引数名
        /// </summary>
        [Category("値入力")]
        public override string ArgumentName 
        {
            get
            {
                base.ArgumentName = CbComboBox.ArgumentName;
                return base.ArgumentName;
            }
            set
            {
                base.ArgumentName = value;
                CbComboBox.ArgumentName = value;
            }
        }
        /// <summary>
        /// Itemの型指定プロパティ
        /// </summary>
        [Category("値入力")]
        public string ItemType
        {
            get => CbComboBox.ItemType;
            set => CbComboBox.ItemType = value;
        }
        /// <summary>
        /// デフォルト値
        /// </summary>
        [Category("値入力")]
        public string DefaultValue
        {
            get => CbComboBox.DefaultValue;
            set => CbComboBox.DefaultValue = value;
        }
        /// <summary>
        /// 選択されている値
        /// </summary>
        [Category("値入力")]
        public object Value
        {
            get => CbComboBox.Value;
            set => CbComboBox.Value = value;
        }
        /// <summary>
        /// コンボボックスの中身
        /// </summary>
        [Browsable(false)]
        public ComboBox.ObjectCollection Items { get => CbComboBox.Items; }
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ComboBoxWithLabelParts() :base()
        {
            InitializeComponent();
            // レイアウト実行
            ExecLayout();
        }
        /// <summary>
        /// レイアウト実行
        /// </summary>
        protected override void ExecLayout()
        {
            base.ExecLayout();

            SuspendLayout();
            // ラベルの位置まではPartsBaseが行う
            int y = LbTitle.Location.Y + LbTitle.Height + LbTitle.Margin.Bottom + CbComboBox.Margin.Top;

            CbComboBox.Location = new Point((PartsConst.FIXED_WIDTH - CbComboBox.Width - CbComboBox.Margin.Horizontal ) / 2, y);

            ResumeLayout();
        }
        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <param name="err_msg"></param>
        /// <returns></returns>
        public override bool Check(out string err_msg)
        {
            if (base.Check(out err_msg))
                return CbComboBox.Check(out err_msg);
            return false;
        }
        /// <summary>
        /// 引数の取得
        /// </summary>
        /// <returns></returns>
        protected override string GetArgumentValue()
        {
            return CbComboBox.GetArgumentValue();
        }

        /// <summary>
        /// コンボボックス選択変更イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public delegate void ComboBoxSelectEventHandler(object sender, int index, object value);

        /// <summary>
        /// 選択インデックス変更イベント
        /// </summary>
        public event ComboBoxSelectEventHandler SelectedIndexChanged;
        /// <summary>
        /// 選択インデックス変更イベント発行
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        protected virtual void OnSelectedIndexChanged(int index, object value)
        {
            SelectedIndexChanged?.Invoke(this, index, value);
        }
        /// <summary>
        /// 選択インデックス変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void CbComboBox_ComboSelectionChangeCommitted(object sender, int index, object value)
        {
            // 選択インデックス変更イベント発行
            OnSelectedIndexChanged(index, value);
        }
        /// <summary>
        /// 選択確定イベント
        /// </summary>
        public event ComboBoxSelectEventHandler SelectionChangeCommitted;
        /// <summary>
        /// 選択確定イベント発行
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        protected virtual void OnSelectionChangeCommitted(int index, object value)
        {
            SelectionChangeCommitted?.Invoke(this, index, value);
        }
        /// <summary>
        /// 選択確定イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void CbComboBox_ComboSelectedIndexChanged(object sender, int index, object value)
        {
            // 選択確定イベント発行
            OnSelectionChangeCommitted(index, value);
        }
        /// <summary>
        /// パラメータ変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void CbComboBox_ParameterChange(object sender, string name, object value)
        {
            // パラメータ変更イベント発行
            OnParameterChange(name, value);
        }
        /// <summary>
        /// 有効・無効のチェックが変わった事を通知
        /// </summary>
        /// <param name="isValid"></param>
        protected override void ValidCheckChange(bool isValid)
        {
            CbComboBox.Enabled = isValid;
        }
    }
}
