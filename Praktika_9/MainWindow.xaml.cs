using Praktika_9.ApplicationData;
using Praktika_9.MainPage;
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

namespace Praktika_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppFrame.FrameMain = MainFrame;
            MainFrame.Navigate(new Login());
        }

        private void Avtirizazia_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new Login());
        }

        private void Psixiatr_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new MainPage.Zapisi());
        }

        private void ZapisNaPriem_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new ZapisNaPriem(null));
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new MainPage.Client());
        }
    }
}
