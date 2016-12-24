using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSequencer.Helpers.CustomsEvents
{
    public class ConsoleWriterEventArgs
    {
        public string Value { get; set; }
        public ConsoleWriterEventArgs(string value)
        {
            Value = value;
        }
    }
}
