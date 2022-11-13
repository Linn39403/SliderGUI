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
        string[] SliderStringArr = new string[8];
        public Form1()
        {
            InitializeComponent();
            SliderStringArr[0] = "H0:" + labelP0Value.Text + "T";
            SliderStringArr[1] = "H1:" + labelP1Value.Text + "T";
            SliderStringArr[2] = "H2:" + labelP2Value.Text + "T";
            SliderStringArr[3] = "H3:" + labelP3Value.Text + "T";
            SliderStringArr[4] = "H4:" + labelP4Value.Text + "T";
            SliderStringArr[5] = "H5:" + labelP5Value.Text + "T";
            SliderStringArr[6] = "H6:" + labelP6Value.Text + "T";
            SliderStringArr[7] = "H7:" + labelP7Value.Text + "T";
        }

        private void comboBoxSerialPort_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxSerialPort.Items.Clear();
            comboBoxSerialPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void comboBoxBaudRate_MouseClick(object sender, MouseEventArgs e)
        {
            //Initialize Baud Rate ComboBox
            comboBoxBaudRate.Items.Clear();
            comboBoxBaudRate.Items.Add("9600");
            comboBoxBaudRate.Items.Add("14400");
            comboBoxBaudRate.Items.Add("19200");
            comboBoxBaudRate.Items.Add("28800");
            comboBoxBaudRate.Items.Add("38400");
            comboBoxBaudRate.Items.Add("57600");
            comboBoxBaudRate.Items.Add("115200");
            comboBoxBaudRate.Items.Add("230400");
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
                    foreach (string sliderString in SliderStringArr)
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

        private void trackBarP0_Scroll(object sender, EventArgs e)
        {
            labelP0Value.Text = string.Format("{0:0.0}", MapScrollVal(trackBarP0.Value.ToString()));
            SliderStringArr[0] = "H0:" + labelP0Value.Text + "T";
            WriteSerialData(SliderStringArr[0]);
        }

        private void trackBarP1_Scroll(object sender, EventArgs e)
        {
            labelP1Value.Text = string.Format("{0:0.0}", MapScrollVal(trackBarP1.Value.ToString()));
            SliderStringArr[1] = "H1:" + labelP1Value.Text + "T";
            WriteSerialData(SliderStringArr[1]);
        }

        private void trackBarP2_Scroll(object sender, EventArgs e)
        {
            labelP2Value.Text = string.Format("{0:0.0}", MapScrollVal(trackBarP2.Value.ToString()));
            SliderStringArr[2] = "H2:" + labelP2Value.Text + "T";
            WriteSerialData(SliderStringArr[2]);
        }

        private void trackBarP3_Scroll(object sender, EventArgs e)
        {
            labelP3Value.Text = string.Format("{0:0.0}", MapScrollVal(trackBarP3.Value.ToString()));
            SliderStringArr[3] = "H3:" + labelP3Value.Text + "T";
            WriteSerialData(SliderStringArr[3]);
        }

        private void trackBarP4_Scroll(object sender, EventArgs e)
        {
            labelP4Value.Text = string.Format("{0:0.0}", MapScrollVal(trackBarP4.Value.ToString()));
            SliderStringArr[4] = "H4:" + labelP4Value.Text + "T";
            WriteSerialData(SliderStringArr[4]);
        }

        private void trackBarP5_Scroll(object sender, EventArgs e)
        {
            labelP5Value.Text = string.Format("{0:0.0}", MapScrollVal(trackBarP5.Value.ToString()));
            SliderStringArr[5] = "H5:" + labelP5Value.Text + "T";
            WriteSerialData(SliderStringArr[5]);
        }

        private void trackBarP6_Scroll(object sender, EventArgs e)
        {
            labelP6Value.Text = string.Format("{0:0.0}", MapScrollVal(trackBarP6.Value.ToString()));
            SliderStringArr[6] = "H6:" + labelP6Value.Text + "T";
            WriteSerialData(SliderStringArr[6]);
        }

        private void trackBarP7_Scroll(object sender, EventArgs e)
        {
            labelP7Value.Text = string.Format("{0:0.0}", MapScrollVal(trackBarP7.Value.ToString()));
            SliderStringArr[7] = "H7:" + labelP7Value.Text + "T";
            WriteSerialData(SliderStringArr[7]);
        }
    }
}
