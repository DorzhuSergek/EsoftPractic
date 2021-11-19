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
    /// Логика взаимодействия для AddClients.xaml
    /// </summary>
    public partial class AddClients : Page
    {
        public clients clients =new clients();
        public AddClients(clients _clients)
        {
            InitializeComponent();
            if (_clients != null)
            {
                clients = _clients;
            }
            DataContext = clients;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if((Email.Text==""&&Phone.Text!="") ||(Email.Text!=""&&Phone.Text=="") || (Email.Text!="" && Phone.Text!=""))
            {
                    if (clients.Id == 0)
                    {
                        RealEstateAgencyEntities3.GetContext().clients.Add(clients);
                    }     
                    RealEstateAgencyEntities3.GetContext().SaveChanges();

                    MessageBox.Show("Все успешно");
            }
            else
            {
                MessageBox.Show("Заполните поле Email или Phone");
            }
        }
    }
}
