using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log
{
    public class Logger : ILogger
    {
        private static ILogger s_ILogger = null;

        private Logger()
        {
            s_ILogger = CreateLogger();
        }

        public static Logger Instance
        {
            get
            {
                return Singleton<Logger>.Instance;
            }
        }

        public void LogInfo(string i_Message, params object[] i_List)
        {
            s_ILogger.LogInfo(i_Message, i_List);
        }

        public void LogWarning(string i_Message, params object[] i_List)
        {
            s_ILogger.LogWarning(i_Message, i_List);
        }

        public void LogError(string i_Message, params object[] i_List)
        {
            s_ILogger.LogError(i_Message, i_List);
        }

        protected static ILogger CreateLogger()
        {
            ILogger logger = null;
            string loggerType = ConfigurationManager.AppSettings["LogClassID"];
            switch (loggerType)
            {
                case "TxtFileLogger":
                    logger = TxtFileLogger.Instance;
                    break;
                case "EventLogger":
                    logger = EventLogger.Instance;
                    break;
            }

            return logger;
        }
    }
}