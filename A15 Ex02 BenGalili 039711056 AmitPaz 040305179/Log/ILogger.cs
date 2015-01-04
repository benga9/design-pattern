using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log
{
    public abstract class ILogger
    {
        public static ILogger CreateLogger()
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

        public abstract void LogInfo(string i_Message, params object[] i_List);

        public abstract void LogWarning(string i_Message, params object[] i_List);

        public abstract void LogError(string i_Message, params object[] i_List);
    }
}
