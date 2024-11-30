using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    /// <summary>
    /// カテゴリー属性
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Class)]
    public class ModuleCategoryAttribute : Attribute
    {
        public string Module { get; private set; }
        public string Name { get; private set; }
        public ModuleCategoryAttribute(string name) => Name = name;
        public ModuleCategoryAttribute(string module,string name) :this(name) => Module = module;
    }
    /// <summary>
    /// インデックス属性
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Class)]
    public class IndexAttribute : Attribute
    {
        public int Index { get; private set; }
        public IndexAttribute(int index) => Index = index;
    }
}
