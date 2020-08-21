
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
      
        
        private Logger2.Logger2 logger2 = new Logger2.Logger2();
        protected override void OnStart(string[] args)
        {
            logger2.OnStartupService();
           

        }

        
        protected override void OnStop()
        {
            logger2.OnStopService();
        }
    }
}
