using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSequencer.Helpers.Misc
{
    public static class Logger
    {
        #region Constants

        #endregion

        #region Enums



        #endregion

        #region Fields
        private static object _locker = new object();


        #endregion

        #region Events & Delegates



        #endregion

        #region Properties



        #endregion

        #region Accessors



        #endregion

        #region Constructors



        #endregion

        #region Methods
        /// <summary>
        /// FR: Methode permettant d'ecrire du texte dans un fichier de logs. Un fichier de log est généré par jour. 
        /// L'heure à laquelle on ajoute le texte est marquée dans le fichier.
        /// </summary>
        /// <param name="text"></param>
        public static void WriteLog(string text)
        {
            string logFIleName = string.Format("logs_{0}.log",DateTime.Now.ToString("dd_MM_yyyy"));
            string pathFile = Path.Combine(Program.FOLDERLOGS, logFIleName);

            lock (_locker)
            {
                if (!File.Exists(pathFile))
                {
                    File.AppendAllText(pathFile, string.Format("Hours\t\t\tLogs{0}",Environment.NewLine));
                }
                
                File.AppendAllText(pathFile, string.Format("{0}\t\t{1}{2}", DateTime.Now.ToString("hh:mm:ss"), text,Environment.NewLine)); 
            }
        }

        #endregion
    }
}
