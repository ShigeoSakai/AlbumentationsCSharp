using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase.Parts
{
    /// <summary>
    /// パラメータ変更イベントハンドラ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    public delegate void ParameterChangeEventHandler(object sender, string name, object value);
}
