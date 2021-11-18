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
    /// Логика взаимодействия для SuplicePage.xaml
    /// </summary>
    public partial class SuplicePage : Page
    {
        public SuplicePage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = RealEstateAgencyEntities2.GetContext().supplies.ToList();
        }

        private void addSup_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddSupplice(null));
        }

        private void EditSup_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddSupplice(DataGrid.SelectedItem as supplies));
        }

        private void DelSup_Click(object sender, RoutedEventArgs e)
        {
            var suppliceForRemoving = DataGrid.SelectedItems.Cast<supplies>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {suppliceForRemoving.Count()} элементов? ", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RealEstateAgencyEntities2.GetContext().supplies.RemoveRange(suppliceForRemoving);
                    RealEstateAgencyEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DataGrid.ItemsSource = RealEstateAgencyEntities2.GetContext().supplies.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
