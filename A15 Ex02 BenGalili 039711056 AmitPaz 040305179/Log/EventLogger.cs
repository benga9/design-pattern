using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log
{
    public sealed class EventLogger : ILogger
    {
        private static string s_LogSource = "Design.Pattern";
        private static string s_LogName = "Design-Pattern EventLog";
        private static string s_MachineName = ".";

        private EventLogger()
        {
            if (!EventLog.Exists(s_LogName, s_MachineName))
            {
                EventSourceCreationData creationData = new EventSourceCreationData(s_LogSource, s_LogName);
                creationData.MachineName = s_MachineName;
                EventLog.CreateEventSource(creationData);
            }

            ELogger = new EventLog();
            ELogger.Source = s_LogSource;
        }

        public static EventLogger Instance
        {
            get
            {
                return Singleton<EventLogger>.Instance;
            }
        }

        public EventLog ELogger { get; set; }

        public override void LogInfo(string i_Message, params object[] i_List)
        {
            string text = string.Format(i_Message, i_List);
            ELogger.WriteEntry(text, EventLogEntryType.Information);
        }

        public override void LogWarning(string i_Message, params object[] i_List)
        {
            string text = string.Format(i_Message, i_List);
            ELogger.WriteEntry(text, EventLogEntryType.Warning);
        }

        public override void LogError(string i_Message, params object[] i_List)
        {
            string text = string.Format(i_Message, i_List);
            ELogger.WriteEntry(text, EventLogEntryType.Error);
        }
    }
}
