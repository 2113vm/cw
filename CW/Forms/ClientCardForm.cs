using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW.Forms
{
    public partial class ClientCardForm : Form
    {
        public string getBalance(string ServiceName, int Id)
        {
            var db = new ApplicationContext();
            var trans = from u in db.Users
                        from s in db.Services
                        from c in db.Contracts
                        from p in db.Payments
                        where u.User_Id == Id
                           && s.ServiceName == ServiceName
                           && s.Service_Id == c.Service_Id
                           && u.User_Id == c.User_Id
                           && c.User_Id == p.User_Id
                           && c.Service_Id == p.Service_Id
                        select (p.Amount);
            if (trans.Count() == 0)
            {
                return "0";
            }
            else
            {
                return trans.Sum().ToString();
            }
        }

        public ClientCardForm()
        {
            InitializeComponent();
            labelName.Text = ApplicationContext.CurrentUser.LastName + " "
                + ApplicationContext.CurrentUser.FirstName + " "
                + ApplicationContext.CurrentUser.ThirdName;
            labelAddress.Text = ApplicationContext.CurrentUser.Address;
            labelHotWater.Text = getBalance("Горячая вода", ApplicationContext.CurrentUser.User_Id);
            labelColdWater.Text = getBalance("Холодная вода", ApplicationContext.CurrentUser.User_Id);
            labelElect.Text = getBalance("Электричество", ApplicationContext.CurrentUser.User_Id);
            labelGas.Text = getBalance("Газ", ApplicationContext.CurrentUser.User_Id);


        }

        private void buttonGetReport_Click(object sender, EventArgs e)
        {
            var form = new Forms.ReportForm();
            form.Show();
        }

        private void buttonSetReport_Click(object sender, EventArgs e)
        {
            var form = new Forms.SetReportForm();
            form.Show();
        }
    }
}
