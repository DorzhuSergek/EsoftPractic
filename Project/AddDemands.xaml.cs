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
    /// Логика взаимодействия для AddDemands.xaml
    /// </summary>
    public partial class AddDemands : Page
    {
        Demands demands = new Demands();
        public AddDemands(Demands _demands)
        {
            InitializeComponent();
            if (_demands != null)
            {
                demands = _demands;
            }
            DataContext = demands;
            List<string> types = new List<string>();
            types.Add("Квартира");
            types.Add("Дом");
            types.Add("Земля");
            Type.ItemsSource = types;
            IdClient.ItemsSource = RealEstateAgencyEntities3.GetContext().clients.ToList();
            IDAgent.ItemsSource = RealEstateAgencyEntities3.GetContext().agents.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (demands.Id == 0)
                {
                    RealEstateAgencyEntities3.GetContext().Demands.Add(demands);
                }
                RealEstateAgencyEntities3.GetContext().SaveChanges();
                MessageBox.Show("Все успешно");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
    }
}
