using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumentationsCSharp
{
    /// <summary>
    /// BBox編集フォーム
    /// </summary>
    public partial class BBoxForm : Form
    {
        public delegate bool GetImageSizeEventHandler(object sender,out int width,out int height);
        public event GetImageSizeEventHandler GetImageSize;
        protected virtual bool OnGetImageSize(out int width,out int height)
        {
            if (GetImageSize != null)
                return GetImageSize(this, out width, out height);
            width = 0; height = 0;
            return false;
        }
        /// <summary>
        /// BBoxの取得
        /// </summary>
        public BoundingBox BoundingBox { get => boundingBox; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BBoxForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ローカルデータ
        /// </summary>
        private BoundingBox boundingBox;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bbox"></param>
        public BBoxForm(BoundingBox bbox):this()
        {
            if (bbox != null)
            {
                // コンボボックスに設定
                BBoxFormatClass.MakeComboBox(CbBBoxFormat, bbox.Format);

                // データをコピー
                boundingBox = new BoundingBox(bbox);
            }
            else
            {   // 新規に生成
                // コンボボックスに設定
                BBoxFormatClass.MakeComboBox(CbBBoxFormat, BBoxFormat.COCO);
                boundingBox = new BoundingBox(BBoxFormatClass.GetItem(CbBBoxFormat)) ;
            }

            // データグリッドに設定
            SetDataGrid();
        }
        /// <summary>
        /// OKボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtOK_Click(object sender, EventArgs e)
        {
            // データグリッドから値を取得
            GetDataGrid();

            DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// キャンセルボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        /// データグリッドに値を設定
        /// </summary>
        private void SetDataGrid()
        {
            // データグリッドに設定
            DGVBBox.Rows.Clear();
            foreach (BoundingBox.BoundingBoxDetail item in boundingBox.BBoxes)
            {
                DGVBBox.Rows.Add(item.ClassName, item.X1, item.Y1, item.X2, item.Y2);
            }
        }

        private bool ObjectToDouble(object obj,out double value)
        {
            if (obj is string str)
                return double.TryParse(str, out value);
            if (obj is double d)
            {
                value = d;
                return true;
            }
            if (obj is float f)
            {
                value = f;
                return true;
            }
            if (obj is long l)
            {
                value = l;
                return true;
            }
            if (obj is int i)
            {
                value = i; 
                return true;
            }
            value = double.NaN;
            return false;
        }


        private void GetDataGrid()
        {
            for(int row = 0; row < DGVBBox.Rows.Count; row ++)
            {
                string class_name = DGVBBox.Rows[row].Cells[ColumnClassName.Index].Value as string;
                if ((ObjectToDouble(DGVBBox.Rows[row].Cells[ColumnX1.Index].Value, out double x1)) &&
                    (ObjectToDouble(DGVBBox.Rows[row].Cells[ColumnY1.Index].Value , out double y1)) &&
                    (ObjectToDouble(DGVBBox.Rows[row].Cells[ColumnXWidth.Index].Value ,out double x2)) &&
                    (ObjectToDouble(DGVBBox.Rows[row].Cells[ColumnYHeight.Index].Value ,out double y2)))
                {
                    if (boundingBox.BBoxes.Count > row)
                    {
                        boundingBox.BBoxes[row].ClassName = class_name;
                        boundingBox.BBoxes[row].X1 = x1;
                        boundingBox.BBoxes[row].Y1 = y1;
                        boundingBox.BBoxes[row].X2 = x2;
                        boundingBox.BBoxes[row].Y2 = y2;
                        boundingBox.BBoxes[row].Valid = true;
                    }
                    else
                    {
                        boundingBox.BBoxes.Add(new BoundingBox.BoundingBoxDetail(class_name,x1,y1,x2,y2));
                    }
                }
            }
        }


        /// <summary>
        /// BBoxの形式変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbBBoxFormat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool get_size = OnGetImageSize(out int width, out int height);
            BBoxFormat fmt = BBoxFormatClass.GetItem(CbBBoxFormat,BBoxFormat.COCO);
            if ((get_size) || (fmt == BBoxFormat.PASCAL_VOC) || (fmt == BBoxFormat.COCO))
            {   // サイズ変換可能
                // データグリッドから値を取得
                GetDataGrid();
                // 値に変換
                boundingBox.Convert(fmt,width,height);
                // コンボボックスを変更
                BBoxFormatClass.SetItem(CbBBoxFormat, fmt);
                // データグリッドに設定
                SetDataGrid();
            }
        }
    }
}
