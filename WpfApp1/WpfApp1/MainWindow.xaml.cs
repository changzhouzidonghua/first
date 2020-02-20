using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using ProToolBase;
namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string path = System.IO.Path.GetFullPath("plug");
            string[] files = System.IO.Directory.GetFiles(path);
            foreach (string item in files)
            {
               
              
                    Assembly assembly = Assembly.LoadFile(item);

                Type[] types = assembly.GetExportedTypes();
                for (int i = 0; i < types.Length; i++)
                {
                    if (typeof(ToolBase).IsAssignableFrom(types[i]))
                    {
                        ToolBase toolBase = Activator.CreateInstance(types[i]) as ToolBase;
                        Button button = new Button();
                        button.Content = toolBase.Oper;
                        
                        button.Style = this.FindResource("styleButton") as Style;
                        
                        mWrapPanel.Children.Add(button);


                    }
                }
            }
        }
    }
}
