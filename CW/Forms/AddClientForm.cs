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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
            var db = new ApplicationContext();
            var coldProvider = from s in db.Services
                               where s.ServiceName == "Холодная вода"
                               select new
                               {
                                   cold = s.ProviderName
                               };
            var hotProvider = from s in db.Services
                              where s.ServiceName == "Горячая вода"
                              select new
                              {
                                  hot = s.ProviderName
                              };
            var gasProvider = from s in db.Services
                              where s.ServiceName == "Газ"
                              select new
                              {
                                  gas = s.ProviderName
                              };
            var electProvider = from s in db.Services
                                where s.ServiceName == "Электричество"
                                select new
                                {
                                    elect = s.ProviderName
                                };

            foreach (var t in coldProvider)
            {
                string[] row = { t.cold };
                comboBoxColdProvider.Items.Add(t.cold);
            }
            foreach (var t in hotProvider)
            {
                string[] row = { t.hot };
                comboBoxHotProvider.Items.Add(t.hot);
            }
            foreach (var t in gasProvider)
            {
                string[] row = { t.gas };
                comboBoxGasProvider.Items.Add(t.gas);
            }
            foreach (var t in electProvider)
            {
                string[] row = { t.elect };
                comboBoxElectProvider.Items.Add(t.elect);
            }

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

            var db = new ApplicationContext();
            // check duplicate user
            // if not have duplicate then add user
            // else show message about it

            // Need check duplicate user
            // if user is new then set his service and first meterage
            var FirstName = textBoxFirstName.Text;
            var SecondName = textBoxSecondName.Text;
            var ThirdName = textBoxThirdName.Text;
            var Address = textBoxAddress.Text;
            var Tenants = textBoxTenants.Text;
            var Area = textBoxArea.Text;
            var Passport = textBoxPassport.Text;
            var Login = textBoxCreateLogin.Text;
            var Password = textBoxCreatePassword.Text;

            var ColdProviderName = comboBoxColdProvider.Text;
            var HotProviderName = comboBoxHotProvider.Text;
            var GasProviderName = comboBoxGasProvider.Text;
            var ElectProviderName = comboBoxElectProvider.Text;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ApplicationContext.ConString;

            var commandGetHotServiceId = connection.CreateCommand();
            commandGetHotServiceId.CommandType = CommandType.StoredProcedure;
            commandGetHotServiceId.CommandText = "findServiceId";
            commandGetHotServiceId.Parameters.AddWithValue("@ServiceName", "Горячая вода");
            commandGetHotServiceId.Parameters.AddWithValue("@ProviderName", HotProviderName);

            var commandGetColdServiceId = connection.CreateCommand();
            commandGetColdServiceId.CommandType = CommandType.StoredProcedure;
            commandGetColdServiceId.CommandText = "findServiceId";
            commandGetColdServiceId.Parameters.AddWithValue("@ServiceName", "Холодная вода");
            commandGetColdServiceId.Parameters.AddWithValue("@ProviderName", ColdProviderName);

            var commandGetGasServiceId = connection.CreateCommand();
            commandGetGasServiceId.CommandType = CommandType.StoredProcedure;
            commandGetGasServiceId.CommandText = "findServiceId";
            commandGetGasServiceId.Parameters.AddWithValue("@ServiceName", "Газ");
            commandGetGasServiceId.Parameters.AddWithValue("@ProviderName", GasProviderName);

            var commandGetElectServiceId = connection.CreateCommand();
            commandGetElectServiceId.CommandType = CommandType.StoredProcedure;
            commandGetElectServiceId.CommandText = "findServiceId";
            commandGetElectServiceId.Parameters.AddWithValue("@ServiceName", "Электричество");
            commandGetElectServiceId.Parameters.AddWithValue("@ProviderName", ElectProviderName);

            DateTime localDate = DateTime.Now;

            var commandAddUser = connection.CreateCommand();
            commandAddUser.CommandType = CommandType.StoredProcedure;
            commandAddUser.CommandText = "addUser";
            commandAddUser.Parameters.AddWithValue("@FirstName", FirstName);
            commandAddUser.Parameters.AddWithValue("@SecondName", SecondName);
            commandAddUser.Parameters.AddWithValue("@ThirdName", ThirdName);
            commandAddUser.Parameters.AddWithValue("@Address", Address);
            commandAddUser.Parameters.AddWithValue("@Tenants", Tenants);
            commandAddUser.Parameters.AddWithValue("@Passport", Passport);
            commandAddUser.Parameters.AddWithValue("@Login", Login);
            commandAddUser.Parameters.AddWithValue("@Password", Password);
            commandAddUser.Parameters.AddWithValue("@Area", Area);
            commandAddUser.Parameters.AddWithValue("@DateRegistration", localDate);


            var trans = from u in db.Users
                        where u.Address == Address
                        && u.FirstName == FirstName
                        && u.LastName == SecondName
                        && u.ThirdName == ThirdName
                        && u.Passport.ToString() == Passport
                        select new
                        {
                            user_id = u.User_Id
                        };

            if (trans.Count() != 0)
            {
                MessageBox.Show("Указанный пользователь существует, проверьте введенные данные");
            }
            else
            {
                try
                {
                    connection.Open();

                    var HotServiceId = commandGetHotServiceId.ExecuteScalar().ToString();
                    var ColdServiceId = commandGetColdServiceId.ExecuteScalar().ToString();
                    var GasServiceId = commandGetGasServiceId.ExecuteScalar().ToString();
                    var ElectServiceId = commandGetElectServiceId.ExecuteScalar().ToString();

                    commandAddUser.ExecuteNonQuery();

                    var user_idList = from u in db.Users
                                where u.Address == Address
                                && u.FirstName == FirstName
                                && u.LastName == SecondName
                                && u.ThirdName == ThirdName
                                && u.Passport.ToString() == Passport
                                select new
                                {
                                    user_id = u.User_Id
                                };

                    int user_id = user_idList.First().user_id;

                    MessageBox.Show(user_id.ToString());
                    MessageBox.Show(HotServiceId.ToString());
                    MessageBox.Show(ColdServiceId.ToString());
                    MessageBox.Show(GasServiceId.ToString());
                    MessageBox.Show(ElectServiceId.ToString());

                    var commandAddContracts = connection.CreateCommand();
                    commandAddContracts.CommandType = CommandType.StoredProcedure;
                    commandAddContracts.CommandText = "addContracts";
                    commandAddContracts.Parameters.AddWithValue("@User_Id", user_id);
                    commandAddContracts.Parameters.AddWithValue("@HotServiceId", HotServiceId);
                    commandAddContracts.Parameters.AddWithValue("@ColdServiceId", ColdServiceId);
                    commandAddContracts.Parameters.AddWithValue("@GasServiceId", GasServiceId);
                    commandAddContracts.Parameters.AddWithValue("@ElectServiceId", ElectServiceId);
                    
                    commandAddContracts.ExecuteNonQuery();
                    

                    var commandAddHotMeter = connection.CreateCommand();
                    commandAddHotMeter.CommandType = CommandType.StoredProcedure;
                    commandAddHotMeter.CommandText = "addMeter";
                    commandAddHotMeter.Parameters.AddWithValue("@User_Id", user_id);
                    commandAddHotMeter.Parameters.AddWithValue("@Service_Id", HotServiceId);
                    commandAddHotMeter.Parameters.AddWithValue("@Date", localDate);
                    commandAddHotMeter.Parameters.AddWithValue("@Meterage", 0);

                    var commandAddColdMeter = connection.CreateCommand();
                    commandAddColdMeter.CommandType = CommandType.StoredProcedure;
                    commandAddColdMeter.CommandText = "addMeter";
                    commandAddColdMeter.Parameters.AddWithValue("@User_Id", user_id);
                    commandAddColdMeter.Parameters.AddWithValue("@Service_Id", HotServiceId);
                    commandAddColdMeter.Parameters.AddWithValue("@Date", localDate);
                    commandAddColdMeter.Parameters.AddWithValue("@Meterage", 0);

                    var commandAddGasMeter = connection.CreateCommand();
                    commandAddGasMeter.CommandType = CommandType.StoredProcedure;
                    commandAddGasMeter.CommandText = "addMeter";
                    commandAddGasMeter.Parameters.AddWithValue("@User_Id", user_id);
                    commandAddGasMeter.Parameters.AddWithValue("@Service_Id", HotServiceId);
                    commandAddGasMeter.Parameters.AddWithValue("@Date", localDate);
                    commandAddGasMeter.Parameters.AddWithValue("@Meterage", 0);

                    var commandAddElectMeter = connection.CreateCommand();
                    commandAddElectMeter.CommandType = CommandType.StoredProcedure;
                    commandAddElectMeter.CommandText = "addMeter";
                    commandAddElectMeter.Parameters.AddWithValue("@User_Id", user_id);
                    commandAddElectMeter.Parameters.AddWithValue("@Service_Id", ElectServiceId);
                    commandAddElectMeter.Parameters.AddWithValue("@Date", localDate);
                    commandAddElectMeter.Parameters.AddWithValue("@Meterage", 0);

                    commandAddColdMeter.ExecuteNonQuery();
                    commandAddHotMeter.ExecuteNonQuery();
                    commandAddGasMeter.ExecuteNonQuery();
                    commandAddElectMeter.ExecuteNonQuery();


                    // Now need check duplicate user and if he is new then add him
                    // Next step it get user_id this user
                    // And in the end need add rows in table contracts User_Id - Service_Id
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Не удалось добавить пользователя, повторите попытку позже");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
