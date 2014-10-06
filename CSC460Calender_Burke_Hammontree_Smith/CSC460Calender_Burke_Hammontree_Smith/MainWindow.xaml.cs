// By Kenneth Smith 
// Ryan Hammontree
// Steven Burke

using System;
using Xceed.Wpf.Toolkit;
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

namespace CSC460Calender_Burke_Hammontree_Smith
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calender_Initialized(object sender, EventArgs e)
        {
            //On calendar initialization set SelectedDate to currentDate
            calMain.SelectedDate = DateTime.Today;
        }
        private void calMain_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime curDate = (DateTime)calMain.SelectedDate;
            curDate.ToShortDateString();
            lblDateHolder.Content = curDate;
        }

        private void btnNewEvent_Click(object sender, RoutedEventArgs e)
        {
            NewEventWindow addEvent = new NewEventWindow();

            addEvent.Show();
        }
  
    }

    public class Event
    {
        String name;
        DateTime date;
        String details;

        public Event()
        {
            name = " ";
            date = DateTime.Now;
            details = " ";
        }
    }
}
