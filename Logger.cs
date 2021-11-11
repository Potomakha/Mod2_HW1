using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_HW1
{
    /// <summary>
    /// Logger class.
    /// </summary>
    public class Logger
    {
        private static Logger instance;
        private static string _logText = string.Empty;

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void MakeLog(LoggerTypes type, string resultErrorText)
        {
            string logstr = $"[{DateTime.UtcNow}]:{type.ToString()}:{resultErrorText}";
            _logText += logstr + "\n";
            Console.WriteLine(logstr);
        }

        public static void SaveLog()
        {
            File.WriteAllText("log.txt", _logText);
        }
    }
}
