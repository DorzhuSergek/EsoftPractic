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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager._frame = frameMain;
            Manager._frame.Navigate(new AddDeals());
        }
        private void BackRnt_Click(object sender, RoutedEventArgs e)
        {            
             Manager._frame.GoBack();
        }

        private void frameMain_ContentRendered(object sender, EventArgs e)
        {
            if (frameMain.CanGoBack)
            {
                BackBnt.Visibility = Visibility.Visible;
            }
            else
            {
                BackBnt.Visibility = Visibility.Hidden;
            }
        }

        private void addDistricts_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Tables_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AllTablesWindow());
        }
    }
}
