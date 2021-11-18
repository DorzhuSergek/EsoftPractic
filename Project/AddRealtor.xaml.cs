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
    /// Логика взаимодействия для AddRieltor.xaml
    /// </summary>
    public partial class AddRieltor : Page
    {
        public agents agents = new agents();
        public AddRieltor(agents _agents)
        {
            InitializeComponent();
            if (_agents != null)
            {
                agents = _agents;
            }
            DataContext = agents;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Phone.Text != "")
            {
                if (agents.Id == 0)
                {
                    RealEstateAgencyEntities2.GetContext().agents.Add(agents);
                }
                RealEstateAgencyEntities2.GetContext().SaveChanges();

                MessageBox.Show("Все успешно");
            }
            else
            {
                MessageBox.Show("Заполните поле Phone");
            }
        }
    }
}
