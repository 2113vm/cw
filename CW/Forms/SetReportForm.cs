using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CW.Forms
{
    public partial class SetReportForm : Form
    {
        public SetReportForm()
        {
            InitializeComponent();
        }

        private void buttonSetMeter_Click(object sender, EventArgs e)
        {
            var db = new ApplicationContext();
            var ServiceName = comboBoxServiceName.Text;
            var Meter = textBoxMeter.Text.ToString();
            DateTime localDate = DateTime.Now;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ApplicationContext.ConString;

            var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "addMeter";
            command.Parameters.AddWithValue("@User_Id", ApplicationContext.CurrentUser.User_Id);
            command.Parameters.AddWithValue("@Service_Id", 1);
            command.Parameters.AddWithValue("@Date", localDate);
            command.Parameters.AddWithValue("@Meterage", Meter);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Показания счетчика добавлены в базу данных");
            }
            catch
            {
                MessageBox.Show("Не удалось внести данные в базу данных, попробуйте позже");
            }
            finally
            {
                connection.Close();
            }
            
        }
    }
}
