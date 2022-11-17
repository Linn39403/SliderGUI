using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliderGUI
{
    public partial class optionsForm : Form
    {
        public Form1 Form1Obj;
        public optionsForm(Form1 obj)
        {
            InitializeComponent();
            Form1Obj = obj;
            InitSliderCombox();
            this.textBoxOFSliderMin.Text = Form1Obj.getTrackBarMinVal(0).ToString();
            this.textBoxOFSliderMax.Text = Form1Obj.getTrackBarMaxVal(0).ToString();
            this.textBoxOFSliderInitVal.Text = Form1Obj.getTrackBarVal(0).ToString();
        }
           
        private void InitSliderCombox()
        {
            int iNumber = this.Form1Obj.getNumberofSlider();
            for (int i = 0; i < iNumber; i++)
            {
                this.comboBoxOFSelectSlider.Items.Add(string.Format("P{0}", i));
            }
        }

        private void buttonOFApply_Click(object sender, EventArgs e)
        {
            if (this.comboBoxOFSelectSlider.SelectedItem != null)
            {
                int iMin = 0, iMax = 0, iVal = 0;
                try
                {
                    iMin = int.Parse(textBoxOFSliderMin.Text);
                    iMax = int.Parse(textBoxOFSliderMax.Text);
                    iVal = int.Parse(textBoxOFSliderInitVal.Text);
                }
                catch
                {
                    MessageBox.Show("Slider Min and Max input values must be interger values",
                    "Slider Min and Max input ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                this.Form1Obj.TrackBarParameterConfig(this.comboBoxOFSelectSlider.SelectedIndex, iMin, iMax, iVal);
            }
        }

        private void buttonOFClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxOFSelectSlider_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxOFSliderMin.Text = Form1Obj.getTrackBarMinVal(this.comboBoxOFSelectSlider.SelectedIndex).ToString();
            this.textBoxOFSliderMax.Text = Form1Obj.getTrackBarMaxVal(this.comboBoxOFSelectSlider.SelectedIndex).ToString();
            this.textBoxOFSliderInitVal.Text = Form1Obj.getTrackBarVal(this.comboBoxOFSelectSlider.SelectedIndex).ToString();
        }
    }
}
