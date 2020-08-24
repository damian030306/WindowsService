namespace MonitoringUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MonitoringUI.DataSet1();
            this.dataTableAdapter = new MonitoringUI.DataSet1TableAdapters.DataTableAdapter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mem = new System.Windows.Forms.Label();
            this.Cpu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceStatusLabel = new System.Windows.Forms.Label();
            this.ServiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "Data";
            this.dataBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 511);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wykres użycia pamięci RAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wykres użycia CPU";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.DataSource = this.dataBindingSource;
            legend1.BorderWidth = 5;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(510, 266);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 6;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "DateTaken";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "MemValue";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(374, 194);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click_1);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.dataBindingSource;
            legend2.BorderWidth = 5;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(510, 45);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "DateTaken";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "CpuValue";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(374, 194);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cpuValueDataGridViewTextBoxColumn,
            this.memValueDataGridViewTextBoxColumn,
            this.dateTakenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-28, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 383);
            this.dataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpuValueDataGridViewTextBoxColumn
            // 
            this.cpuValueDataGridViewTextBoxColumn.DataPropertyName = "CpuValue";
            this.cpuValueDataGridViewTextBoxColumn.HeaderText = "CpuValue";
            this.cpuValueDataGridViewTextBoxColumn.Name = "cpuValueDataGridViewTextBoxColumn";
            // 
            // memValueDataGridViewTextBoxColumn
            // 
            this.memValueDataGridViewTextBoxColumn.DataPropertyName = "MemValue";
            this.memValueDataGridViewTextBoxColumn.HeaderText = "MemValue";
            this.memValueDataGridViewTextBoxColumn.Name = "memValueDataGridViewTextBoxColumn";
            // 
            // dateTakenDataGridViewTextBoxColumn
            // 
            this.dateTakenDataGridViewTextBoxColumn.DataPropertyName = "DateTaken";
            this.dateTakenDataGridViewTextBoxColumn.HeaderText = "DateTaken";
            this.dateTakenDataGridViewTextBoxColumn.Name = "dateTakenDataGridViewTextBoxColumn";
            this.dateTakenDataGridViewTextBoxColumn.Width = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saved data in database:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Mem);
            this.panel1.Controls.Add(this.Cpu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ServiceStatusLabel);
            this.panel1.Controls.Add(this.ServiceButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 100);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(429, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Memory usage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(429, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cpu usage:";
            // 
            // Mem
            // 
            this.Mem.AutoSize = true;
            this.Mem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Mem.Location = new System.Drawing.Point(559, 47);
            this.Mem.Name = "Mem";
            this.Mem.Size = new System.Drawing.Size(80, 20);
            this.Mem.TabIndex = 4;
            this.Mem.Text = "Loading...";
            // 
            // Cpu
            // 
            this.Cpu.AutoSize = true;
            this.Cpu.BackColor = System.Drawing.Color.Orange;
            this.Cpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Cpu.Location = new System.Drawing.Point(559, 12);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(80, 20);
            this.Cpu.TabIndex = 3;
            this.Cpu.Text = "Loading...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service status:";
            // 
            // ServiceStatusLabel
            // 
            this.ServiceStatusLabel.AutoSize = true;
            this.ServiceStatusLabel.BackColor = System.Drawing.Color.Salmon;
            this.ServiceStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ServiceStatusLabel.Location = new System.Drawing.Point(100, 12);
            this.ServiceStatusLabel.Name = "ServiceStatusLabel";
            this.ServiceStatusLabel.Size = new System.Drawing.Size(77, 22);
            this.ServiceStatusLabel.TabIndex = 1;
            this.ServiceStatusLabel.Text = "Stopped";
            // 
            // ServiceButton
            // 
            this.ServiceButton.BackColor = System.Drawing.Color.YellowGreen;
            this.ServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ServiceButton.Location = new System.Drawing.Point(20, 47);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(157, 32);
            this.ServiceButton.TabIndex = 2;
            this.ServiceButton.Text = "Start";
            this.ServiceButton.UseVisualStyleBackColor = false;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Monitoring UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private DataSet1TableAdapters.DataTableAdapter dataTableAdapter;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpuValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Mem;
        private System.Windows.Forms.Label Cpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ServiceStatusLabel;
        private System.Windows.Forms.Button ServiceButton;
    }
}

