using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log
{
    public sealed class Logger : ILogger
    {
        private static ILogger s_ILogger = null;

        private Logger()
        {
            s_ILogger = LoggerFactory.CreateLogger();
        }

        public static Logger Instance
        {
            get
            {
                return Singleton<Logger>.Instance;
            }
        }

        /// <summary>
        /// Method to log information messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        public void LogInfo(string message, params object[] list)
        {
            s_ILogger.LogInfo(message, list);
        }

        /// <summary>
        /// Method to warning information messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        public void LogWarning(string message, params object[] list) 
        {
            s_ILogger.LogWarning(message, list);
        }

        /// <summary>
        /// Method to error information messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        public void LogError(string message, params object[] list)
        {
            s_ILogger.LogError(message, list);
        }

        internal class LoggerFactory
        {
            internal static ILogger CreateLogger()
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
}