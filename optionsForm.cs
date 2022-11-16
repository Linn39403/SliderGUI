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
            this.textBoxOFSliderMin.Text = Form1Obj.getTrackBarMinVal().ToString();
            this.textBoxOFSliderMax.Text = Form1Obj.getTrackBarMaxVal().ToString();
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
                this.Form1Obj.TrackBarParameterConfig(this.comboBoxOFSelectSlider.SelectedIndex, 0, 100);
            }
        }
    }
}
