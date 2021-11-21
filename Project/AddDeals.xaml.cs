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
    /// Логика взаимодействия для AddDeals.xaml
    /// </summary>
    public partial class AddDeals : Page
    {
        public deals deals = new deals();
        public AddDeals(deals _deals)
        {
            InitializeComponent();
            if (_deals != null)
                deals = _deals;
            DataContext = deals;
            CBDemands.ItemsSource = RealEstateAgencyEntities3.GetContext().Demands.ToList();
            CBSupplies.ItemsSource = RealEstateAgencyEntities3.GetContext().supplies.ToList();
        }

        private void addDeal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (deals.Id == 0)
                {
                    RealEstateAgencyEntities3.GetContext().deals.Add(deals);
                }
                RealEstateAgencyEntities3.GetContext().SaveChanges();
                MessageBox.Show("Все успешно");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
