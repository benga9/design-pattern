using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log
{
    public interface ILogger
    {
        /// <summary>
        /// Method to log information messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        void LogInfo(string message, params object[] list);

        /// <summary>
        /// Method to warning information messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        void LogWarning(string message, params object[] list);

        /// <summary>
        /// Method to error information messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        void LogError(string message, params object[] list);
    }
}
