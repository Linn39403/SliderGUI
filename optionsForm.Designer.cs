
namespace SliderGUI
{
    partial class optionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(optionsForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOFApply = new System.Windows.Forms.Button();
            this.buttonOFClose = new System.Windows.Forms.Button();
            this.comboBoxOFSelectSlider = new System.Windows.Forms.ComboBox();
            this.labelOFSelectSlider = new System.Windows.Forms.Label();
            this.labelOFMinVal = new System.Windows.Forms.Label();
            this.textBoxOFSliderMin = new System.Windows.Forms.TextBox();
            this.labelOFMaxVal = new System.Windows.Forms.Label();
            this.textBoxOFSliderMax = new System.Windows.Forms.TextBox();
            this.labelOFInitialVal = new System.Windows.Forms.Label();
            this.textBoxOFSliderInitVal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxOFSliderInitVal);
            this.panel1.Controls.Add(this.labelOFInitialVal);
            this.panel1.Controls.Add(this.textBoxOFSliderMax);
            this.panel1.Controls.Add(this.labelOFMaxVal);
            this.panel1.Controls.Add(this.textBoxOFSliderMin);
            this.panel1.Controls.Add(this.labelOFMinVal);
            this.panel1.Controls.Add(this.buttonOFApply);
            this.panel1.Controls.Add(this.buttonOFClose);
            this.panel1.Controls.Add(this.comboBoxOFSelectSlider);
            this.panel1.Controls.Add(this.labelOFSelectSlider);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 553);
            this.panel1.TabIndex = 0;
            // 
            // buttonOFApply
            // 
            this.buttonOFApply.Location = new System.Drawing.Point(248, 472);
            this.buttonOFApply.Name = "buttonOFApply";
            this.buttonOFApply.Size = new System.Drawing.Size(104, 38);
            this.buttonOFApply.TabIndex = 3;
            this.buttonOFApply.Text = "Apply";
            this.buttonOFApply.UseVisualStyleBackColor = true;
            this.buttonOFApply.Click += new System.EventHandler(this.buttonOFApply_Click);
            // 
            // buttonOFClose
            // 
            this.buttonOFClose.Location = new System.Drawing.Point(26, 472);
            this.buttonOFClose.Name = "buttonOFClose";
            this.buttonOFClose.Size = new System.Drawing.Size(104, 38);
            this.buttonOFClose.TabIndex = 2;
            this.buttonOFClose.Text = "Close";
            this.buttonOFClose.UseVisualStyleBackColor = true;
            this.buttonOFClose.Click += new System.EventHandler(this.buttonOFClose_Click);
            // 
            // comboBoxOFSelectSlider
            // 
            this.comboBoxOFSelectSlider.FormattingEnabled = true;
            this.comboBoxOFSelectSlider.Location = new System.Drawing.Point(185, 43);
            this.comboBoxOFSelectSlider.Name = "comboBoxOFSelectSlider";
            this.comboBoxOFSelectSlider.Size = new System.Drawing.Size(151, 28);
            this.comboBoxOFSelectSlider.TabIndex = 1;
            this.comboBoxOFSelectSlider.SelectedIndexChanged += new System.EventHandler(this.comboBoxOFSelectSlider_SelectedIndexChanged);
            // 
            // labelOFSelectSlider
            // 
            this.labelOFSelectSlider.AutoSize = true;
            this.labelOFSelectSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOFSelectSlider.Location = new System.Drawing.Point(21, 46);
            this.labelOFSelectSlider.Name = "labelOFSelectSlider";
            this.labelOFSelectSlider.Size = new System.Drawing.Size(127, 25);
            this.labelOFSelectSlider.TabIndex = 0;
            this.labelOFSelectSlider.Text = "Select Slider ";
            // 
            // labelOFMinVal
            // 
            this.labelOFMinVal.AutoSize = true;
            this.labelOFMinVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOFMinVal.Location = new System.Drawing.Point(27, 117);
            this.labelOFMinVal.Name = "labelOFMinVal";
            this.labelOFMinVal.Size = new System.Drawing.Size(97, 25);
            this.labelOFMinVal.TabIndex = 4;
            this.labelOFMinVal.Text = "Minimum:";
            // 
            // textBoxOFSliderMin
            // 
            this.textBoxOFSliderMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSliderMin.Location = new System.Drawing.Point(185, 112);
            this.textBoxOFSliderMin.Name = "textBoxOFSliderMin";
            this.textBoxOFSliderMin.Size = new System.Drawing.Size(151, 30);
            this.textBoxOFSliderMin.TabIndex = 5;
            // 
            // labelOFMaxVal
            // 
            this.labelOFMaxVal.AutoSize = true;
            this.labelOFMaxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOFMaxVal.Location = new System.Drawing.Point(27, 252);
            this.labelOFMaxVal.Name = "labelOFMaxVal";
            this.labelOFMaxVal.Size = new System.Drawing.Size(103, 25);
            this.labelOFMaxVal.TabIndex = 6;
            this.labelOFMaxVal.Text = "Maximum:";
            // 
            // textBoxOFSliderMax
            // 
            this.textBoxOFSliderMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSliderMax.Location = new System.Drawing.Point(185, 247);
            this.textBoxOFSliderMax.Name = "textBoxOFSliderMax";
            this.textBoxOFSliderMax.Size = new System.Drawing.Size(151, 30);
            this.textBoxOFSliderMax.TabIndex = 7;
            // 
            // labelOFInitialVal
            // 
            this.labelOFInitialVal.AutoSize = true;
            this.labelOFInitialVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOFInitialVal.Location = new System.Drawing.Point(27, 183);
            this.labelOFInitialVal.Name = "labelOFInitialVal";
            this.labelOFInitialVal.Size = new System.Drawing.Size(118, 25);
            this.labelOFInitialVal.TabIndex = 8;
            this.labelOFInitialVal.Text = "Initial Value:";
            // 
            // textBoxOFSliderInitVal
            // 
            this.textBoxOFSliderInitVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSliderInitVal.Location = new System.Drawing.Point(185, 178);
            this.textBoxOFSliderInitVal.Name = "textBoxOFSliderInitVal";
            this.textBoxOFSliderInitVal.Size = new System.Drawing.Size(151, 30);
            this.textBoxOFSliderInitVal.TabIndex = 9;
            // 
            // optionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(408, 577);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "optionsForm";
            this.Text = "Set Slider Parameters";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxOFSelectSlider;
        private System.Windows.Forms.Label labelOFSelectSlider;
        private System.Windows.Forms.Button buttonOFApply;
        private System.Windows.Forms.Button buttonOFClose;
        private System.Windows.Forms.Label labelOFMinVal;
        private System.Windows.Forms.TextBox textBoxOFSliderMax;
        private System.Windows.Forms.Label labelOFMaxVal;
        private System.Windows.Forms.TextBox textBoxOFSliderMin;
        private System.Windows.Forms.Label labelOFInitialVal;
        private System.Windows.Forms.TextBox textBoxOFSliderInitVal;
    }
}