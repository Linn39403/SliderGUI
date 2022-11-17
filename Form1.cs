using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;



namespace SliderGUI
{
    public partial class Form1 : Form
    {
        SerialPort mySerialPort;
        readonly static int NumOfSlider = 8;
        readonly static int TrackBarMinVal = 0, TrackBarMaxVal = 20;
        private struct SliderGUI_t
        {
            public TrackBar[] TrackBarHandle;
            public Label[] TrackBarLabel;
            public Label[] TrackBarValue;
            public string[] Cmd;
        }
        private SliderGUI_t SliderGUIComp;
        optionsForm optionForm;

        public int getNumberofSlider()
        {
            return NumOfSlider;
        }

        public int getTrackBarMinVal(int index)
        {        
            return SliderGUIComp.TrackBarHandle[index].Minimum;
        }

        public int getTrackBarMaxVal(int index)
        {
            return SliderGUIComp.TrackBarHandle[index].Maximum;
        }

        public int getTrackBarVal(int index)
        {
            return SliderGUIComp.TrackBarHandle[index].Value;
        }

        public void TrackBarParameterConfig(int index, int min, int max, int val)
        {
            SliderGUIComp.TrackBarHandle[index].Minimum = min;
            SliderGUIComp.TrackBarHandle[index].Maximum = max;
            SliderGUIComp.TrackBarHandle[index].Value = val;
        }

        public Form1()
        {
            InitializeComponent();
            SliderGUIComp.TrackBarHandle = new TrackBar[NumOfSlider];
            SliderGUIComp.TrackBarLabel = new Label[NumOfSlider];
            SliderGUIComp.TrackBarValue = new Label[NumOfSlider];
            SliderGUIComp.Cmd = new string[NumOfSlider];
            SliderGUIInit();
        }

        private void SliderGUIInit()
        {
            int XDistance = 50;
            for(int i=0; i < NumOfSlider; i++)
            {
                /* TrackBar */
                SliderGUIComp.TrackBarHandle[i] = new TrackBar();
                SliderGUIComp.TrackBarHandle[i].Size = new System.Drawing.Size(70, 430);
                SliderGUIComp.TrackBarHandle[i].AutoSize = false;
                SliderGUIComp.TrackBarHandle[i].Orientation = Orientation.Vertical;
                SliderGUIComp.TrackBarHandle[i].Value = 0;
                SliderGUIComp.TrackBarHandle[i].Minimum = TrackBarMinVal;
                SliderGUIComp.TrackBarHandle[i].Maximum = TrackBarMaxVal;
                SliderGUIComp.TrackBarHandle[i].TickStyle = TickStyle.Both;
                SliderGUIComp.TrackBarHandle[i].TickFrequency = 0; // 0 means no marks 
                SliderGUIComp.TrackBarHandle[i].Location = new System.Drawing.Point(XDistance, 100);
                SliderGUIComp.TrackBarHandle[i].Name = i.ToString();
                this.mainPanel.Controls.Add(SliderGUIComp.TrackBarHandle[i]);
                SliderGUIComp.TrackBarHandle[i].Scroll += new System.EventHandler(this.TrackBarScrollEvt);

                /* TrackBar Title */
                SliderGUIComp.TrackBarLabel[i] = new Label();
                SliderGUIComp.TrackBarLabel[i].Size = new System.Drawing.Size(40, 30);
                SliderGUIComp.TrackBarLabel[i].Text = "P" + i.ToString();
                SliderGUIComp.TrackBarLabel[i].Location = new System.Drawing.Point(XDistance + 10, 80);
                this.mainPanel.Controls.Add(SliderGUIComp.TrackBarLabel[i]);

                /* TrackBar Value */
                SliderGUIComp.TrackBarValue[i] = new Label();
                SliderGUIComp.TrackBarValue[i].Size = new System.Drawing.Size(40, 30);
                SliderGUIComp.TrackBarValue[i].Text = string.Format("{0:0.0}", MapScrollVal(SliderGUIComp.TrackBarHandle[i].Value.ToString()));
                SliderGUIComp.TrackBarValue[i].Location = new System.Drawing.Point(XDistance + 10, 550);
                this.mainPanel.Controls.Add(SliderGUIComp.TrackBarValue[i]);

                SliderGUIComp.Cmd[i] = "H" + i.ToString() + ":" + SliderGUIComp.TrackBarHandle[i].Value.ToString() + "T"; //string.Format("H{0}:{1}T", i, SliderGUIComp.TrackBarValue[i].Text);

                XDistance += 100;            
            }
            this.Refresh();
            comboBoxBaudRateInit();
            SetDefaultValues();
            comboBoxSerialPortInit();
        }

        private void comboBoxSerialPortInit()
        {
            comboBoxSerialPort.Items.Clear();
            comboBoxSerialPort.Items.AddRange(SerialPort.GetPortNames());
            comboBoxSerialPort.SelectedIndex = 0;
        }

        private void comboBoxBaudRateInit()
        {
            comboBoxBaudRate.Items.Clear();
            comboBoxBaudRate.Items.Add("9600");
            comboBoxBaudRate.Items.Add("14400");
            comboBoxBaudRate.Items.Add("19200");
            comboBoxBaudRate.Items.Add("28800");
            comboBoxBaudRate.Items.Add("38400");
            comboBoxBaudRate.Items.Add("57600");
            comboBoxBaudRate.Items.Add("115200");
            comboBoxBaudRate.Items.Add("230400");
            comboBoxBaudRate.SelectedIndex = 6;
        }

        private void comboBoxSerialPort_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxSerialPort.Items.Clear();
            comboBoxSerialPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void buttonConnect_MouseClick(object sender, MouseEventArgs e)
        {
            string SliderStringTemp = "";
            if (buttonConnect.Text != "Connected!" && comboBoxSerialPort.SelectedItem != null && comboBoxBaudRate.SelectedItem != null)
            {
                mySerialPort = new SerialPort(comboBoxSerialPort.SelectedItem.ToString(),
                                              Int32.Parse(comboBoxBaudRate.SelectedItem.ToString()),
                                              Parity.None, 8, StopBits.One);
                try
                {
                    mySerialPort.Open();
                    //foreach (string sliderString in SliderStringArr)
                    foreach (string sliderString in SliderGUIComp.Cmd)
                    {
                        SliderStringTemp += sliderString;
                    }
                    mySerialPort.Write(SliderStringTemp);
                }
                catch
                {

                }
                buttonConnect.Text = "Connected!";
                this.Update();
            }
        }

        private void buttonClosePort_MouseClick(object sender, MouseEventArgs e)
        {
            if( mySerialPort != null && mySerialPort.IsOpen == true )
            {
                buttonConnect.Text = "Connect";
                try
                {
                    mySerialPort.Close();
                }
                catch
                {

                }
                this.Update();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(mySerialPort != null && mySerialPort.IsOpen == true)
            {
                mySerialPort.Close();
            }
            Application.Exit();
        }

        private float MapScrollVal(string inputString)
        {
            float MapValue = float.Parse(inputString);
            return MapValue/(float)10.0;
        }

        private void WriteSerialData(string inputString)
        {
            if (mySerialPort != null && mySerialPort.IsOpen == true)
            {
                mySerialPort.Write(inputString);
            }
        }

        private void SetDefaultValues()
        {
            for(int i=0; i< NumOfSlider; i++)
            {
                SliderGUIComp.TrackBarHandle[i].Value =   TrackBarMinVal + ( TrackBarMaxVal) / 2;
                SliderGUIComp.TrackBarHandle[i].Minimum = TrackBarMinVal;
                SliderGUIComp.TrackBarHandle[i].Maximum = TrackBarMaxVal;
            }
        }
        private void TrackBarScrollEvt(object sender, EventArgs e)
        {
            string TrackBarName = ((System.Windows.Forms.Control)sender).Name;
            int Idx = Int32.Parse(TrackBarName);
            SliderGUIComp.TrackBarValue[Idx].Text = string.Format("{0:0.0}", MapScrollVal(SliderGUIComp.TrackBarHandle[Idx].Value.ToString()));
            SliderGUIComp.Cmd[Idx] = "H" + TrackBarName + ":" + SliderGUIComp.TrackBarHandle[Idx].Value.ToString() + "T" + "\r\n";
            WriteSerialData(SliderGUIComp.Cmd[Idx]);
        }

        private void restoreDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        private void setNewValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionForm = new optionsForm(this); //new form for slider parameters configuration
            if ( optionForm != null )
            {            
                optionForm.Show();
            }
        }
    }
}
