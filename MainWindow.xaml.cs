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

namespace _3._1._3GridSplitter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frame.Navigate(new login());//ссылка на отображение фрейма
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SplitContainer taskWindow = new SplitContainer();//создание нового экземпляра класса окна
            taskWindow.ViewModel = "ViewModel";//создание модального окна
            taskWindow.Owner = this; //родительское окно
            taskWindow.Show();//открыть новое окно
            taskWindow.ShowViewModel();//открыть модальное окно при запуске нового окна

            foreach (Window window in this.OwnedWindows)
            {
                window.Background = new SolidColorBrush(Colors.Red);

                if (window is SplitContainer)
                    window.Title = "Новый заголовок!"; //изменение заголовка окна на новый
            }
        }
    }


}
