using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    public partial class LoginForm : Form
    {
        public LoginForm loginForm;

        public LoginForm()
        {
            InitializeComponent();
            loginForm = this;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Roles.Load();
                db.Users.Load();
                db.Services.Load();

                var user = db.Users.FirstOrDefault(u => u.Login == textBoxLogin.Text && u.Password == textBoxPass.Text);

                switch (user.Role.RoleName)
                {
                    case "client":
                        var services = from s in db.Services
                                       from c in db.Contracts
                                       where s.Service_Id == c.Service_Id && c.User_Id == user.User_Id
                                       select new
                                       {
                                           Service_Id = s.Service_Id,
                                           ServiceName = s.ServiceName
                                       };

                        foreach (var s in services)
                        {
                            ApplicationContext.dict_services.Add(s.ServiceName, s.Service_Id);
                        }
                        ApplicationContext.CurrentUser = user;
                        var Clientform = new Forms.ClientCardForm();
                        Clientform.Show();
                        break;
                    case "kassa":
                        ApplicationContext.CurrentUser = user;
                        var Kassaform = new Forms.KassaCardForm();
                        Kassaform.Show();
                        break;
                        
                }
            }
        }
    }
}
