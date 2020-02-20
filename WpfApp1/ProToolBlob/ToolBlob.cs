using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProToolBase;
using System.ComponentModel;
namespace ProToolBlob
{
    public class ToolBlob : ToolBase ,INotifyPropertyChanged
    {
        public static string s;
        private double min;
        public override double Min
        {
            get { return min; }
            set { min = value; OnPropertyChanged(new PropertyChangedEventArgs("Min")); }
        }

        private double max;
        public override double Max
        {
            get { return max; }
            set { max = value; OnPropertyChanged(new PropertyChangedEventArgs("Max")); }
        }

        public override string Oper
        {
            get { return "面积检测"; }
        }

      

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        
    }
}
