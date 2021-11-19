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
                    RealEstateAgencyEntities3.GetContext().districts.Add(districts);
                }
                UpdateData();

                RealEstateAgencyEntities3.GetContext().SaveChanges();
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
        private void UpdateData()
        {
            switch (CBTypes.SelectedIndex)
            {
                case 0:
                    apartments.IdDistrict = districts.Id;
                    apartments.Rooms = Convert.ToInt32(Rooms.Text);
                    apartments.Floor = Convert.ToInt32(Floors.Text);
                    apartments.Coordinate_latitude = Convert.ToInt32(Value0.Text);
                    apartments.Coordinate_longitude = Convert.ToInt32(Value.Text);
                    apartments.TotalArea = Area.Text;
                    RealEstateAgencyEntities3.GetContext().apartments.Add(apartments);
                    break;
                case 1:
                    houses.IdDistrict = districts.Id;
                    houses.TotalFloors = Convert.ToInt32(Floors.Text);
                    houses.TotalArea = Convert.ToInt32(Area.Text);
                    houses.Coordinate_latitude = Convert.ToInt32(Value0.Text);
                    houses.Coordinate_longitude = Convert.ToInt32(Value.Text);
                    RealEstateAgencyEntities3.GetContext().houses.Add(houses);
                    break;
                case 2:
                    lands.IdDistrict = districts.Id;
                    lands.TotalArea = Area.Text;
                    houses.Coordinate_latitude = Convert.ToInt32(Value0.Text);
                    houses.Coordinate_longitude = Convert.ToInt32(Value.Text);
                    RealEstateAgencyEntities3.GetContext().lands.Add(lands);
                    break;
            }

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
                    sliderLatitude.Visibility = Visibility.Visible;
                    sliderLongitude.Visibility = Visibility.Visible;
                    GDLatitude.Visibility = Visibility.Visible;
                    GDLongitude.Visibility = Visibility.Visible;
                    TBLatitude.Visibility = Visibility.Visible;
                    TBLongitude.Visibility = Visibility.Visible;
                    districts.Type = "Квартира";
                    break;
                case 1:
                    Rooms.Visibility = Visibility.Hidden;
                    TBRooms.Visibility = Visibility.Hidden;
                    Floors.Visibility = Visibility.Visible;
                    TBFloors.Visibility = Visibility.Visible;
                    Area.Visibility = Visibility.Visible;
                    TBArea.Visibility = Visibility.Visible;
                    sliderLatitude.Visibility = Visibility.Visible;
                    sliderLongitude.Visibility = Visibility.Visible;
                    GDLatitude.Visibility = Visibility.Visible;
                    GDLongitude.Visibility = Visibility.Visible;
                    TBLatitude.Visibility = Visibility.Visible;
                    TBLongitude.Visibility = Visibility.Visible;
                    districts.Type = "Дом";
                    break;
                case 2:
                    Rooms.Visibility = Visibility.Hidden;
                    TBRooms.Visibility = Visibility.Hidden;
                    Floors.Visibility = Visibility.Hidden;
                    TBFloors.Visibility = Visibility.Hidden;
                    Area.Visibility = Visibility.Visible;
                    TBArea.Visibility = Visibility.Visible;
                    sliderLatitude.Visibility = Visibility.Visible;
                    sliderLongitude.Visibility = Visibility.Visible;
                    GDLatitude.Visibility = Visibility.Visible;
                    GDLongitude.Visibility = Visibility.Visible;
                    TBLatitude.Visibility = Visibility.Visible;
                    TBLongitude.Visibility = Visibility.Visible;
                    districts.Type = "Земля";
                    break;
            }
        }

        private void Floors_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Rooms_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void sliderLatitude_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void sliderLongitude_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
