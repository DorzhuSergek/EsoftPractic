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
    /// Логика взаимодействия для AddDistrict.xaml
    /// </summary>
    public partial class AddDistrict : Page
    {

        public districts districts = new districts();
        public apartments apartments = new apartments();
        public lands lands = new lands();
        public houses houses = new houses();
        public AddDistrict(districts _districts)
        {
            InitializeComponent();
            List<string> types = new List<string>();
            types.Add("Квартира");
            types.Add("Дом");
            types.Add("Земля");
            CBTypes.ItemsSource = types;
            if (_districts != null)
            {
                districts = _districts;
            }
            DataContext = districts;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (districts.Id == 0)
                {
                    if(CBTypes.SelectedItem == null)
                    {
                        MessageBox.Show("Выберите тип");
                        return;
                    }
                    RealEstateAgencyEntities2.GetContext().districts.Add(districts);
                    RealEstateAgencyEntities2.GetContext().apartments.Add(apartments);
                }
                RealEstateAgencyEntities2.GetContext().SaveChanges();

                MessageBox.Show("Все успешно");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
         
        }

        private void Number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void CBTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CBTypes.SelectedIndex)
            {
                case 0:
                    Rooms.Visibility = Visibility.Visible;
                    TBRooms.Visibility = Visibility.Visible;
                    Floors.Visibility = Visibility.Visible;
                    TBFloors.Visibility = Visibility.Visible;
                    Area.Visibility = Visibility.Visible;
                    TBArea.Visibility = Visibility.Visible;
                    districts.Type = "Квартира";
                    break;
                case 1:
                    Rooms.Visibility = Visibility.Visible;
                    TBRooms.Visibility = Visibility.Visible;
                    Floors.Visibility = Visibility.Visible;
                    TBFloors.Visibility = Visibility.Visible;
                    Area.Visibility = Visibility.Visible;
                    TBArea.Visibility = Visibility.Visible;
                    districts.Type = "Дом";
                    break;
                case 2:
                    Rooms.Visibility = Visibility.Hidden;
                    TBRooms.Visibility = Visibility.Hidden;
                    Floors.Visibility = Visibility.Hidden;
                    TBFloors.Visibility = Visibility.Hidden;
                    Area.Visibility = Visibility.Visible;
                    TBArea.Visibility = Visibility.Visible;
                    districts.Type = "Земля";
                    break;
            }
        }
    }
}
