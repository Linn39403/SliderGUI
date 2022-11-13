
namespace SliderGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBarP0 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonClosePort = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.labelP0 = new System.Windows.Forms.Label();
            this.labelP0Value = new System.Windows.Forms.Label();
            this.labelP1Value = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.trackBarP1 = new System.Windows.Forms.TrackBar();
            this.labelP2Value = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.trackBarP2 = new System.Windows.Forms.TrackBar();
            this.labelP3Value = new System.Windows.Forms.Label();
            this.labelP3 = new System.Windows.Forms.Label();
            this.trackBarP3 = new System.Windows.Forms.TrackBar();
            this.labelP4Value = new System.Windows.Forms.Label();
            this.labelP4 = new System.Windows.Forms.Label();
            this.trackBarP4 = new System.Windows.Forms.TrackBar();
            this.labelP5Value = new System.Windows.Forms.Label();
            this.labelP5 = new System.Windows.Forms.Label();
            this.trackBarP5 = new System.Windows.Forms.TrackBar();
            this.labelP6Value = new System.Windows.Forms.Label();
            this.labelP6 = new System.Windows.Forms.Label();
            this.trackBarP6 = new System.Windows.Forms.TrackBar();
            this.labelP7Value = new System.Windows.Forms.Label();
            this.labelP7 = new System.Windows.Forms.Label();
            this.trackBarP7 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP0)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP7)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarP0
            // 
            this.trackBarP0.LargeChange = 1;
            this.trackBarP0.Location = new System.Drawing.Point(50, 236);
            this.trackBarP0.Maximum = 20;
            this.trackBarP0.Name = "trackBarP0";
            this.trackBarP0.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP0.Size = new System.Drawing.Size(69, 432);
            this.trackBarP0.TabIndex = 0;
            this.trackBarP0.TickFrequency = 0;
            this.trackBarP0.Scroll += new System.EventHandler(this.trackBarP0_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.testToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.testToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.testToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(62, 32);
            this.testToolStripMenuItem1.Text = "Edit";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(33, 69);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(175, 33);
            this.comboBoxSerialPort.TabIndex = 3;
            this.comboBoxSerialPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxSerialPort_MouseClick);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(255, 69);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(175, 33);
            this.comboBoxBaudRate.TabIndex = 4;
            this.comboBoxBaudRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxBaudRate_MouseClick);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(486, 61);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(147, 46);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonConnect_MouseClick);
            // 
            // buttonClosePort
            // 
            this.buttonClosePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClosePort.Location = new System.Drawing.Point(655, 61);
            this.buttonClosePort.Name = "buttonClosePort";
            this.buttonClosePort.Size = new System.Drawing.Size(147, 46);
            this.buttonClosePort.TabIndex = 6;
            this.buttonClosePort.Text = "Close Port";
            this.buttonClosePort.UseVisualStyleBackColor = true;
            this.buttonClosePort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClosePort_MouseClick);
            // 
            // labelP0
            // 
            this.labelP0.AutoSize = true;
            this.labelP0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP0.Location = new System.Drawing.Point(50, 196);
            this.labelP0.Name = "labelP0";
            this.labelP0.Size = new System.Drawing.Size(42, 29);
            this.labelP0.TabIndex = 7;
            this.labelP0.Text = "P0";
            // 
            // labelP0Value
            // 
            this.labelP0Value.AutoSize = true;
            this.labelP0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP0Value.Location = new System.Drawing.Point(50, 695);
            this.labelP0Value.Name = "labelP0Value";
            this.labelP0Value.Size = new System.Drawing.Size(45, 29);
            this.labelP0Value.TabIndex = 8;
            this.labelP0Value.Text = "0.0";
            // 
            // labelP1Value
            // 
            this.labelP1Value.AutoSize = true;
            this.labelP1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1Value.Location = new System.Drawing.Point(150, 695);
            this.labelP1Value.Name = "labelP1Value";
            this.labelP1Value.Size = new System.Drawing.Size(45, 29);
            this.labelP1Value.TabIndex = 11;
            this.labelP1Value.Text = "0.0";
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.Location = new System.Drawing.Point(150, 196);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(42, 29);
            this.labelP1.TabIndex = 10;
            this.labelP1.Text = "P1";
            // 
            // trackBarP1
            // 
            this.trackBarP1.LargeChange = 1;
            this.trackBarP1.Location = new System.Drawing.Point(150, 236);
            this.trackBarP1.Maximum = 20;
            this.trackBarP1.Name = "trackBarP1";
            this.trackBarP1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP1.Size = new System.Drawing.Size(69, 432);
            this.trackBarP1.TabIndex = 9;
            this.trackBarP1.TickFrequency = 0;
            this.trackBarP1.Scroll += new System.EventHandler(this.trackBarP1_Scroll);
            // 
            // labelP2Value
            // 
            this.labelP2Value.AutoSize = true;
            this.labelP2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2Value.Location = new System.Drawing.Point(250, 695);
            this.labelP2Value.Name = "labelP2Value";
            this.labelP2Value.Size = new System.Drawing.Size(45, 29);
            this.labelP2Value.TabIndex = 14;
            this.labelP2Value.Text = "0.0";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.Location = new System.Drawing.Point(250, 196);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(42, 29);
            this.labelP2.TabIndex = 13;
            this.labelP2.Text = "P2";
            // 
            // trackBarP2
            // 
            this.trackBarP2.LargeChange = 1;
            this.trackBarP2.Location = new System.Drawing.Point(250, 236);
            this.trackBarP2.Maximum = 20;
            this.trackBarP2.Name = "trackBarP2";
            this.trackBarP2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP2.Size = new System.Drawing.Size(69, 432);
            this.trackBarP2.TabIndex = 12;
            this.trackBarP2.TickFrequency = 0;
            this.trackBarP2.Scroll += new System.EventHandler(this.trackBarP2_Scroll);
            // 
            // labelP3Value
            // 
            this.labelP3Value.AutoSize = true;
            this.labelP3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP3Value.Location = new System.Drawing.Point(350, 695);
            this.labelP3Value.Name = "labelP3Value";
            this.labelP3Value.Size = new System.Drawing.Size(45, 29);
            this.labelP3Value.TabIndex = 17;
            this.labelP3Value.Text = "0.0";
            // 
            // labelP3
            // 
            this.labelP3.AutoSize = true;
            this.labelP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP3.Location = new System.Drawing.Point(350, 196);
            this.labelP3.Name = "labelP3";
            this.labelP3.Size = new System.Drawing.Size(42, 29);
            this.labelP3.TabIndex = 16;
            this.labelP3.Text = "P3";
            // 
            // trackBarP3
            // 
            this.trackBarP3.LargeChange = 1;
            this.trackBarP3.Location = new System.Drawing.Point(350, 236);
            this.trackBarP3.Maximum = 20;
            this.trackBarP3.Name = "trackBarP3";
            this.trackBarP3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP3.Size = new System.Drawing.Size(69, 432);
            this.trackBarP3.TabIndex = 15;
            this.trackBarP3.TickFrequency = 0;
            this.trackBarP3.Scroll += new System.EventHandler(this.trackBarP3_Scroll);
            // 
            // labelP4Value
            // 
            this.labelP4Value.AutoSize = true;
            this.labelP4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP4Value.Location = new System.Drawing.Point(445, 696);
            this.labelP4Value.Name = "labelP4Value";
            this.labelP4Value.Size = new System.Drawing.Size(45, 29);
            this.labelP4Value.TabIndex = 20;
            this.labelP4Value.Text = "0.0";
            // 
            // labelP4
            // 
            this.labelP4.AutoSize = true;
            this.labelP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP4.Location = new System.Drawing.Point(451, 197);
            this.labelP4.Name = "labelP4";
            this.labelP4.Size = new System.Drawing.Size(42, 29);
            this.labelP4.TabIndex = 19;
            this.labelP4.Text = "P4";
            // 
            // trackBarP4
            // 
            this.trackBarP4.LargeChange = 1;
            this.trackBarP4.Location = new System.Drawing.Point(450, 236);
            this.trackBarP4.Maximum = 20;
            this.trackBarP4.Name = "trackBarP4";
            this.trackBarP4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP4.Size = new System.Drawing.Size(69, 432);
            this.trackBarP4.TabIndex = 18;
            this.trackBarP4.TickFrequency = 0;
            this.trackBarP4.Scroll += new System.EventHandler(this.trackBarP4_Scroll);
            // 
            // labelP5Value
            // 
            this.labelP5Value.AutoSize = true;
            this.labelP5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP5Value.Location = new System.Drawing.Point(551, 696);
            this.labelP5Value.Name = "labelP5Value";
            this.labelP5Value.Size = new System.Drawing.Size(45, 29);
            this.labelP5Value.TabIndex = 23;
            this.labelP5Value.Text = "0.0";
            // 
            // labelP5
            // 
            this.labelP5.AutoSize = true;
            this.labelP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP5.Location = new System.Drawing.Point(551, 197);
            this.labelP5.Name = "labelP5";
            this.labelP5.Size = new System.Drawing.Size(42, 29);
            this.labelP5.TabIndex = 22;
            this.labelP5.Text = "P5";
            // 
            // trackBarP5
            // 
            this.trackBarP5.LargeChange = 1;
            this.trackBarP5.Location = new System.Drawing.Point(550, 236);
            this.trackBarP5.Maximum = 20;
            this.trackBarP5.Name = "trackBarP5";
            this.trackBarP5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP5.Size = new System.Drawing.Size(69, 432);
            this.trackBarP5.TabIndex = 21;
            this.trackBarP5.TickFrequency = 0;
            this.trackBarP5.Scroll += new System.EventHandler(this.trackBarP5_Scroll);
            // 
            // labelP6Value
            // 
            this.labelP6Value.AutoSize = true;
            this.labelP6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP6Value.Location = new System.Drawing.Point(641, 696);
            this.labelP6Value.Name = "labelP6Value";
            this.labelP6Value.Size = new System.Drawing.Size(45, 29);
            this.labelP6Value.TabIndex = 26;
            this.labelP6Value.Text = "0.0";
            // 
            // labelP6
            // 
            this.labelP6.AutoSize = true;
            this.labelP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP6.Location = new System.Drawing.Point(651, 197);
            this.labelP6.Name = "labelP6";
            this.labelP6.Size = new System.Drawing.Size(42, 29);
            this.labelP6.TabIndex = 25;
            this.labelP6.Text = "P6";
            // 
            // trackBarP6
            // 
            this.trackBarP6.LargeChange = 1;
            this.trackBarP6.Location = new System.Drawing.Point(650, 236);
            this.trackBarP6.Maximum = 20;
            this.trackBarP6.Name = "trackBarP6";
            this.trackBarP6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP6.Size = new System.Drawing.Size(69, 432);
            this.trackBarP6.TabIndex = 24;
            this.trackBarP6.TickFrequency = 0;
            this.trackBarP6.Scroll += new System.EventHandler(this.trackBarP6_Scroll);
            // 
            // labelP7Value
            // 
            this.labelP7Value.AutoSize = true;
            this.labelP7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP7Value.Location = new System.Drawing.Point(755, 695);
            this.labelP7Value.Name = "labelP7Value";
            this.labelP7Value.Size = new System.Drawing.Size(45, 29);
            this.labelP7Value.TabIndex = 29;
            this.labelP7Value.Text = "0.0";
            // 
            // labelP7
            // 
            this.labelP7.AutoSize = true;
            this.labelP7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP7.Location = new System.Drawing.Point(750, 196);
            this.labelP7.Name = "labelP7";
            this.labelP7.Size = new System.Drawing.Size(42, 29);
            this.labelP7.TabIndex = 28;
            this.labelP7.Text = "P7";
            // 
            // trackBarP7
            // 
            this.trackBarP7.LargeChange = 1;
            this.trackBarP7.Location = new System.Drawing.Point(750, 236);
            this.trackBarP7.Maximum = 20;
            this.trackBarP7.Name = "trackBarP7";
            this.trackBarP7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP7.Size = new System.Drawing.Size(69, 432);
            this.trackBarP7.TabIndex = 27;
            this.trackBarP7.TickFrequency = 0;
            this.trackBarP7.Scroll += new System.EventHandler(this.trackBarP7_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 794);
            this.Controls.Add(this.labelP7Value);
            this.Controls.Add(this.labelP7);
            this.Controls.Add(this.trackBarP7);
            this.Controls.Add(this.labelP6Value);
            this.Controls.Add(this.labelP6);
            this.Controls.Add(this.trackBarP6);
            this.Controls.Add(this.labelP5Value);
            this.Controls.Add(this.labelP5);
            this.Controls.Add(this.trackBarP5);
            this.Controls.Add(this.labelP4Value);
            this.Controls.Add(this.labelP4);
            this.Controls.Add(this.trackBarP4);
            this.Controls.Add(this.labelP3Value);
            this.Controls.Add(this.labelP3);
            this.Controls.Add(this.trackBarP3);
            this.Controls.Add(this.labelP2Value);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.trackBarP2);
            this.Controls.Add(this.labelP1Value);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.trackBarP1);
            this.Controls.Add(this.labelP0Value);
            this.Controls.Add(this.labelP0);
            this.Controls.Add(this.buttonClosePort);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.trackBarP0);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Slider GUI";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP0)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarP0;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonClosePort;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label labelP0;
        private System.Windows.Forms.Label labelP0Value;
        private System.Windows.Forms.Label labelP1Value;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.TrackBar trackBarP1;
        private System.Windows.Forms.Label labelP2Value;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.TrackBar trackBarP2;
        private System.Windows.Forms.Label labelP3Value;
        private System.Windows.Forms.Label labelP3;
        private System.Windows.Forms.TrackBar trackBarP3;
        private System.Windows.Forms.Label labelP4Value;
        private System.Windows.Forms.Label labelP4;
        private System.Windows.Forms.TrackBar trackBarP4;
        private System.Windows.Forms.Label labelP5Value;
        private System.Windows.Forms.Label labelP5;
        private System.Windows.Forms.TrackBar trackBarP5;
        private System.Windows.Forms.Label labelP6Value;
        private System.Windows.Forms.Label labelP6;
        private System.Windows.Forms.TrackBar trackBarP6;
        private System.Windows.Forms.Label labelP7Value;
        private System.Windows.Forms.Label labelP7;
        private System.Windows.Forms.TrackBar trackBarP7;
    }
}

