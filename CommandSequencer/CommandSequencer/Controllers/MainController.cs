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
        #endregion

        #region Events & Delegates



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

        #endregion

        #region Constructors



        #endregion

        #region Methods
        public void Connect()
        {
            _client = new TcpClient(IPAdress, Port);
            _reader = new StreamReader(_client.GetStream());
            _writer = new StreamWriter(_client.GetStream());
            _writer.AutoFlush = true;
            _writer.WriteLine("Ping");
            //Thread.Sleep(20);
            Console.WriteLine(_reader.ReadLine());
            _writer.WriteLine("PingPing");
            //Thread.Sleep(20);
            Console.WriteLine(_reader.ReadLine());
            _writer.WriteLine("PingPingPong");
            //Thread.Sleep(20);
            Console.WriteLine(_reader.ReadLine());
            _writer.WriteLine("Stop");
            Console.WriteLine(_reader.ReadLine());

        }

        public void Disconnect()
        {
            if (_client.Connected)
            {
                _writer.Dispose();
                _reader.Dispose();
                _client.Close(); 
            }
        }
        #endregion
    }
}
