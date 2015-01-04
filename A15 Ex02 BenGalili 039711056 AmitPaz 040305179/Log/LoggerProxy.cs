using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log
{
    public class LoggerProxy : ILogger
    {
        private static ILogger s_ILogger = null;
        private int m_ReferenceCountToLoggerProxy = 0;

        private LoggerProxy()
        {
            s_ILogger = ILogger.CreateLogger();
        }

        public static LoggerProxy Instance
        {
            get
            {
                return Singleton<LoggerProxy>.Instance;
            }
        }

        public int ReferenceCountToLoggerProxy
        {
            get
            {
                return m_ReferenceCountToLoggerProxy;
            }

            private set
            {
                m_ReferenceCountToLoggerProxy = value;
            }
        }

        public override void LogInfo(string i_Message, params object[] i_List)
        {
            s_ILogger.LogInfo(i_Message, i_List);
            ReferenceCountToLoggerProxy++;
        }

        public override void LogWarning(string i_Message, params object[] i_List)
        {
            s_ILogger.LogWarning(i_Message, i_List);
            ReferenceCountToLoggerProxy++;
        }

        public override void LogError(string i_Message, params object[] i_List)
        {
            s_ILogger.LogError(i_Message, i_List);
            ReferenceCountToLoggerProxy++;
        }
    }
}