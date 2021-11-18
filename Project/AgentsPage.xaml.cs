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
    /// Логика взаимодействия для AgentsPage.xaml
    /// </summary>
    public partial class AgentsPage : Page
    {
        public AgentsPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = RealEstateAgencyEntities2.GetContext().agents.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                RealEstateAgencyEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGrid.ItemsSource = RealEstateAgencyEntities2.GetContext().agents.ToList();
            }
        }

        private void AddAgent_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddRieltor(null));
        }

        private void EditAgent_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddRieltor(DataGrid.SelectedItem as agents));
        }

        private void DelecteAgent_Click(object sender, RoutedEventArgs e)
        {
            var agentsForRemoving = DataGrid.SelectedItems.Cast<agents>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {agentsForRemoving.Count()} элементов? ", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RealEstateAgencyEntities2.GetContext().agents.RemoveRange(agentsForRemoving);
                    RealEstateAgencyEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DataGrid.ItemsSource = RealEstateAgencyEntities2.GetContext().agents.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
