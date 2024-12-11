using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumentationsCSharp
{
    public enum BBoxFormat
    {
        [Description("Pascal VOC"),EnumCommandName("pascal_voc")]
        PASCAL_VOC,
        [Description("Albumentations"), EnumCommandName("albumentations")]
        Albumentations,
        [Description("Coco"), EnumCommandName("coco")]
        COCO,
        [Description("YoLo"), EnumCommandName("yolo")]
        YOLO,
    }
    [System.AttributeUsage(AttributeTargets.Field)]
    public class EnumCommandNameAttribute : Attribute
    {
        public string Command { get; private set; }
        public EnumCommandNameAttribute(string command) => Command = command;
    }



    public class BBoxFormatClass
    {
        public string Name { get;private set; }
        public string Description {  get;private set; }

        public BBoxFormat Format { get;private set; }

        public BBoxFormatClass(string name, string description,BBoxFormat format)
        {
            Name = name;
            Description = description;
            Format = format;
        }
        public override string ToString()
        {
            return Description;
        }

        public static void MakeComboBox(ComboBox comboBox,BBoxFormat default_value)
        {
            comboBox.Items.Clear();
            int index = 0;
            int select_index = -1;
            foreach(BBoxFormat fmt in Enum.GetValues(typeof(BBoxFormat)))
            {
                FieldInfo fieldInfo = fmt.GetType().GetField(fmt.ToString());          
                DescriptionAttribute attr = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo,typeof(DescriptionAttribute));
                comboBox.Items.Add(new BBoxFormatClass(fmt.ToString(), (attr != null) ? attr.Description : fmt.ToString(), fmt));
                if (fmt == default_value)
                    select_index = index;
                index++;
            }
            if (select_index >= 0)
                comboBox.SelectedIndex = select_index;
            else
                comboBox.SelectedIndex = 0;
        }
        public static BBoxFormat GetItem(ComboBox comboBox, BBoxFormat default_value= BBoxFormat.COCO)
        {
            if ((comboBox.SelectedItem != null) && (comboBox.SelectedItem is BBoxFormatClass item))
                return item.Format;
            else return default_value;
        }
        public static bool SetItem(ComboBox comboBox, BBoxFormat value)
        {
            for(int index = 0; index < comboBox.Items.Count; index++)
            {
                if ((comboBox.Items[index] is BBoxFormatClass item) && 
                    (item.Format == value))
                {
                    comboBox.SelectedIndex = index;
                    return true;
                }
            }
            return false;
        }

    }
}
