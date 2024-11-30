using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterBase
{
    public interface IComboBox
    {
        /// <summary>
        /// 引数に設定する値
        /// </summary>
        string ArgumentValue { get; }

    }
}
