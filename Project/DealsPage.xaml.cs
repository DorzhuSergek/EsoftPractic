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
    /// Логика взаимодействия для DealsPage.xaml
    /// </summary>
    public partial class DealsPage : Page
    {
        public DealsPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = RealEstateAgencyEntities3.GetContext().deals.ToList();
        }

        private void AddDeal_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddDeals(null));
        }

        private void Editdeal_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddDeals(DataGrid.SelectedItem as deals));
        }

        private void DelecteDeal_Click(object sender, RoutedEventArgs e)
        {
            var dealsForRemoving = DataGrid.SelectedItems.Cast<deals>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {dealsForRemoving.Count()} элементов? ", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RealEstateAgencyEntities3.GetContext().deals.RemoveRange(dealsForRemoving);
                    RealEstateAgencyEntities3.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DataGrid.ItemsSource = RealEstateAgencyEntities3.GetContext().deals.ToList();

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
                DataGrid.ItemsSource = RealEstateAgencyEntities3.GetContext().deals.ToList();
            }
        }
    }
}
