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
            // TODO: add meterage in database
            System.Data.SqlClient.SqlParameter paramUserId = new System.Data.SqlClient.SqlParameter("@User_Id", ApplicationContext.CurrentUser.User_Id);
            System.Data.SqlClient.SqlParameter paramServiceId = new System.Data.SqlClient.SqlParameter("@Service_Id", 1);
            System.Data.SqlClient.SqlParameter paramDate = new System.Data.SqlClient.SqlParameter("@Date", localDate);
            System.Data.SqlClient.SqlParameter paramMeter = new System.Data.SqlClient.SqlParameter("@Meterage", Meter);
            //var connection = (SqlConnection)db.Database.AsSqlServer().Connection.DbConnection
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
            }
            finally
            {
                connection.Close();
            }
            
        }
    }
}
