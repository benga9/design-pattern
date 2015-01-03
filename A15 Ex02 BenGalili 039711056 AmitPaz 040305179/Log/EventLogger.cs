using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log
{
    public sealed class EventLogger : ILogger
    {
        private EventLogger()
        {
            ELogger = new EventLog();
        }

        public EventLog ELogger { get; set; }

        public static EventLogger Instance
        {
            get
            {
                return Singleton<EventLogger>.Instance;
            }
        }

        public void LogInfo(string message, params object[] list)
        {
            string text = string.Format(message, list);
            ELogger.WriteEntry(text, EventLogEntryType.Information);
        }

        public void LogWarning(string message, params object[] list)
        {
            string text = string.Format(message, list);
            ELogger.WriteEntry(text, EventLogEntryType.Warning);
        }

        public void LogError(string message, params object[] list)
        {
            string text = string.Format(message, list);
            ELogger.WriteEntry(text, EventLogEntryType.Error);
        }
    }
}
