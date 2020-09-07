namespace Audio_Spectrum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Btn_Enable = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.red_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.green_label = new System.Windows.Forms.Label();
            this.blue_label = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.spectrum1 = new Audio_Spectrum.Spectrum();
            this.colorViewer = new System.Windows.Forms.Panel();
            this.comports_box = new System.Windows.Forms.ComboBox();
            this.comport_conn = new System.Windows.Forms.Button();
            this.comport_baud = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hide_btn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fadeSilence = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.blue_bar = new System.Windows.Forms.Panel();
            this.green_bar = new System.Windows.Forms.Panel();
            this.red_bar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 145);
            this.progressBar1.Maximum = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(217, 18);
            this.progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(288, 145);
            this.progressBar2.Maximum = 50;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(217, 18);
            this.progressBar2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(57, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Btn_Enable
            // 
            this.Btn_Enable.Enabled = false;
            this.Btn_Enable.Location = new System.Drawing.Point(184, 55);
            this.Btn_Enable.Name = "Btn_Enable";
            this.Btn_Enable.Size = new System.Drawing.Size(107, 21);
            this.Btn_Enable.TabIndex = 9;
            this.Btn_Enable.Text = "Enable";
            this.Btn_Enable.UseVisualStyleBackColor = true;
            this.Btn_Enable.Click += new System.EventHandler(this.Btn_Enable_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Device";
            // 
            // red_label
            // 
            this.red_label.AutoSize = true;
            this.red_label.Location = new System.Drawing.Point(29, 22);
            this.red_label.Name = "red_label";
            this.red_label.Size = new System.Drawing.Size(13, 13);
            this.red_label.TabIndex = 12;
            this.red_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "R:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "G:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "B:";
            // 
            // green_label
            // 
            this.green_label.AutoSize = true;
            this.green_label.Location = new System.Drawing.Point(29, 39);
            this.green_label.Name = "green_label";
            this.green_label.Size = new System.Drawing.Size(13, 13);
            this.green_label.TabIndex = 16;
            this.green_label.Text = "0";
            // 
            // blue_label
            // 
            this.blue_label.AutoSize = true;
            this.blue_label.Location = new System.Drawing.Point(29, 56);
            this.blue_label.Name = "blue_label";
            this.blue_label.Size = new System.Drawing.Size(13, 13);
            this.blue_label.TabIndex = 17;
            this.blue_label.Text = "0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(14, 178);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(491, 112);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elementHost1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 300);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio Analyzer";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(14, 19);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(491, 111);
            this.elementHost1.TabIndex = 18;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.spectrum1;
            // 
            // colorViewer
            // 
            this.colorViewer.BackColor = System.Drawing.Color.White;
            this.colorViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorViewer.Location = new System.Drawing.Point(163, 22);
            this.colorViewer.Name = "colorViewer";
            this.colorViewer.Size = new System.Drawing.Size(133, 47);
            this.colorViewer.TabIndex = 23;
            // 
            // comports_box
            // 
            this.comports_box.FormattingEnabled = true;
            this.comports_box.Location = new System.Drawing.Point(43, 19);
            this.comports_box.Name = "comports_box";
            this.comports_box.Size = new System.Drawing.Size(58, 21);
            this.comports_box.TabIndex = 24;
            // 
            // comport_conn
            // 
            this.comport_conn.Location = new System.Drawing.Point(216, 17);
            this.comport_conn.Name = "comport_conn";
            this.comport_conn.Size = new System.Drawing.Size(75, 23);
            this.comport_conn.TabIndex = 25;
            this.comport_conn.Text = "Connect";
            this.comport_conn.UseVisualStyleBackColor = true;
            this.comport_conn.Click += new System.EventHandler(this.comport_conn_Click);
            // 
            // comport_baud
            // 
            this.comport_baud.Location = new System.Drawing.Point(145, 19);
            this.comport_baud.Name = "comport_baud";
            this.comport_baud.Size = new System.Drawing.Size(65, 20);
            this.comport_baud.TabIndex = 26;
            this.comport_baud.Text = "9600";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comport_conn);
            this.groupBox2.Controls.Add(this.comport_baud);
            this.groupBox2.Controls.Add(this.comports_box);
            this.groupBox2.Location = new System.Drawing.Point(541, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 53);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Connection";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Baud";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Port";
            // 
            // hide_btn
            // 
            this.hide_btn.Location = new System.Drawing.Point(779, 281);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(72, 26);
            this.hide_btn.TabIndex = 29;
            this.hide_btn.Text = "Hide to tray";
            this.hide_btn.UseVisualStyleBackColor = true;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Audio RGB LED Analyzer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fadeSilence);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Btn_Enable);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(541, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 98);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // fadeSilence
            // 
            this.fadeSilence.AutoSize = true;
            this.fadeSilence.Location = new System.Drawing.Point(14, 58);
            this.fadeSilence.Name = "fadeSilence";
            this.fadeSilence.Size = new System.Drawing.Size(72, 17);
            this.fadeSilence.TabIndex = 30;
            this.fadeSilence.Text = "Fuck You";
            this.fadeSilence.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ON/OFF";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.blue_bar);
            this.groupBox4.Controls.Add(this.colorViewer);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.blue_label);
            this.groupBox4.Controls.Add(this.green_bar);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.red_label);
            this.groupBox4.Controls.Add(this.red_bar);
            this.groupBox4.Controls.Add(this.green_label);
            this.groupBox4.Location = new System.Drawing.Point(541, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 86);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RGB Channels";
            // 
            // blue_bar
            // 
            this.blue_bar.BackColor = System.Drawing.Color.Blue;
            this.blue_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blue_bar.Location = new System.Drawing.Point(56, 56);
            this.blue_bar.Name = "blue_bar";
            this.blue_bar.Size = new System.Drawing.Size(100, 13);
            this.blue_bar.TabIndex = 33;
            // 
            // green_bar
            // 
            this.green_bar.BackColor = System.Drawing.Color.Lime;
            this.green_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.green_bar.Location = new System.Drawing.Point(56, 39);
            this.green_bar.Name = "green_bar";
            this.green_bar.Size = new System.Drawing.Size(100, 13);
            this.green_bar.TabIndex = 33;
            // 
            // red_bar
            // 
            this.red_bar.BackColor = System.Drawing.Color.Red;
            this.red_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.red_bar.Location = new System.Drawing.Point(56, 22);
            this.red_bar.Name = "red_bar";
            this.red_bar.Size = new System.Drawing.Size(100, 13);
            this.red_bar.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 325);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.hide_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio RGB Spectrum Analyzer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Btn_Enable;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label red_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label green_label;
        private System.Windows.Forms.Label blue_label;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private Spectrum spectrum1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comports_box;
        private System.Windows.Forms.Button comport_conn;
        private System.Windows.Forms.TextBox comport_baud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button hide_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel colorViewer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel red_bar;
        private System.Windows.Forms.Panel blue_bar;
        private System.Windows.Forms.Panel green_bar;
        private System.Windows.Forms.CheckBox fadeSilence;
        private System.Windows.Forms.Label label4;
    }
}

