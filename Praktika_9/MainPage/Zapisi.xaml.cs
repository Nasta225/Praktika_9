using Praktika_9.ApplicationData;
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

namespace Praktika_9.MainPage
{
    /// <summary>
    /// Логика взаимодействия для Zapisi.xaml
    /// </summary>
    public partial class Zapisi : Page
    {
        public Zapisi()
        {
            InitializeComponent();
            DtGrid.ItemsSource = ObhestvoEntities.GetContext().Zapisi.ToList();
        }

        private void ButDobavit_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new ClientAdd());
        }

        private void ButDel_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
