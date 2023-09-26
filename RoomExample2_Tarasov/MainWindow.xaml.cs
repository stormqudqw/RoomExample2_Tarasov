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
using RoomLibrary;

namespace RoomExample2_Tarasov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Room> lsRooms = new List<Room>();

        
        
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.RoomLenght = Convert.ToDouble(TBLenghtR.Text);
            room.RoomWidht = Convert.ToDouble(TBWidthR.Text);
            lsRooms.Add(room);
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoom livingRoom = new LivingRoom();
            livingRoom.RoomLenght = Convert.ToDouble(TBLenghtL.Text);
            livingRoom.RoomWidht = Convert.ToDouble(TBLenghtL.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumW.Text);
            lsRooms.Add(livingRoom);
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office office = new Office();
            office.RoomLenght = Convert.ToDouble(TBLenghtO.Text);
            office.RoomWidht = Convert.ToDouble(TBLenghtO.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
            lsRooms.Add(office);
        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {

            ListRooms.Content = "";
            foreach (Room r in lsRooms)
                ListRooms.Content += r.Info() + "\n";
        }
    }
}
