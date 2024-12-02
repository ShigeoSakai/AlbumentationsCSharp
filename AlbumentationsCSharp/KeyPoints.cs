using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlbumentationsCSharp.KeyPoints;

namespace AlbumentationsCSharp
{
    public class KeyPoints
    {
        /// <summary>
        /// キーポイントのフォーマット
        /// </summary>
        public enum KeyPointType
        {
            [Description("XY座標"),EnumCommandName("xy")]
            XY,
            [Description("XY座標+Visible(CoCo)"), EnumCommandName("xy")]
            COCO,
            [Description("XY座標+角度"), EnumCommandName("xya")]
            XYA,
            [Description("XY座標+スケール"), EnumCommandName("xys")]
            XYS,
            [Description("XY座標+角度+スケール"), EnumCommandName("xyas")]
            XYAS,
            [Description("XY座標+スケール+角度"), EnumCommandName("xysa")]
            XYSA
        }
        /// <summary>
        /// キーポイント詳細
        /// </summary>
        public class KeyPointDetail
        {
            /// <summary>
            /// クラス名
            /// </summary>
            public string ClassName { get; set; }
            /// <summary>
            /// X座標
            /// </summary>
            public double X { get; set; }
            /// <summary>
            /// Y座標
            /// </summary>
            public double Y { get; set; }
            /// <summary>
            /// Visible(0:なし/1:隠れている/2:見えている)
            /// </summary>
            public int? Visible { get; set; } = null;
            /// <summary>
            /// 角度
            /// </summary>
            public double? Angle { get; set; } = null;
            /// <summary>
            /// スケール
            /// </summary>
            public double? Scale { get; set; } = null;
            /// <summary>
            /// 有効か
            /// </summary>
            public bool Valid { get; set; } = false;
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="format">フォーマット</param>
            /// <param name="text">文字列</param>
            /// <param name="className">クラス名</param>
            public KeyPointDetail(KeyPointType format, string text,string className)
            {
                string[] datas = text.Split(new char[] { ',', '\t' }, StringSplitOptions.None);
                if (datas.Length >= 2)
                {
                    ClassName = className;
                    // X座標
                    if ((string.IsNullOrEmpty(datas[0])) ||
                        (double.TryParse(datas[0], out double x) == false)) return;
                    X = x;
                    // Y座標
                    if ((string.IsNullOrEmpty(datas[1])) ||
                        (double.TryParse(datas[1], out double y) == false)) return;
                    Y = y;
                    if (format == KeyPointType.COCO)
                    {
                        if ((datas.Length < 3) || (string.IsNullOrEmpty(datas[2])) ||
                            (int.TryParse(datas[2], out int visible) == false)) return;
                        Visible = visible;
                    }
                    if ((format == KeyPointType.XYA) || (format == KeyPointType.XYAS))
                    {
                        if ((datas.Length < 3) || (string.IsNullOrEmpty(datas[2])) ||
                            (double.TryParse(datas[2], out double angle) == false)) return;
                        Angle = angle;
                    }
                    if ((format == KeyPointType.XYS) || (format == KeyPointType.XYSA))
                    {
                        if ((datas.Length < 3) || (string.IsNullOrEmpty(datas[2])) ||
                            (double.TryParse(datas[2], out double scale) == false)) return;
                        Scale = scale;
                    }
                    if (format == KeyPointType.XYAS)
                    {
                        if ((datas.Length < 4) || (string.IsNullOrEmpty(datas[3])) ||
                            (double.TryParse(datas[3], out double scale) == false)) return;
                        Scale = scale;
                    }
                    if (format == KeyPointType.XYSA)
                    {
                        if ((datas.Length < 4) || (string.IsNullOrEmpty(datas[3])) ||
                            (double.TryParse(datas[3], out double angle) == false)) return;
                        Angle = angle;
                    }
                    Valid = true;
                }
            }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="x">X座標</param>
            /// <param name="y">Y座標</param>
            /// <param name="className">クラス名</param>
            public KeyPointDetail(double x,double y, string className)
            {
                X = x;
                Y = y;
                ClassName = className;
                Valid = true;
            }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="x">X座標</param>
            /// <param name="y">Y座標</param>
            /// <param name="visible">Visible値</param>
            /// <param name="className">クラス名</param>
            public KeyPointDetail(double x,double y,int visible, string className) : this(x,y,className) => Visible = visible;
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="x">X座標</param>
            /// <param name="y">Y座標</param>
            /// <param name="angle">角度</param>
            /// <param name="scale">スケール</param>
            /// <param name="className">クラス名</param>
            public KeyPointDetail(double x, double y,double? angle,double? scale, string className) :this(x,y, className)
            {
                Angle = angle;
                Scale = scale;
                Valid = true;
            }
            /// <summary>
            /// 文字列で座標値を取得
            /// </summary>
            /// <param name="format">フォーマット</param>
            /// <returns></returns>
            public string GetString(KeyPointType format)
            {
                if (Valid)
                {
                    string result = string.Format("{0},{1}", X, Y);
                    if (format == KeyPointType.XY)
                        return result;
                    if ((format == KeyPointType.COCO) && (Visible.HasValue))
                        //return result + string.Format(",{0}",Visible.Value);
                        return result;
                    if ((Angle.HasValue) &&
                        ((format == KeyPointType.XYA) || (format == KeyPointType.XYAS)))
                        result += string.Format(",{0}", Angle.Value);
                    if ((Scale.HasValue) &&
                        ((format == KeyPointType.XYS) || (format == KeyPointType.XYSA)))
                        result += string.Format(",{0}", Scale.Value);
                    if ((format == KeyPointType.XYA) || (format == KeyPointType.XYS))
                        return result;
                    if ((Angle.HasValue) && (format == KeyPointType.XYSA))
                        return  result + string.Format(",{0}", Angle.Value);
                    if ((Scale.HasValue) && (format == KeyPointType.XYAS))
                        return result + string.Format(",{0}", Scale.Value);
                }
                return null;
            }
        }
        /// <summary>
        /// データタイプ
        /// </summary>
        public KeyPointType DataType { get; private set; } = KeyPointType.COCO;
        /// <summary>
        /// キーポイントリスト
        /// </summary>
        public List<List<KeyPointDetail>> Data { get; private set; } = new List<List<KeyPointDetail>>();

        /// <summary>
        /// 文字列から座標変換
        /// </summary>
        /// <param name="data">文字配列</param>
        /// <param name="dataType">データタイプ</param>
        /// <param name="index">インデックス</param>
        /// <param name="list_index">リストのインデックス</param>
        /// <returns></returns>
        public delegate KeyPointDetail ConvertFunc(string[] data, KeyPointType dataType,ref int index,ref int list_index);

        /// <summary>
        /// XY座標変換
        /// </summary>
        /// <param name="data">文字配列</param>
        /// <param name="dataType">データタイプ</param>
        /// <param name="index">インデックス</param>
        /// <param name="list_index">リストのインデックス</param>
        /// <returns></returns>
        private static KeyPointDetail XYConverter(string[] data, KeyPointType dataType, ref int index, ref int list_index)
        {
            if (index + 1 < data.Length)
            {   
                if ((string.IsNullOrEmpty(data[index]) == false) &&
                        (double.TryParse(data[index],out double x)) &&
                    (string.IsNullOrEmpty(data[index+1]) == false) &&
                        (double.TryParse(data[index+1], out double y)))
                {
                    index += 2;
                    string label = ((Labels.ContainsKey(dataType)) && (list_index < Labels[dataType].Length)) ? Labels[dataType][list_index] : "";
                    list_index++;
                    return new KeyPointDetail(x, y,label);
                }
                index += 2;
                list_index++;
                return null;
            }
            index = data.Length;
            list_index++;
            return null;
        }
        /// <summary>
        /// CoCo座標変換
        /// </summary>
        /// <param name="data">文字配列</param>
        /// <param name="dataType">データタイプ</param>
        /// <param name="index">インデックス</param>
        /// <param name="list_index">リストのインデックス</param>
        /// <returns></returns>
        private static KeyPointDetail CoCoConverter(string[] data, KeyPointType dataType, ref int index, ref int list_index)
        {
            if (index + 2 < data.Length)
            {
                KeyPointDetail keypoints = XYConverter(data,dataType, ref index,ref list_index);
                if ((keypoints != null) && (string.IsNullOrEmpty(data[index]) == false) &&
                    (int.TryParse(data[index],out int visible)) && (visible != 0))
                {
                    index += 1;
                    keypoints.Visible = visible;
                    return keypoints;
                }
                index += 1;
                return null;
            }
            index = data.Length;
            return null;
        }
        /// <summary>
        /// XYA座標変換
        /// </summary>
        /// <param name="data">文字配列</param>
        /// <param name="dataType">データタイプ</param>
        /// <param name="index">インデックス</param>
        /// <param name="list_index">リストのインデックス</param>
        /// <returns></returns>

        private static KeyPointDetail XYAConverter(string[] data, KeyPointType dataType, ref int index, ref int list_index)
        {
            if (index + 2 < data.Length)
            {
                KeyPointDetail keypoints = XYConverter(data,dataType, ref index, ref list_index);
                if ((keypoints != null) && (string.IsNullOrEmpty(data[index]) == false) &&
                    (double.TryParse(data[index], out double angle)))
                {
                    index += 1;
                    keypoints.Angle = angle;
                    return keypoints;
                }
                index += 1;
                return null;
            }
            index = data.Length;
            return null;
        }
        /// <summary>
        /// XYS座標変換
        /// </summary>
        /// <param name="data">文字配列</param>
        /// <param name="dataType">データタイプ</param>
        /// <param name="index">インデックス</param>
        /// <param name="list_index">リストのインデックス</param>
        /// <returns></returns>
        private static KeyPointDetail XYSConverter(string[] data, KeyPointType dataType, ref int index, ref int list_index)
        {
            if (index + 2 < data.Length)
            {
                KeyPointDetail keypoints = XYConverter(data,dataType, ref index, ref list_index);
                if ((keypoints != null) && (string.IsNullOrEmpty(data[index]) == false) &&
                    (double.TryParse(data[index], out double scale)))
                {
                    index += 1;
                    keypoints.Scale = scale;
                    return keypoints;
                }
                index += 1;
                return null;
            }
            index = data.Length;
            return null;
        }
        /// <summary>
        /// XYSA座標変換
        /// </summary>
        /// <param name="data">文字配列</param>
        /// <param name="dataType">データタイプ</param>
        /// <param name="index">インデックス</param>
        /// <param name="list_index">リストのインデックス</param>
        /// <returns></returns>
        private static KeyPointDetail XYSAConverter(string[] data, KeyPointType dataType, ref int index, ref int list_index)
        {
            if (index + 3 < data.Length)
            {
                KeyPointDetail keypoints = XYSConverter(data,dataType, ref index, ref list_index);
                if ((keypoints != null) && (string.IsNullOrEmpty(data[index]) == false) &&
                    (double.TryParse(data[index], out double angle)))
                {
                    index += 1;
                    keypoints.Angle = angle;
                    return keypoints;
                }
                index += 1;
                return null;
            }
            index = data.Length;
            return null;
        }
        /// <summary>
        /// XYAS座標変換
        /// </summary>
        /// <param name="data">文字配列</param>
        /// <param name="dataType">データタイプ</param>
        /// <param name="index">インデックス</param>
        /// <param name="list_index">リストのインデックス</param>
        /// <returns></returns>
        private static KeyPointDetail XYASConverter(string[] data, KeyPointType dataType, ref int index, ref int list_index)
        {
            if (index + 3 < data.Length)
            {
                KeyPointDetail keypoints = XYAConverter(data,dataType, ref index, ref list_index);
                if ((keypoints != null) && (string.IsNullOrEmpty(data[index]) == false) &&
                    (double.TryParse(data[index], out double scale)))
                {
                    index += 1;
                    keypoints.Scale = scale;
                    return keypoints;
                }
                index += 1;
                return null;
            }
            index = data.Length;
            return null;
        }
        /// <summary>
        /// ラベル辞書
        /// </summary>
        private static Dictionary<KeyPointType, string[]> Labels = new Dictionary<KeyPointType, string[]>()
        {
            {KeyPointType.COCO, new string[] {
                "nose", "left_eye", "right_eye", "left_ear", "right_ear", "left_shoulder", "right_shoulder",
                "left_elbow", "right_elbow", "left_wrist", "right_wrist", "left_hip", "right_hip", "left_knee",
                "right_knee", "left_ankle", "right_ankle" } }
        };
        /// <summary>
        /// コンボボックス/ファイル変換用キーポイントデータタイプ定義
        /// </summary>
        public class KeyPointsTypeDef
        {
            /// <summary>
            /// 名前
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// データタイプ
            /// </summary>
            public KeyPointType Type { get; private set; }
            /// <summary>
            /// 変換メソッド
            /// </summary>
            public ConvertFunc Func { get; private set; }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="type"></param>
            /// <param name="func"></param>
            public KeyPointsTypeDef(KeyPointType type, ConvertFunc func)
            {
                Type = type;
                Func = func;
                FieldInfo fieldInfo = type.GetType().GetField(type.ToString());
                DescriptionAttribute descAttr = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo,typeof(DescriptionAttribute));
                if (descAttr != null)
                    Name = descAttr.Description;
                else 
                    Name = type.ToString();
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
            /// 変換メソッド取得
            /// </summary>
            /// <param name="defs"></param>
            /// <param name="type"></param>
            /// <returns></returns>
            public static ConvertFunc GetFunc(List<KeyPointsTypeDef> defs, KeyPointType type)
            {
                if (defs != null)
                {
                    foreach (KeyPointsTypeDef def in defs)
                        if (def.Type == type)
                            return def.Func;
                }
                return null;
            }
            /// <summary>
            /// コンボボックス作成
            /// </summary>
            /// <param name="comboBox"></param>
            /// <param name="defs"></param>
            /// <param name="default_value"></param>
            public static void MakeComboBox(ComboBox comboBox, List<KeyPointsTypeDef> defs, KeyPointType default_value)
            {
                comboBox.Items.Clear();
                if ((defs != null) && (defs.Count > 0))
                {
                    int select_index = 0;
                    for(int index = 0; index < defs.Count;index ++)
                    {
                        comboBox.Items.Add(defs[index]);
                        if (defs[index].Type == default_value)
                            select_index = index;
                    }
                    comboBox.SelectedIndex = select_index;           
                }
            }
            /// <summary>
            /// コンボボックスから定義を取得
            /// </summary>
            /// <param name="comboBox"></param>
            /// <returns></returns>
            public static KeyPointsTypeDef GetItem(ComboBox comboBox)
            {
                if ((comboBox != null) && (comboBox.SelectedItem != null) &&
                    (comboBox.SelectedItem is KeyPointsTypeDef item))
                {
                    return item;
                }
                return null;
            }
            /// <summary>
            /// コンボボックスからデータタイプを取得
            /// </summary>
            /// <param name="comboBox"></param>
            /// <param name="default_item"></param>
            /// <returns></returns>
            public static KeyPointType GetItemType(ComboBox comboBox, KeyPointType default_item)
            {
                if ((comboBox != null) && (comboBox.SelectedItem != null) &&
                    (comboBox.SelectedItem is KeyPointsTypeDef item))
                {
                    return item.Type;
                }
                return default_item;
            }

        }
        /// <summary>
        /// キーポイント コンボボックス/ファイル変換用リスト
        /// </summary>
        public static List<KeyPointsTypeDef> KeyPointsFileConverters = new List<KeyPointsTypeDef>()
        {
            new KeyPointsTypeDef(KeyPointType.XY,XYConverter),
            new KeyPointsTypeDef(KeyPointType.COCO, CoCoConverter),
            new KeyPointsTypeDef(KeyPointType.XYA, XYAConverter),
            new KeyPointsTypeDef(KeyPointType.XYS, XYSConverter),
            new KeyPointsTypeDef(KeyPointType.XYAS, XYASConverter),
            new KeyPointsTypeDef(KeyPointType.XYSA, XYSAConverter)
       };


        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public KeyPoints() 
        {
        }
        /// <summary>
        /// コピーコンストラクタ
        /// </summary>
        /// <param name="src"></param>
        public KeyPoints(KeyPoints src) :this()
        {
            DataType = src.DataType;
            foreach (List<KeyPointDetail> item in src.Data)
            {
                List<KeyPointDetail> list = new List<KeyPointDetail>();
                foreach (KeyPointDetail detail in item)
                {
                    list.Add(detail);
                }
                Data.Add(list);
            }
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="format">データタイプ</param>
        /// <param name="filename">ファイル名</param>
        public KeyPoints(KeyPointType format,string filename) :this()
        {
            Load(format, filename);
        }
        /// <summary>
        /// コンストラクタ
        /// 検出結果からキーポイント
        /// </summary>
        /// <param name="filename"></param>
        public KeyPoints(string filename)
        {
            if (File.Exists(filename))
            {
                Data.Clear();
                using (StreamReader sr = new StreamReader(filename))
                {
                    while (sr.EndOfStream == false)
                    {
                        string text = sr.ReadLine();
                        string[] datas = text.Split(new char[] { ',', '\t' }, StringSplitOptions.None);
                        if ((datas != null) && (datas.Length >= 3))
                        {
                            string name = datas[0];
                            if ((double.TryParse(datas[1], out double x)) &&
                                (double.TryParse(datas[2], out double y)))
                            {
                                List<KeyPointDetail> list = new List<KeyPointDetail> { new KeyPointDetail(x, y, name) };
                                Data.Add(list);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// ファイルからキーポイント読み込み
        /// </summary>
        /// <param name="format"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public int Load(KeyPointType format, string filename)
        {
            if (File.Exists(filename))
            {
                Data.Clear();
                DataType = format;
                return Add(format, filename);
            }
            return -1;
        }
        /// <summary>
        /// ファイルからキーポイント追加
        /// </summary>
        /// <param name="format"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public int Add(KeyPointType format, string filename)
        {
            ConvertFunc func = KeyPointsTypeDef.GetFunc(KeyPointsFileConverters, format);
            if ((File.Exists(filename)) && (func != null)) 
            {
                using (StreamReader sr = new StreamReader(filename))
                {

                    while (sr.EndOfStream == false)
                    {
                        string text = sr.ReadLine();
                        string[] datas = text.Split(new char[] { ',', '\t' }, StringSplitOptions.None);
                        List<KeyPointDetail> list = new List<KeyPointDetail>();
                        int index = 0;
                        int list_index = 0;
                        while (index < datas.Length)
                        {
                            KeyPointDetail detail = func(datas,DataType, ref index,ref list_index);
                            if (detail != null)
                                list.Add(detail);
                        }
                        if (list.Count > 0)
                            Data.Add(list);
                    }
                }
                return Data.Count;
            }
            return -1;
        }
        /// <summary>
        /// ラベル（クラス名）一覧を取得
        /// </summary>
        /// <returns></returns>
        public string GetLabels()
        {
            if (Data.Count > 0)
            {
                string result = "";
                foreach (List<KeyPointDetail> item in Data)
                {
                    for (int i = 0; i < item.Count; i++)
                    {
                        if (item[i].Valid)
                        {
                            string label = item[i].ClassName;
                            result += ((result.Length > 0) ? "," : "");
                            if (string.IsNullOrEmpty(label) == false)
                                result += "'" + label + "'";

                        }
                    }
                }
                if (result.Length > 0)
                    return "[" + result + "]";
            }
            return null;
        }
        /// <summary>
        /// キーポイントを文字列で取得(python用)
        /// </summary>
        /// <returns></returns>
        public string GetKeyPoints()
        {
            if (Data.Count > 0)
            {
                string result = "";
                foreach (List<KeyPointDetail> item in Data)
                {
                    for (int i = 0; i < item.Count; i++)
                    {
                        if (item[i].Valid)
                        {
                            result += ((result.Length > 0) ? "," : "");
                            result += "[" + item[i].GetString(DataType) + "]";
                        }
                    }
                }
                if (result.Length > 0)
                    return "[" + result + "]";
            }
            return null;
        }
        /// <summary>
        /// データフォーマットの文字列取得(python用)
        /// </summary>
        /// <returns></returns>
        public string GetFormat()
        {
            FieldInfo fieldInfo = DataType.GetType().GetField(DataType.ToString());
            EnumCommandNameAttribute attr = (EnumCommandNameAttribute)Attribute.GetCustomAttribute(fieldInfo,typeof(EnumCommandNameAttribute));
            if (attr != null)
                return attr.Command;
            return DataType.ToString(); ;
        }

        /// <summary>
        /// キーポイントの図形クラス
        /// </summary>
        public class KeyPointShape
        {
            /// <summary>
            /// クラス名
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// 座標値
            /// </summary>
            public Point Point { get; private set; }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="point"></param>
            public KeyPointShape(Point point)
            {
                Point = point;
            }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="name"></param>
            /// <param name="point"></param>
            public KeyPointShape(string name,Point point) :this(point)
            {
                Name = name;
            }
        }
        /// <summary>
        /// キーポイントの図形データを取得
        /// </summary>
        /// <returns></returns>
        public List<KeyPointShape> GetShapes()
        {
            if (Data.Count > 0)
            {
                List<KeyPointShape> list = new List<KeyPointShape>();
                foreach (List<KeyPointDetail> item in Data)
                {
                    for (int i = 0; i < item.Count; i++)
                    {
                        if (item[i].Valid)
                        {
                            string label = item[i].ClassName;
                            Point point = new Point((int)item[i].X, (int)item[i].Y);
                            list.Add(new KeyPointShape(label, point));
                        }
                    }
                }
                return list;
            }
            return null;
        }
    }
}
