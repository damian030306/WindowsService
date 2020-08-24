using Logger2;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MonitoringUI
{
    public partial class Form1 : Form
    {
        private NameValueCollection AllAppSettings = ConfigurationManager.AppSettings;
        private string serviceName;
        private static System.Timers.Timer _timer;
        Logger2.Logger2 logger2;
        public Form1()
        {

            InitializeComponent();
            serviceName = AllAppSettings["serviceName"];
            logger2 = new Logger2.Logger2();
            
            _timer = new System.Timers.Timer();
            _timer.Interval = 1000;
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;


        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            int cpuValue = logger2.GetCpuValue();
            int memvalue = logger2.GetMemValue();
            changeValueLabel(cpuValue, memvalue);
           



        }
        private void changeValueLabel(int cpuValue, int memvalue)
        {
            if (Cpu.InvokeRequired)
            {
                Cpu.Invoke(new MethodInvoker(delegate
                {
                    Cpu.Text = cpuValue + "%";
                }));
                
            }
            if (Mem.InvokeRequired)
            {
                Mem.Invoke(new MethodInvoker(delegate
                {
                    Mem.Text =  memvalue + "%";
                }));

            }
            
        }

        
        private void changeStatusLabel()
        {
            if (ServiceStatusLabel.Text.ToLower() == "running")
            {
                ServiceButton.Text = "Stop";
                ServiceButton.BackColor = System.Drawing.Color.Salmon;
                ServiceStatusLabel.BackColor = System.Drawing.Color.YellowGreen;
            }
            else if (ServiceStatusLabel.Text == "Service MonitoringEngine was not found on computer '.'.")
            {
                ServiceStatusLabel.Text = "Not Found";
                ServiceStatusLabel.BackColor = System.Drawing.Color.Salmon;

            }
            else
            {
                ServiceButton.Text = "Start";
                ServiceButton.BackColor = System.Drawing.Color.YellowGreen;
                ServiceStatusLabel.BackColor = System.Drawing.Color.Salmon;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            ServiceController service;
            try
            {
                
                service = new ServiceController(serviceName);
                ServiceStatusLabel.Text = service.Status.ToString();

            }
            catch(InvalidOperationException e2)
            {
                ServiceStatusLabel.Text = e2.Message;
            }
            changeStatusLabel();
            


            // TODO: This line of code loads data into the 'dataSet1.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.dataSet1.Data);
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yy" + System.Environment.NewLine + "hh:mm:ss";
            chart2.Series[0].XValueType = ChartValueType.DateTime;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yy" + System.Environment.NewLine + "hh:mm:ss";
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Cpu_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void ServiceButton_Click_1(object sender, EventArgs e)
        {
            

            ServiceController service;
            try
            {

               service = new ServiceController(serviceName);
                if (ServiceStatusLabel.Text.ToLower() == "running")
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped);
                    

                }
                else
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running);
                }
                ServiceStatusLabel.Text = service.Status.ToString();

            }
            catch (InvalidOperationException e2)
            {
                ServiceStatusLabel.Text = e2.Message;
            }
            changeStatusLabel();
        }
    }
}
