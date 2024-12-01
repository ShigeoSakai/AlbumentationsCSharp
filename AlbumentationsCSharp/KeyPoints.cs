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
            [Description("XY座標")]
            XY,
            [Description("XY座標+Visible(CoCo)")]
            COCO,
            [Description("XY座標+角度")]
            XYA,
            [Description("XY座標+スケール")]
            XYS,
            [Description("XY座標+角度+スケール")]
            XYAS,
            [Description("XY座標+スケール+角度")]
            XYSA
        }

        public class KeyPointDetail
        {
            public string ClassName { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public int? Visible { get; set; } = null;
            public double? Angle { get; set; } = null;
            public double? Scale { get; set; } = null;
            public bool Valid { get; set; } = false;

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
            public KeyPointDetail(double x,double y, string className)
            {
                X = x;
                Y = y;
                ClassName = className;
                Valid = true;
            }
            public KeyPointDetail(double x,double y,int visible, string className) : this(x,y,className) => Visible = visible;
            public KeyPointDetail(double x, double y,double? angle,double? scale, string className) :this(x,y, className)
            {
                Angle = angle;
                Scale = scale;
                Valid = true;
            }
            public string GetString(KeyPointType format)
            {
                if (Valid)
                {
                    string result = string.Format("{0},{1}", X, Y);
                    if (format == KeyPointType.XY)
                        return result;
                    if ((format == KeyPointType.COCO) && (Visible.HasValue))
                        return result + string.Format(",{0}",Visible.Value);
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

        public KeyPointType DataType { get; private set; } = KeyPointType.COCO;
        public List<List<KeyPointDetail>> Data { get; private set; } = new List<List<KeyPointDetail>>();

        public delegate KeyPointDetail ConvertFunc(string[] data, KeyPointType dataType,ref int index,ref int list_index);

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

        public class KeyPointsTypeDef
        {
            public string Name { get; private set; }
            public KeyPointType Type { get; private set; }
            public ConvertFunc Func { get; private set; }

            public KeyPointsTypeDef(KeyPointType type, ConvertFunc func)
            {
                Type = type;
                Func = func;
                DescriptionAttribute descAttr = type.GetType().GetCustomAttribute<DescriptionAttribute>();
                if (descAttr != null)
                    Name = descAttr.Description;
                else 
                    Name = type.ToString();
            }
            public override string ToString()
            {
                return Name;
            }
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
            public static KeyPointsTypeDef GetItem(ComboBox comboBox)
            {
                if ((comboBox != null) && (comboBox.SelectedItem != null) &&
                    (comboBox.SelectedItem is KeyPointsTypeDef item))
                {
                    return item;
                }
                return null;
            }
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
        public KeyPoints(KeyPointType format,string filename) :this()
        {
            Load(format, filename);
        }
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
                                result += ((result.Length > 0) ? "," : "") + "\"" + label + "\"";
                        }
                    }
                }
                return result;
            }
            return null;
        }
        public string GetLeyPoints()
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
                return result;
            }
            return null;
        }

        public class KeyPointShape
        {
            public string Name { get; private set; }
            public Point Point { get; private set; }

            public KeyPointShape(Point point)
            {
                Point = point;
            }
            public KeyPointShape(string name,Point point) :this(point)
            {
                Name = name;
            }
        }
        public List<KeyPointShape> GetShape()
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
