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
    /// Логика взаимодействия для AddSupplice.xaml
    /// </summary>
    public partial class AddSupplice : Page
    {
        public supplies supplies = new supplies();
        public AddSupplice(supplies _supplies)
        {
            InitializeComponent();
            if (_supplies != null)
            {
                supplies = _supplies;

            }
            DataContext = supplies;
            NameAgent.ItemsSource = RealEstateAgencyEntities2.GetContext().agents.ToList();
            NameClient.ItemsSource = RealEstateAgencyEntities2.GetContext().clients.ToList();
            string[] types = new string[3] { "Дом", "Земля", "Квартира" };
            TypeCMB.ItemsSource = types;
        }

        private void editSup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (supplies.Id == 0)
                {
                    RealEstateAgencyEntities2.GetContext().supplies.Add(supplies);
                }
                RealEstateAgencyEntities2.GetContext().SaveChanges();
                MessageBox.Show("Все успешно");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
    }
}
