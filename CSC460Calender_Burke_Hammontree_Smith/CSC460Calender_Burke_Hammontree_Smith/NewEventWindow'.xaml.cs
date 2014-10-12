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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace CSC460Calender_Burke_Hammontree_Smith
{
    /// <summary>
    /// Interaction logic for NewEventWindow_.xaml
    /// </summary>
    public partial class NewEventWindow : Window
    {
        public NewEventWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection db = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Kenneth\Documents\VisualStudio2013Projects\csc460calendarprogram\csc460calendarprogram\CSC460Calender_Burke_Hammontree_Smith\CSC460Calender_Burke_Hammontree_Smith\bin\Debug\CalendarDB.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");

            
        }

    }
}
