
using Logger2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;


namespace MonitoringWindowsService
{
    public partial class MonitoringEngine : ServiceBase
    {
        public MonitoringEngine()
        {
            InitializeComponent();

        }
      
        //private static System.Timers.Timer _timer;
        private Logger2.Logger2 logger2 = new Logger2.Logger2();
        protected override void OnStart(string[] args)
        {
            logger2.OnStartupService();
            //_timer = new System.Timers.Timer();
            //_timer.Interval = 10000;
            //_timer.Elapsed += OnTimedEvent;
            //_timer.AutoReset = true;
            //_timer.Enabled = true;


        }

        
        protected override void OnStop()
        {
            logger2.OnStopService();
        }
    }
}
