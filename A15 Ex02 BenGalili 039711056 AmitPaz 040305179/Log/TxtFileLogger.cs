using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log
{
    public sealed class TxtFileLogger : ILogger
    {
        private TxtFileLogger()
        {
            TxtLogger = new StreamWriter("txtLogger.txt");
        }

        public StreamWriter TxtLogger { get; set; }

        public static TxtFileLogger Instance
        {
            get
            {
                return Singleton<TxtFileLogger>.Instance;
            }
        }

        public void LogInfo(string message, params object[] list)
        {
            string text = "[" + DateTime.Now + "]" + " [INFO:] " + string.Format(message, list);
            TxtLogger.WriteLine(text);
            TxtLogger.Flush();
        }

        public void LogWarning(string message, params object[] list)
        {
            string text = "[" + DateTime.Now + "]" + " [WARNING:] " + string.Format(message, list);
            TxtLogger.WriteLine(text);
            TxtLogger.Flush();
        }

        public void LogError(string message, params object[] list)
        {
            string text = "[" + DateTime.Now + "]" + " [ERROR:] " + string.Format(message, list);
            TxtLogger.WriteLine(text);
            TxtLogger.Flush();
        }
    }
}
