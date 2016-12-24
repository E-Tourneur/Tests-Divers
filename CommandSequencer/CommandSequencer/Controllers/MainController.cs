using CommandSequencer.Helpers.CustomsEvents;
using CommandSequencer.Helpers.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandSequencer.Controllers
{
    /// <summary>
    /// FR: Controleur principal. C'est via cette classe que notre FrmMain va interagir, tout le code intelligent se situe donc
    /// dans celle-ci.
    /// 
    /// EN: Main Controller. It is by this class that our FrmMain will interact, all the intelligent code is thus located
    /// in this one.
    /// </summary>
    public class MainController
    {

        #region Constants



        #endregion

        #region Enums



        #endregion

        #region Fields
        private int _port;
        private string _ipAdress;
        private TcpClient _client;
        private StreamReader _reader;
        private StreamWriter _writer;
        private ConnectionStateEnum _connectionState;

        #endregion

        #region Events & Delegates

        public event ConnectionChangedEventHandler ConnectionChanged;

        #endregion

        #region Properties



        #endregion

        #region Accessors

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public string IPAdress
        {
            get { return _ipAdress; }
            set { _ipAdress = value; }
        }

        public ConnectionStateEnum ConnectionState
        {
            get { return _connectionState; }
            set
            {
                if(ConnectionChanged != null)
                {
                    ConnectionChanged(this, new ConnectionChangedEventArgs(value));
                }
                _connectionState = value;
            }
        }

        #endregion

        #region Constructors



        #endregion

        #region Methods
        /// <summary>
        /// FR: Methode de connexion, on va instancier tout ce dont nous avons besoin et le configurer. 
        /// On envoi un pong à des fins de test.
        /// 
        /// </summary>
        public void Connect()
        {
            Logger.WriteLog("Connecting...");
            ConnectionState = ConnectionStateEnum.Connecting;
            _client = new TcpClient(IPAdress, Port);
            _reader = new StreamReader(_client.GetStream());
            _writer = new StreamWriter(_client.GetStream());
            _writer.AutoFlush = true;
            Logger.WriteLog("Send pong");
            _writer.WriteLine("Pong");
            Console.WriteLine(_reader.ReadLine());
            ConnectionState = ConnectionStateEnum.Connected;
            Logger.WriteLog("Connected");
        }

        /// <summary>
        /// FR: Méthode  de déconnexion, on va fermer tout ce dont nous avons plus besoin.
        /// </summary>
        public void Disconnect()
        {
            if (_client.Connected)
            {
                Logger.WriteLog("Disconnecting...");
                ConnectionState = ConnectionStateEnum.Disconnecting;
                _writer.Close();
                _reader.Close();
                _client.Close();
                ConnectionState = ConnectionStateEnum.Disconnected;
                Logger.WriteLog("Disconnected");
            }
        }
        #endregion
    }
}
