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

                var user = db.Users.FirstOrDefault(u => u.Login == textBoxLogin.Text && u.Password == textBoxPass.Text);

                switch (user.Role.RoleName)
                {
                    case "Client":
                        ApplicationContext.CurrentUser = user;
                        break;
                    case "Admin":
                        break;
                        
                }
            }
        }
    }
}
