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
    /// Логика взаимодействия для HousesPage.xaml
    /// </summary>
    public partial class HousesPage : Page
    {
        public HousesPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = RealEstateAgencyEntities3.GetContext().houses.ToList();
        }
    }
}
