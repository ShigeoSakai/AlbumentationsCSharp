using FilterBase.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterBase.Enums
{
    public enum CV2_INTER
    {
        [Description("最近傍")]
        NEAREST = 0,
        [Description("バイリニア")]
        LINEAR = 1,
        [Description("バイキュービック")]
        CUBIC = 2,
        [Description("エリア")]
        AREA = 3,
        [Description("LANCZOS4")]
        LANCZOS4 = 4,
        [Description("ビット精度バイリニア")]
        LINEAR_EXACT = 5,
        [Description("ビット精度最近傍")]
        NEAREST_EXACT = 6,
        MAX = 7,
        WARP_FILL_OUTLIERS = 8,
        WARP_INVERSE_MAP = 16,
    }

    public class InterpolationFlags : EnumComboClass<CV2_INTER> ,IComboBox
    {
        public InterpolationFlags(CV2_INTER value):base(value) { }

        public static void MakeComboBox(ComboBox comboBox, IEnumerable<CV2_INTER> flags, CV2_INTER default_item)
        {
            MakeComboBox<InterpolationFlags>(comboBox, flags, default_item);
        }

        public static void MakeComboBox(ComboBox comboBox, CV2_INTER default_item)
        {
            CV2_INTER[] flags = new CV2_INTER[] {
                    CV2_INTER.NEAREST,
                    CV2_INTER.LINEAR,
                    CV2_INTER.CUBIC,
                    CV2_INTER.LANCZOS4
            };
            MakeComboBox(comboBox, flags,　default_item);
        }
        public static void MakeComboBox(ComboBox comboBox, string default_item)
        {
            CV2_INTER[] flags = new CV2_INTER[] {
                    CV2_INTER.NEAREST,
                    CV2_INTER.LINEAR,
                    CV2_INTER.CUBIC,
                    CV2_INTER.LANCZOS4
            };
            MakeComboBox<InterpolationFlags>(comboBox, (IEnumerable<CV2_INTER>)flags, default_item);
        }
        public static CV2_INTER GetComboBox(ComboBox comboBox,CV2_INTER default_value)
        {
            return GetComboBox<InterpolationFlags>(comboBox, default_value);
        }
    }
}
