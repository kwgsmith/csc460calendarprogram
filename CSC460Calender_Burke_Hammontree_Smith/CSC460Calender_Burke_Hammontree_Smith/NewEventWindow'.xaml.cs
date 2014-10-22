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
            try
            {
                String conString = Properties.Settings.Default.CalendarDBConnectionString;
                Console.Out.Write(conString);

                SqlCommand cmd = new SqlCommand("CREATE  TABLE IF NOT EXISTS [dbo].[EventTest](" +
                        "[Id] INT NOT NULL PRIMARY KEY IDENTITY," +
                        "[EventName] VARCHAR(50) NOT NULL,"  +
                        "[StartDate] DATE NOT NULL," + 
                        "[EndDate] DATE NOT NULL," +
                        "[StartTime] DATETIME NOT NULL," +
                        "[EndTime] DATETIME NOT NULL," +
                        "[Details] VARCHAR(MAX) NULL);", new SqlConnection(conString));

                SqlCommand insert = new SqlCommand("INSERT INTO Event (EventName, StartDate, EndDate, StartTime, EndTime, Details)" +
                                                   "VALUES (" + tboxTitle.Text + ", " + dtpStartDatePicker.SelectedDate + ", " + dtpEndDatePicker.SelectedDate + ", "
                                                   + dtpStartTimePicker.Value + ", " + dtpEndTimePicker.Value + ", " + tboxDetails.Text + ");");
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                    
            }
            catch(SqlException ex)
            { Console.Out.Write(ex.Message); }
            
        }

    }
}
