using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceController service = new ServiceController("MonitoringEngine");
            ServiceStatusLabel.Text = service.Status.ToString();
            if(ServiceStatusLabel.Text.ToLower() == "running")
            {
                ServiceButton.Text = "Stop";
                ServiceButton.BackColor = System.Drawing.Color.Salmon;
                ServiceStatusLabel.BackColor = System.Drawing.Color.YellowGreen;
            }
            else
            {
                ServiceButton.Text = "Start";
                ServiceButton.BackColor = System.Drawing.Color.YellowGreen;
                ServiceStatusLabel.BackColor = System.Drawing.Color.Salmon;
            }


            // TODO: This line of code loads data into the 'dataSet1.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.dataSet1.Data);
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yy" + System.Environment.NewLine + "hh:mm:ss";
            chart2.Series[0].XValueType = ChartValueType.DateTime;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yy" + System.Environment.NewLine + "hh:mm:ss";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {
            

        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            ServiceController service = new ServiceController("MonitoringEngine");
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
            if (ServiceStatusLabel.Text.ToLower() == "running")
            {
                ServiceButton.Text = "Stop";
                ServiceButton.BackColor = System.Drawing.Color.Salmon;
                ServiceStatusLabel.BackColor = System.Drawing.Color.YellowGreen;

            }
            else
            {
                ServiceButton.Text = "Start";
                ServiceButton.BackColor = System.Drawing.Color.YellowGreen;
                ServiceStatusLabel.BackColor = System.Drawing.Color.Salmon;

            }
        }
    }
}
