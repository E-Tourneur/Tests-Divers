using CommandSequencer.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandSequencer
{
    public partial class FrmMain : Form
    {
        MainController _ctrl;

        public FrmMain()
        {
            InitializeComponent();
            this.iptbIP.Text = "127.0.0.1";
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _ctrl = new MainController();
            _ctrl.IPAdress = this.iptbIP.Text;
            _ctrl.Port = Convert.ToInt32(txtPort.Text);
            _ctrl.Connect();
        }
    }
}
