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
    /// Логика взаимодействия для DemadsPage.xaml
    /// </summary>
    public partial class DemadsPage : Page
    {
        public DemadsPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = RealEstateAgencyEntities3.GetContext().Demands.ToList();
        }

        private void AddDemands_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddDemands(null));
        }

        private void EditDemands_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddDemands(DataGrid.SelectedItem as Demands));
        }

        private void DelecteDemands_Click(object sender, RoutedEventArgs e)
        {
            var removeDemands = DataGrid.SelectedItems.Cast<Demands>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {removeDemands.Count()} элементов? ", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RealEstateAgencyEntities3.GetContext().Demands.RemoveRange(removeDemands);
                    RealEstateAgencyEntities3.GetContext().SaveChanges();
                    DataGrid.ItemsSource = RealEstateAgencyEntities3.GetContext().Demands.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                RealEstateAgencyEntities3.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGrid.ItemsSource = RealEstateAgencyEntities3.GetContext().Demands.ToList();
            }
        }
    }
}
