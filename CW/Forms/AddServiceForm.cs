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
using System.Data.Entity;

namespace CW.Forms
{
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            // check duplicate service
            // if not have duplicate then add service
            // else show message about it

            // Need to know about providerName and serviceName for check duplicate

            var ServiceName = textBoxServiceName.Text;
            var ProviderName = textBoxProviderName.Text;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ApplicationContext.ConString;

            var commandcheckDuplicateService = connection.CreateCommand();
            commandcheckDuplicateService.CommandType = CommandType.StoredProcedure;
            commandcheckDuplicateService.CommandText = "checkDuplicateService";
            commandcheckDuplicateService.Parameters.AddWithValue("@ServiceName", ServiceName);
            commandcheckDuplicateService.Parameters.AddWithValue("@ProviderName", ProviderName);

            var commandAddSerice = connection.CreateCommand();
            commandAddSerice.CommandType = CommandType.StoredProcedure;
            commandAddSerice.CommandText = "addService";
            commandAddSerice.Parameters.AddWithValue("@Price", textBoxPrice.Text);
            commandAddSerice.Parameters.AddWithValue("@ProviderName", textBoxProviderName.Text);
            commandAddSerice.Parameters.AddWithValue("@ServiceName", textBoxServiceName.Text);

            var db = new ApplicationContext();
            db.Services.Load();

            var trans = from s in db.Services
                        where s.ProviderName == textBoxProviderName.Text &&
                              s.ServiceName == textBoxServiceName.Text
                        select new
                        {
                            service_id = s.Service_Id
                        };

            if (trans.Count() == 0)
            {
                try
                {
                    connection.Open();

                    commandAddSerice.ExecuteNonQuery();
                    MessageBox.Show("Услуга успешно добавлена");
                    this.Hide();

                }
                catch
                {
                    MessageBox.Show("Не удалось добавить услугу, попробуйте позже");
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Данная услуга уже существует");
            }
        }
    }
}
