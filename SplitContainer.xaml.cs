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
using System.Windows.Shapes;

namespace _3._1._3GridSplitter
{
    /// <summary>
    /// Логика взаимодействия для SplitContainer.xaml
    /// </summary>
    public partial class SplitContainer : Window
    {
        public string ViewModel { get; set; }

        public SplitContainer()
        {
            InitializeComponent();
        }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);//модально окно
        }

        public void ChageOwnerBackground()
        {
            this.Owner.Background = new SolidColorBrush(Colors.Red); //изменение беграунда на красный после закрытия модального окна
        }
    }
}
