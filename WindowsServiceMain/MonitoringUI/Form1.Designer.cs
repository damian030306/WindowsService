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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MonitoringUI.DataSet1();
            this.dataTableAdapter = new MonitoringUI.DataSet1TableAdapters.DataTableAdapter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.ServiceStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cpu = new System.Windows.Forms.Label();
            this.Mem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabControl1.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monitor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Mem);
            this.panel1.Controls.Add(this.Cpu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ServiceStatusLabel);
            this.panel1.Controls.Add(this.ServiceButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 100);
            this.panel1.TabIndex = 5;
            // 
            // ServiceButton
            // 
            this.ServiceButton.BackColor = System.Drawing.Color.YellowGreen;
            this.ServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ServiceButton.Location = new System.Drawing.Point(20, 47);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(136, 32);
            this.ServiceButton.TabIndex = 2;
            this.ServiceButton.Text = "Start";
            this.ServiceButton.UseVisualStyleBackColor = false;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButton_Click);
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
            this.ServiceStatusLabel.Click += new System.EventHandler(this.label2_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 479);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saved data in database:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
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
            this.dataGridView1.Size = new System.Drawing.Size(479, 383);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTakenDataGridViewTextBoxColumn
            // 
            this.dateTakenDataGridViewTextBoxColumn.DataPropertyName = "DateTaken";
            this.dateTakenDataGridViewTextBoxColumn.HeaderText = "DateTaken";
            this.dateTakenDataGridViewTextBoxColumn.Name = "dateTakenDataGridViewTextBoxColumn";
            this.dateTakenDataGridViewTextBoxColumn.Width = 115;
            // 
            // memValueDataGridViewTextBoxColumn
            // 
            this.memValueDataGridViewTextBoxColumn.DataPropertyName = "MemValue";
            this.memValueDataGridViewTextBoxColumn.HeaderText = "MemValue";
            this.memValueDataGridViewTextBoxColumn.Name = "memValueDataGridViewTextBoxColumn";
            // 
            // cpuValueDataGridViewTextBoxColumn
            // 
            this.cpuValueDataGridViewTextBoxColumn.DataPropertyName = "CpuValue";
            this.cpuValueDataGridViewTextBoxColumn.HeaderText = "CpuValue";
            this.cpuValueDataGridViewTextBoxColumn.Name = "cpuValueDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.MajorGrid.LineWidth = 0;
            chartArea5.AxisY.MajorGrid.LineWidth = 0;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.DataSource = this.dataBindingSource;
            legend5.BorderWidth = 5;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(510, 45);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.XValueMember = "DateTaken";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series5.YValueMembers = "CpuValue";
            series5.YValuesPerPoint = 2;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(360, 194);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.AxisX.MajorGrid.LineWidth = 0;
            chartArea6.AxisY.MajorGrid.LineWidth = 0;
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            this.chart2.DataSource = this.dataBindingSource;
            legend6.BorderWidth = 5;
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(510, 245);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.BorderWidth = 6;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.XValueMember = "DateTaken";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.YValueMembers = "MemValue";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(360, 194);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wykres użycia CPU";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Monitoring UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private DataSet1TableAdapters.DataTableAdapter dataTableAdapter;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
    }
}

