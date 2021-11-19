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
            StringBuilder stringBuilder = new StringBuilder();
            if (string.IsNullOrWhiteSpace(agents.FirstName))
                stringBuilder.AppendLine("Поле 'Фамилия' обязательно для заполнения");
            if (string.IsNullOrWhiteSpace(agents.MiddleName))
                stringBuilder.AppendLine("Поле 'Имя' обязательно обязательно для заполнения");
            if (string.IsNullOrWhiteSpace(agents.LastName))
                stringBuilder.AppendLine("Поле 'Отчество' обязательно обязательно для заполнения");
            if (stringBuilder.Length > 0)
            {
                MessageBox.Show(stringBuilder.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            if (Phone.Text != "")
            {
                if (agents.Id == 0)
                {
                    RealEstateAgencyEntities3.GetContext().agents.Add(agents);
                }
                RealEstateAgencyEntities3.GetContext().SaveChanges();

                MessageBox.Show("Все успешно");
            }
            else
            {
                MessageBox.Show("Заполните поле Phone");
            }
        }
    }
}
