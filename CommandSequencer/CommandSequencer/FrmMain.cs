using CommandSequencer.Controllers;
using CommandSequencer.Helpers.Misc;
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
        ConsoleWriter _redirectWriter;

        public FrmMain()
        {
            InitializeComponent();

            this.iptbIP.Text = "127.0.0.1";
            //On instancie un MainController.
            _ctrl = new MainController();
            //On s'abonne à l'event "ConnectionChanged" de facon à adapter l'acces aux boutons.
            _ctrl.ConnectionChanged += _ctrl_ConnectionChanged;
            //On est pas connect, donc on desactive l'accès.
            pnlControl.Enabled = false;

            //Creation d'un objet ConsoleWriter, avec celui-ci, nous allons rediriger les Console.WriteLine dans la rtb adequate.
            _redirectWriter = new ConsoleWriter();
            _redirectWriter.WriteLineEvent += _redirectWriter_WriteLineEvent;
            Console.SetOut(_redirectWriter);

        }

        /// <summary>
        /// Event WriteLine de notre objet de redirection. On va afficher la string saisie dans la rtb de réponse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _redirectWriter_WriteLineEvent(object sender, Helpers.CustomsEvents.ConsoleWriterEventArgs e)
        {
            if(rtbResponse.InvokeRequired)
            {
                rtbResponse.Invoke(new Action(() => { rtbResponse.AppendText(e.Value); }));
            }
            else
            {
                rtbResponse.AppendText(e.Value);
            }          
        }

        /// <summary>
        /// Event "ConnectionChanged" du controller, on va adapter l'accès aux bontons en fonction du resultat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ctrl_ConnectionChanged(object sender, Helpers.CustomsEvents.ConnectionChangedEventArgs e)
        {
            if(e.State == Helpers.CustomsEvents.ConnectionStateEnum.Connected)
            {
                pnlControl.Enabled = true;
            } else if(e.State == Helpers.CustomsEvents.ConnectionStateEnum.Disconnected)
            {
                pnlControl.Enabled = false;
            }
        }

        /// <summary>
        /// Event Keypress de la textbox qui contient le port.
        /// On va rendre possible la saisie que de chiffre via cet event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Event click du bouton connect.
        /// On set les informations saisies et on se connect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            _ctrl.IPAdress = this.iptbIP.Text;
            _ctrl.Port = Convert.ToInt32(txtPort.Text);
            _ctrl.Connect();

        }
    }
}
