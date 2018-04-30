using System;
using System.Diagnostics;

namespace WriteToAnEventLog_csharp
{
    /// Summary description for Class1.
    class Class1
    {
        static void Main(string[] args)
        {
            string sSource;
            string sLog;
            string sEvent;

            sSource = "Dark Army Data Exfiltrator 中国人民解放军";
            sLog = "Application";
            sEvent = "You stupid měiguó rén";

            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent);
            EventLog.WriteEntry(sSource, sEvent,
            EventLogEntryType.Warning, 667);
        }
    }
}
