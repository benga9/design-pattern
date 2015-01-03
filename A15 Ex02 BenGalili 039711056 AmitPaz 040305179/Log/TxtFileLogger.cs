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

        public static TxtFileLogger Instance
        {
            get
            {
                return Singleton<TxtFileLogger>.Instance;
            }
        }

        public StreamWriter TxtLogger { get; set; }

        public void LogInfo(string i_Message, params object[] i_List)
        {
            string text = "[" + DateTime.Now + "]" + " [INFO:] " + string.Format(i_Message, i_List);
            TxtLogger.WriteLine(text);
            TxtLogger.Flush();
        }

        public void LogWarning(string i_Message, params object[] i_List)
        {
            string text = "[" + DateTime.Now + "]" + " [WARNING:] " + string.Format(i_Message, i_List);
            TxtLogger.WriteLine(text);
            TxtLogger.Flush();
        }

        public void LogError(string i_Message, params object[] i_List)
        {
            string text = "[" + DateTime.Now + "]" + " [ERROR:] " + string.Format(i_Message, i_List);
            TxtLogger.WriteLine(text);
            TxtLogger.Flush();
        }
    }
}
