using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool activ = true;
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");
                // use local m/c IP address, and 
                // use the same in the client

                /* Initializes the Listener */
                TcpListener myList = new TcpListener(ipAd, 10001);

                /* Start Listeneting at the specified port */
                myList.Start();

                Console.WriteLine("The server is running at port 8001...");
                Console.WriteLine("The local End point is  :" +
                                  myList.LocalEndpoint);
                Console.WriteLine("Waiting for a connection.....");

                Socket s = myList.AcceptSocket();
                Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);

                do
                {
                    using (var myStream = new NetworkStream(s))
                    {
                        StreamReader read = new StreamReader(myStream);
                        Console.WriteLine("waiting recieved...");
                        string receive = read.ReadLine();
                        Console.WriteLine(receive);

                        StreamWriter writ = new StreamWriter(myStream);
                        writ.WriteLine(string.Format("Received : {0}", receive));
                        writ.Flush();

                        if (receive.ToUpper().Contains("STOP"))
                        {
                            activ = false;
                        }
                    }
                } while (activ);
                //byte[] b = new byte[100];
                //int k = s.Receive(b);
                //Console.WriteLine("Recieved...");
                //for (int i = 0; i < k; i++)
                //    Console.Write(Convert.ToChar(b[i]));

                //ASCIIEncoding asen = new ASCIIEncoding();
                //s.Send(asen.GetBytes("The string was recieved by the server."));
                //Console.WriteLine("\nSent Acknowledgement");
                /* clean up */
                Console.WriteLine("Stop");
                s.Close();
                myList.Stop();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
        }
    
    }
}
