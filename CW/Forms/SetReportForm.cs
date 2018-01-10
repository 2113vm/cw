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
            commandGetLastMeter.Parameters.AddWithValue("@User_Id", ApplicationContext.CurrentUser.User_Id);
            commandGetLastMeter.Parameters.AddWithValue("@Service_Id", service_id);

            var commandAddPaymentMeter = connection.CreateCommand();
            commandAddPaymentMeter.CommandType = CommandType.StoredProcedure;
            commandAddPaymentMeter.CommandText = "addPaymentMeter";
            commandAddPaymentMeter.Parameters.AddWithValue("@User_Id", ApplicationContext.CurrentUser.User_Id);
            commandAddPaymentMeter.Parameters.AddWithValue("@Service_Id", service_id);
            commandAddPaymentMeter.Parameters.AddWithValue("@Date", localDate);

            try
            {
                connection.Open();

                int lastMeter = commandGetLastMeter.ExecuteNonQuery();
                int diff = Math.Abs(lastMeter - Convert.ToInt32(Meter));
                commandAddPaymentMeter.Parameters.AddWithValue("@diff", diff);
                commandAddPaymentMeter.ExecuteNonQuery();

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
                this.Hide();
            }
            
        }
    }
}
