using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Logger
{
    public class Logger
    {
        private static System.Timers.Timer _timer;

        public void OnStartupService()
        {
            _timer = new System.Timers.Timer();
            _timer.Interval = 10000;
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            int cpuValue = GetCpuValue();
            int memvalue = GetMemValue();
            DateTime dt = DateTime.Now;
            DataSet1TableAdapters.DataTableAdapter adapter = new DataSet1TableAdapters.DataTableAdapter();
            adapter.InsertQuery(cpuValue, memvalue, dt);
           
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
