using FilterBase.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterBase.Enums
{
    public enum CV2_BORDER
    {
        [Description("iiiiii|abcdefgh|iiiiiii")]
        CONSTANT = 0,    //!< `iiiiii|abcdefgh|iiiiiii`  with some specified `i`
        [Description("aaaaaa|abcdefgh|hhhhhhh")]
        REPLICATE = 1,   //!< `aaaaaa|abcdefgh|hhhhhhh`
        [Description("fedcba|abcdefgh|hgfedcb")]
        REFLECT = 2,     //!< `fedcba|abcdefgh|hgfedcb`
        [Description("cdefgh|abcdefgh|abcdefg")]
        WRAP = 3,        //!< `cdefgh|abcdefgh|abcdefg`
        [Description("gfedcb|abcdefgh|gfedcba")]
        REFLECT_101 = 4, //!< `gfedcb|abcdefgh|gfedcba`
        [Description("uvwxyz|abcdefgh|ijklmno")]
        TRANSPARENT = 5, //!< `uvwxyz|abcdefgh|ijklmno` - Treats outliers as transparent.
        [Description("REFLECT_101と同じ")]
        REFLECT101 = REFLECT_101,     //!< same as BORDER_REFLECT_101
        [Description("REFLECT_101と同じ")]
        DEFAULT = REFLECT_101,        //!< same as BORDER_REFLECT_101
        [Description("補間は ROI 境界内に制限")]
        ISOLATED = 16                 //!< Interpolation restricted within the ROI boundaries.
    }
    /// <summary>
    /// ボーダー種別のクラス
    /// </summary>
    public class BorderTypes : EnumComboClass<CV2_BORDER>, IComboBox
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="border"></param>
        public BorderTypes(CV2_BORDER border) : base(border) { }
        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <param name="comboBox"></param>
        public static void MakeComboBox(ComboBox comboBox)
        {
            MakeComboBox<BorderTypes>(comboBox);
        }
        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="default_item"></param>
        public static void MakeComboBox(ComboBox comboBox, string default_item)
        {
            MakeComboBox<BorderTypes>(comboBox, default_item);
        }
        /// <summary>
        /// コンボボックスの生成
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="default_item"></param>
        public static void MakeComboBox(ComboBox comboBox, CV2_BORDER default_item)
        {
            MakeComboBox<BorderTypes>(comboBox, default_item);
        }
        /// <summary>
        /// コンボボックスの値を取得
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="default_value"></param>
        /// <returns></returns>
        public static CV2_BORDER GetComboBox(ComboBox comboBox, CV2_BORDER default_value = CV2_BORDER.CONSTANT)
        {
            return GetComboBox<BorderTypes>(comboBox,default_value);
        }

    }
}
