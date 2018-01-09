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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            dataGridViewData.ColumnCount = 2;
            dataGridViewData.Columns[0].Name = "Размер платежа";
            dataGridViewData.Columns[1].Name = "Дата внесения платежа";
        }

        public string getBalance(string ServiceName, int Id, DateTime date)
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
                           && p.Date < date
                        select (p.Amount);
            if (trans.Count() == 0)
            {
                return "0";
            }
            else {
                return trans.Sum().ToString();
            }
        }

        private void buttonGetReport_Click(object sender, EventArgs e)
        {
            var serviceName = comboBoxServices.Text;
            var startDate = dateTimePickerStart.Value;
            var endDate = dateTimePickerEnd.Value;
            labelBalance.Text = "Баланс на начало периода: " + 
                getBalance(serviceName, ApplicationContext.CurrentUser.User_Id, startDate);
            labelBalanceEnd.Text = "Баланс на конец периода: " +
                getBalance(serviceName, ApplicationContext.CurrentUser.User_Id, endDate);
            labelProviderName.Text = "";

            dataGridViewData.Rows.Clear();

            var db = new ApplicationContext();

            var trans = from u in db.Users
                        from s in db.Services
                        from c in db.Contracts
                        from p in db.Payments
                        where u.User_Id == ApplicationContext.CurrentUser.User_Id
                           && s.ServiceName == serviceName
                           && s.Service_Id == c.Service_Id
                           && u.User_Id == c.User_Id
                           && c.User_Id == p.User_Id
                           && c.Service_Id == p.Service_Id
                           && p.Date >= startDate
                           && p.Date <= endDate
                        select new {
                            p.Amount,
                            p.Date
                        };

            var transList = trans.ToList();

            foreach (var t in transList)
            {
                string[] row = { t.Amount.ToString(), t.Date.ToString() };
                dataGridViewData.Rows.Add(row);
            }

        }
    }
}
