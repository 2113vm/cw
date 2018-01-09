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
    public partial class SetReportForm : Form
    {
        public SetReportForm()
        {
            InitializeComponent();
        }

        private void buttonSetMeter_Click(object sender, EventArgs e)
        {
            var ServiceName = comboBoxServiceName.Text;
            var Meter = textBoxMeter.Text.ToString();
            // TODO: add meterage in database
        }
    }
}
