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
    /// Логика взаимодействия для ZapisNaPriem.xaml
    /// </summary>
    public partial class ZapisNaPriem : Page
    {
        private Zapisi _currenttovar = new Zapisi();
        public ZapisNaPriem( Zapisi selectedtovar)
        {
            InitializeComponent();
            if (selectedtovar != null)
                _currenttovar = selectedtovar;

            DataContext = _currenttovar;
            ComboDate.ItemsSource = ObhestvoEntities.GetContext().Date.ToList();
            ComboStatus.ItemsSource = ObhestvoEntities.GetContext().Status.ToList();
            ComboClient.ItemsSource = ObhestvoEntities.GetContext().Client.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
