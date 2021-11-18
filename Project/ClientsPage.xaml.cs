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
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = RealEstateAgencyEntities2.GetContext().clients.ToList();
            UpdateClients();

        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddClients(null));


        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                RealEstateAgencyEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGrid.ItemsSource = RealEstateAgencyEntities2.GetContext().clients.ToList();
            }
        }

        private void EditClient_Click(object sender, RoutedEventArgs e)
        {

            Manager._frame.Navigate(new AddClients(DataGrid.SelectedItem as clients));
        }

        private void DelecteClient_Click(object sender, RoutedEventArgs e)
        {
            var clientsForRemoving = DataGrid.SelectedItems.Cast<clients>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {clientsForRemoving.Count()} элементов? ", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RealEstateAgencyEntities2.GetContext().clients.RemoveRange(clientsForRemoving);
                    RealEstateAgencyEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DataGrid.ItemsSource = RealEstateAgencyEntities2.GetContext().clients.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //MessageBox.Show(LevenshteinDistance("Сергек", "Алексей").ToString());
            UpdateClients();

        }

     
        public void UpdateClients()
        {
            var currentClients = RealEstateAgencyEntities2.GetContext().clients.ToList();
            currentClients = currentClients.Where(p => p.FirstName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
        }
       
        //static int LevenshteinDistance(string firstWord, string secondWord)
        //{
        //    var n = firstWord.Length + 1;
        //    var m = secondWord.Length + 1;
        //    var matrixD = new int[n, m];
        //    const int deletionCost = 1;
        //    const int insertionCost = 1;

        //    for (var i = 0; i < n; i++)
        //    {
        //        matrixD[i, 0] = i;
        //    }

        //    for (var j = 0; j < m; j++)
        //    {
        //        matrixD[0, j] = j;
        //    }

        //    for (var i = 1; i < n; i++)
        //    {
        //        for (var j = 1; j < m; j++)
        //        {
        //            var substitutionCost = firstWord[i - 1] == secondWord[j - 1] ? 0 : 1;

        //            matrixD[i, j] = Minimum(matrixD[i - 1, j] + deletionCost,          // удаление
        //                                    matrixD[i, j - 1] + insertionCost,         // вставка
        //                                    matrixD[i - 1, j - 1] + substitutionCost); // замена
        //        }
        //    }

        //    return matrixD[n - 1, m - 1];
        //}
        //static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
    }
    
}
