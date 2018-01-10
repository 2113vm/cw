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
            var service_id = ApplicationContext.dict_services[ServiceName];
            DateTime localDate = DateTime.Now;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ApplicationContext.ConString;

            var commandAddMeter = connection.CreateCommand();
            commandAddMeter.CommandType = CommandType.StoredProcedure;
            commandAddMeter.CommandText = "addMeter";
            commandAddMeter.Parameters.AddWithValue("@User_Id", ApplicationContext.CurrentUser.User_Id);
            commandAddMeter.Parameters.AddWithValue("@Service_Id", service_id);
            commandAddMeter.Parameters.AddWithValue("@Date", localDate);
            commandAddMeter.Parameters.AddWithValue("@Meterage", Meter);

            var commandGetLastMeter = connection.CreateCommand();
            commandGetLastMeter.CommandType = CommandType.StoredProcedure;
            commandGetLastMeter.CommandText = "getLastMeterage";

            try
            {
                connection.Open();
                commandAddMeter.ExecuteNonQuery();
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
