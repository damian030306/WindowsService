using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Text;

namespace Logger2
{
    public class Logger2
    {
        private static System.Timers.Timer _timer;
        //private NameValueCollection AllAppSettings;
        public string source, logName, machineName;
        private EventLog eventLog;

        public Logger2()
        {
            //AllAppSettings = ConfigurationManager.AppSettings;
            source = "MonitoringSourceLog";
            logName = "MonitoringServiceLog";
            machineName = ".";
        }

        public void OnStartupService()
        {
            if (!EventLog.SourceExists(source, machineName))
            {
                EventLog.CreateEventSource(source, logName);
            }
            eventLog = new EventLog(logName, machineName, source);
            _timer = new System.Timers.Timer();
            _timer.Interval = 60000;
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;
            eventLog.WriteEntry("MonitoringWindowsService is working");
        }
        public void OnStopService()
        {
            //eventLog.Dispose();
        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            int cpuValue = GetCpuValue();
            int memvalue = GetMemValue();
            DateTime dt = DateTime.Now;
            DataSet1TableAdapters.DataTableAdapter adapter = new DataSet1TableAdapters.DataTableAdapter();
            adapter.InsertQuery(cpuValue, memvalue, dt);
            eventLog.WriteEntry("MonitoringWindowsService saved data to database");

        }
        private static int GetCpuValue()
        {
            var CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
       
            CpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returValue = Convert.ToInt32(CpuCounter.NextValue());
            return returValue;
        }
        private static int GetMemValue()
        {
            var MemCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");
            MemCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returValue = Convert.ToInt32(MemCounter.NextValue());
            return returValue;
        }
    }
}
