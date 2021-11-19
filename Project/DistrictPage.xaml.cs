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
    /// Логика взаимодействия для DistrictPage.xaml
    /// </summary>
    public partial class DistrictPage : Page
    {
        public DistrictPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = RealEstateAgencyEntities3.GetContext().districts.ToList();
        }

        private void AddDistrict_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddDistrict(null));
        }

        private void EditDistrict_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddDistrict(DataGrid.SelectedItem as districts));
        }

        private void DelecteDistrict_Click(object sender, RoutedEventArgs e)
        {
            var removeDistricts = DataGrid.SelectedItems.Cast<districts>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {removeDistricts.Count()} элементов? ", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {   RealEstateAgencyEntities3.GetContext().districts.RemoveRange(removeDistricts);
                    RealEstateAgencyEntities3.GetContext().SaveChanges();
                    DataGrid.ItemsSource = RealEstateAgencyEntities3.GetContext().districts.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
