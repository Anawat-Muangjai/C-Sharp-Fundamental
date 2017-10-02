using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EventViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            string eventLog = "Application";
            string eventSource = "Logging Demo App";
            string eventMessage = "Hello from Logging Demo App";

            //Create the event source if it doesn't already exits
            if (!EventLog.SourceExists(eventSource))
                EventLog.CreateEventSource(eventSource, eventLog);

            //Log the message
            EventLog.WriteEntry(eventSource, eventMessage, EventLogEntryType.Warning, 234);
            Console.ReadKey();
        }
    }
}
