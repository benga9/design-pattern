using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log
{
    public interface ILogger
    {
        void LogInfo(string i_Message, params object[] i_List);

        void LogWarning(string i_Message, params object[] i_List);

        void LogError(string i_Message, params object[] i_List);
    }
}
