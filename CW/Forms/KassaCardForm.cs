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
    public partial class KassaCardForm : Form
    {
        public KassaCardForm()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var AddClientForm = new Forms.AddClientForm();
            AddClientForm.Show();

        }

        private void buttonAddPayments_Click(object sender, EventArgs e)
        {
            var AddPaymentsForm = new Forms.AddPaymentsForm();
            AddPaymentsForm.Show();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            var AddServiceForm = new Forms.AddServiceForm();
            AddServiceForm.Show();
        }
    }
}
