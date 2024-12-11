using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumentationsCSharp
{
    public class BoundingBox
    {
        public class BoundingBoxDetail
        {
            public string ClassName { get; set; }
            public double X1 { get; set; }
            public double Y1 { get; set; }
            public double X2 { get; set; }
            public double Y2 { get; set; }

            public bool Valid { get; set; } = false;

            public BoundingBoxDetail(string name,double x1,double y1,double x2,double y2) 
            {
                ClassName = name;
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
                // 有効
                Valid = true;
            }
            public BoundingBoxDetail(BoundingBoxDetail src)
            {
                ClassName = src.ClassName;
                X1 = src.X1;
                Y1 = src.Y1;
                X2 = src.X2;
                Y2 = src.Y2;
                Valid = src.Valid;
            }

            public BoundingBoxDetail(string text, bool useCategory = false)
            {
                string[] datas = text.Split(new char[] { ',', '\t' }, StringSplitOptions.None);
                int max_length = (useCategory) ? (4 + 2) : (4 + 1);
                if (datas.Length >= max_length)
                {
                    int index = (useCategory) ? 1 : 0;
                    // 名前
                    ClassName = datas[index];
                    index++;
                    // X1座標値
                    if (double.TryParse(datas[index], out double x1) == false) return;
                        X1 = x1;
                    index++;
                    // Y1座標値
                    if (double.TryParse(datas[index], out double y1) == false) return;
                    Y1 = y1;
                    index++;
                    // X2座標値
                    if (double.TryParse(datas[index], out double x2) == false) return;
                    X2 = x2;
                    index++;
                    // Y2座標値
                    if (double.TryParse(datas[index], out double y2) == false) return;
                    Y2 = y2;
                    // 有効
                    Valid = true;
                }
            }

            /// <summary>
            /// 座標形式の変換
            /// </summary>
            /// <param name="from"></param>
            /// <param name="to"></param>
            /// <param name="width"></param>
            /// <param name="height"></param>
            public void Convert(BBoxFormat from, BBoxFormat to,int width,int height)
            {
                // 実座標値と幅,高さにする
                double tX = X1;
                double tY = Y1;
                double tW = X2;
                double tH = Y2;
                if ((from == BBoxFormat.Albumentations) || 
                    (from == BBoxFormat.YOLO))
                {   // 比率になっているので、座標値にする
                    tX *= width;
                    tY *= height;
                    tW *= width;
                    tH *= height;
                }
                if ((from == BBoxFormat.Albumentations) ||
                    (from == BBoxFormat.PASCAL_VOC))
                {   // X2,Y2は座標値なので、幅・高さにする
                    tW = tW - tX;
                    if (tW < 0)
                    {   // 幅がマイナスなので反転
                        tW *= -1;
                        tX = tX - tW;
                    }
                    tH = tH - tY;
                    if (tH < 0)
                    {   // 幅がマイナスなので反転
                        tH *= -1;
                        tY = tY - tH;
                    }
                }
                if (from == BBoxFormat.YOLO)
                {   // 中心座標なので、左上座標に変換
                    tX -= (tW / 2.0);
                    tY -= (tH / 2.0);
                }
                // 指定形式に変換する
                if (to == BBoxFormat.YOLO)
                {   // 左上座標から、中心座標に変換
                    tX += (tW * 2.0);
                    tY += (tH * 2.0);
                }
                if ((to == BBoxFormat.PASCAL_VOC) ||
                    (to == BBoxFormat.Albumentations))
                {   // X2,Y2は座標値
                    tW += tX;
                    tH += tY;
                }
                if ((to == BBoxFormat.Albumentations) ||
                    (to == BBoxFormat.YOLO))
                {   // 画像に対する比率
                    tX /= (double)width;
                    tY /= (double)height;
                    tW /= (double)width;
                    tH /= (double)height;
                }
                // 変換結果を格納する
                X1 = tX;
                Y1 = tY;
                X2 = tW; 
                Y2 = tH;
            }
            public string BBoxString(BBoxFormat format)
            {
                if (Valid)
                {
                    string fmt = "[{0},{1},{2},{3}]";
                    if ((format != BBoxFormat.Albumentations) && (format != BBoxFormat.YOLO))
                        return string.Format(fmt, (int)X1,(int)Y1,(int)X2,(int)Y2);
                    return string.Format(fmt, X1, Y1, X2, Y2);
                }
                return "";
            }
            public RectangleF GetRectangle(BBoxFormat format,int img_width,int img_height)
            {
                float x = (float)X1;
                float y = (float)Y1;
                float width = (float)X2;
                float height = (float)Y2;
                if ((format == BBoxFormat.Albumentations) || 
                    (format == BBoxFormat.YOLO))
                {
                    x *= img_width; y *= img_height;
                    width *= img_width; height *= img_height;
                }
                if ((format == BBoxFormat.PASCAL_VOC) ||
                    (format == BBoxFormat.Albumentations))
                {
                    width -= x;height -= y;
                }
                if (format == BBoxFormat.YOLO)
                {
                    x += width / 2.0F;
                    y += width / 2.0F;
                }
                return new RectangleF(x, y, width, height);
            }
        }

        /// <summary>
        /// フォーマット
        /// </summary>
        public BBoxFormat Format { get; set; }
        /// <summary>
        /// BBOX
        /// </summary>
        public List<BoundingBoxDetail> BBoxes { get;private set; } = new List<BoundingBoxDetail>();

        /// <summary>
        /// 日本語辞書
        /// </summary>
        private static Dictionary<string, string> JapaneseDict = new Dictionary<string, string>()
        {
            { "person","人" },{ "bicycle","自転車" },{ "car","車" },{ "motorcycle","バイク" },{ "airplane","飛行機" },
            { "bus","バス" },{ "train","電車" },{ "truck","トラック" },{ "boat","船" },{ "traffic light","信号機" },
            { "fire hydrant","消火栓" },{ "stop sign","停止標識" },{ "parking meter","パーキングメータ" },
            { "bench","ベンチ" },{ "bird","鳥" },{ "cat","猫" },{ "dog","犬" },{ "horse","馬" },{ "sheep","羊" },
            { "cow","牛" },{ "elephant","象" },{ "bear","熊" },{ "zebra","シマウマ" },{ "giraffe","キリン" },
            { "backpack","リュックサック" },{ "umbrella","傘" },{ "handbag","ハンドバッグ" },{ "tie","ネクタイ" },
            { "suitcase","スーツケース" },{ "frisbee","フリスビー" },{ "skis","スキー" },{ "snowboard","スノーボード" },
            { "sports ball","スポーツボール" },{ "kite","凧" },{ "baseball bat","バット" },{ "baseball glove","グローブ" },
            { "skateboard","スケートボード" },{ "surfboard","サーフボード" },{ "tennis racket","ラケット" },
            { "bottle","ビン" },{ "wine glass","ワイングラス" },{ "cup","コップ" },{ "fork","フォーク" },{ "knife","ナイフ" },
            { "spoon","スプーン" },{ "bowl","ボウル" },{ "banana","バナナ" },{ "apple","リンゴ" },
            { "sandwich","サンドウィッチ" },{ "orange","オレンジ" },{ "broccoli","ブロッコリー" },{ "carrot","ニンジン" },
            { "hot dog","ホットドッグ" },{ "pizza","ピザ" },{ "donut","ドーナツ" },{ "cake","ケーキ" },{ "chair","椅子" },
            { "couch","ソファー" },{ "potted plant","鉢植え" },{ "bed","ベッド" },{ "dining table","机" },
            { "toilet","トイレ" },{ "tv","TV" },{ "laptop","ノートパソコン" },{ "mouse","マウス" },
            { "remote","リモコン" },{ "keyboard","キーボード" },{ "cell phone","携帯電話" },{ "microwave","電子レンジ" },
            { "oven","オーブン" },{ "toaster","トースター" },{ "sink","流し台" },{ "refrigerator","冷蔵庫" },
            { "book","本" },{ "clock","時計" },{ "vase","花瓶" },{ "scissors","はさみ" },
            { "teddy bear","テディベア" },{ "hair drier","ドライヤー" },{ "toothbrush","歯ブラシ" },
        };

        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public BoundingBox() { }
        /// <summary>
        /// コピーコンストラクタ
        /// </summary>
        /// <param name="src"></param>
        public BoundingBox(BoundingBox src)
        {
            Format = src.Format;
            foreach (BoundingBoxDetail item in src.BBoxes)
            {
                BBoxes.Add(new BoundingBoxDetail(item));
            }
        }
        public BoundingBox(BBoxFormat format)
        {
            Format = format;
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="filename">CSV/TSVファイル名</param>
        public BoundingBox(BBoxFormat format, string filename)
        { 
            Load(format, filename);
        }
        /// <summary>
        /// ファイルから読み込み
        /// </summary>
        /// <param name="filename">CSV/TSVファイル名</param>
        /// <returns></returns>
        public int Load(BBoxFormat format, string filename)
        {
            if (File.Exists(filename))
            { 
                BBoxes.Clear();
                Format = format;
                return Add(format,filename);
            }
            return -1;
        }
        /// <summary>
        /// データの追加
        /// </summary>
        /// <param name="filename">CSV/TSVファイル名</param>
        /// <returns></returns>
        public int Add(BBoxFormat format, string filename)
        {
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    while(sr.EndOfStream == false)
                    {
                        string text = sr.ReadLine();
                        if ((text.StartsWith("#") == false) && (text.StartsWith("//") == false))
                            BBoxes.Add(new BoundingBoxDetail(text));
                    }
                }
                return BBoxes.Count;
            }
            return -1;
        }

        public string GetBoundingBox()
        {
            string result = "";
            foreach(BoundingBoxDetail item in BBoxes)
            {
                if (item.Valid)
                {
                    string bbox = item.BBoxString(Format);
                    if (string.IsNullOrEmpty(bbox) == false)
                        result += ((result.Length > 0) ? "," : "") + bbox;
                }
            }
            if (result.Length > 0)
                return "[" + result + "]";
            return "";
        }
        public string GetClassName()
        {
            string result = "";
            foreach (BoundingBoxDetail item in BBoxes)
            {
                if (item.Valid)
                {
                    string name = item.ClassName;
                    if (string.IsNullOrEmpty(name) == false)
                        result += ((result.Length > 0) ? "," : "") + "'" + name + "'";
                }
            }
            if (result.Length > 0)
                return "[" + result + "]";
            return "";
        }

        public string GetFormat()
        {
            FieldInfo fieldInfo = Format.GetType().GetField(Format.ToString());
            EnumCommandNameAttribute attr = (EnumCommandNameAttribute)Attribute.GetCustomAttribute(fieldInfo,typeof(EnumCommandNameAttribute));
            if (attr != null)
                return attr.Command;
            else
                return Format.ToString();
        }



        public void Convert(BBoxFormat newFormat,int width,int height)
        {
            foreach (BoundingBoxDetail item in BBoxes)
            {
                if (item.Valid)
                {
                    item.Convert(Format, newFormat, width, height);
                }
            }
            Format = newFormat;
        }

        public List<RectangleF> GetRectangles(int width, int height)
        {
            List<RectangleF> result = new List<RectangleF>();
            foreach (BoundingBoxDetail item in BBoxes)
            {
                if (item.Valid)
                {
                    result.Add(item.GetRectangle(Format, width, height));
                }
            }
            return result;
        }

        public class BBoxShape
        {
            public string Name { get; private set; }
            public RectangleF Rectangle { get; private set; }

            public BBoxShape(string name, RectangleF rectangle)
            {
                Name = name;
                Rectangle = rectangle;
            }
        }
        public List<BBoxShape> GetShapes(int width, int height)
        {
            List<BBoxShape> result = new List<BBoxShape>();
            foreach (BoundingBoxDetail item in BBoxes)
            {
                if (item.Valid)
                {
                    result.Add(new BBoxShape(item.ClassName, item.GetRectangle(Format, width, height)));
                }
            }
            return result;

        }
        /// <summary>
        /// 日本語変換
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetJapanese(string text)
        {
            if ((string.IsNullOrEmpty(text) == false) &&
                (JapaneseDict.ContainsKey(text)))
                return JapaneseDict[text];
            return text;
        }

    }
}
