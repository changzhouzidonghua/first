using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProToolBase
{
    public abstract  class ToolBase
    {
        public abstract double Min { get; set; }
        public abstract double Max { get; set; }
        public abstract string Oper { get; }
    }
}
