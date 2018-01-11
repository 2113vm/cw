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
    public partial class AddPaymentsForm : Form
    {
        public AddPaymentsForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAddPayment_Click(object sender, EventArgs e)
        {
            var db = new ApplicationContext();

            DateTime Date = DateTime.Now;
            var Amount = textBoxPayment.Text;

            var trans = from u in db.Users
                        where u.Address == textBoxAddress.Text &&
                              u.FirstName == textBoxFirstName.Text &&
                              u.LastName == textBoxSecondName.Text &&
                              u.ThirdName == textBoxThirdName.Text &&
                              u.Passport.ToString() == textBoxPassport.Text
                        select new
                        {
                            user_id = u.User_Id
                        };

            if (trans.Count() == 0)
            {
                MessageBox.Show("Пользователь не найден");
            }
            else
            {

                int user_id = trans.First().user_id;

                var service = from s in db.Services
                              from c in db.Contracts
                              where s.Service_Id == c.Service_Id &&
                                    s.ServiceName == comboBoxServices.Text &&
                                    c.User_Id == (int)user_id
                              select new
                              {
                                  service_id = s.Service_Id
                              };

                int service_id = service.First().service_id;

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ApplicationContext.ConString;

                var commandAddPayment = connection.CreateCommand();
                commandAddPayment.CommandType = CommandType.StoredProcedure;
                commandAddPayment.CommandText = "AddPayment";
                commandAddPayment.Parameters.AddWithValue("@User_Id", user_id);
                commandAddPayment.Parameters.AddWithValue("@Service_Id", service_id);
                commandAddPayment.Parameters.AddWithValue("@Date", Date);
                commandAddPayment.Parameters.AddWithValue("@Amount", Amount);


                try
                {
                    connection.Open();

                    commandAddPayment.ExecuteNonQuery();
                    MessageBox.Show("Платеж успешно добавлен");
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Не удалось добавить платеж, повторите попытку позже");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
