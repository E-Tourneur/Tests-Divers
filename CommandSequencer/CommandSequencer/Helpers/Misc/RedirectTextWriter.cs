using CommandSequencer.Helpers.CustomsEvents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSequencer.Helpers.Misc
{
    /// <summary>
    /// FR: Classe heritant de TextWriter. Celle-ci, settée en sortie de la console, permet de rediriger tous les "Console.Writeline"
    /// dans le composant que l'on souhaite.
    /// </summary>
    public class ConsoleWriter : TextWriter
    {

        #region Constants



        #endregion

        #region Enums



        #endregion

        #region Fields
        private string _text;


        #endregion

        #region Events & Delegates

        public delegate void WriteLineEventHandler(object sender, ConsoleWriterEventArgs e);
        public event WriteLineEventHandler WriteLineEvent;


        #endregion

        #region Properties



        #endregion

        #region Accessors

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                if (WriteLineEvent != null)
                {
                    WriteLineEvent(this, new ConsoleWriterEventArgs(Text));
                }
            }
        }


        #endregion

        #region Constructors



        #endregion

        #region Methods


        public override void WriteLine(char value)
        {
            Text = value.ToString();
        }

        public override void WriteLine(string value)
        {
            Text = value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
        #endregion
    }
}
