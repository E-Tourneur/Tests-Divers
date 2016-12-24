using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSequencer.Helpers.CustomsEvents
{
    /// <summary>
    /// FR: Arguement de l'event "ConnectionChanged". Celui-ci contient l'état dans lequel notre controleur se trouve.
    /// </summary>
    public class ConnectionChangedEventArgs : EventArgs
    {
        public ConnectionStateEnum State { get; set; }
        public ConnectionChangedEventArgs(ConnectionStateEnum state)
        {
            State = state;
        }
    }

    public delegate void ConnectionChangedEventHandler(Object sender, ConnectionChangedEventArgs e);
}
