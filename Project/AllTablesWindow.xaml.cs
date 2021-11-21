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

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для AllTablesWindow.xaml
    /// </summary>
    public partial class AllTablesWindow : Page
    {
        public AllTablesWindow()
        {
            InitializeComponent();
        }

        private void btnDistricts_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new DistrictPage());
        }

        private void btnRealtors_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AgentsPage());
        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new ClientsPage());
        }

        private void btnSupplies_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new SuplicePage());
        }

        private void btnDemands_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new DemadsPage());
        }

        private void btnDeals_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new DealsPage());
        }
    }
}
