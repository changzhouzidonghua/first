using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProToolBase;
using System.ComponentModel;
namespace WpfControlLibrary1
{
    public class Class1 : ToolBase,INotifyPropertyChanged
    {
        public override double Min { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Max { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Oper => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
