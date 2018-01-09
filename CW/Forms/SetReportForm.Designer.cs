namespace CW.Forms
{
    partial class SetReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetMeter = new System.Windows.Forms.Button();
            this.comboBoxServiceName = new System.Windows.Forms.ComboBox();
            this.textBoxMeter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите услугу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите показания:";
            // 
            // buttonSetMeter
            // 
            this.buttonSetMeter.Location = new System.Drawing.Point(81, 153);
            this.buttonSetMeter.Name = "buttonSetMeter";
            this.buttonSetMeter.Size = new System.Drawing.Size(118, 23);
            this.buttonSetMeter.TabIndex = 2;
            this.buttonSetMeter.Text = "Внести показания";
            this.buttonSetMeter.UseVisualStyleBackColor = true;
            this.buttonSetMeter.Click += new System.EventHandler(this.buttonSetMeter_Click);
            // 
            // comboBoxServiceName
            // 
            this.comboBoxServiceName.FormattingEnabled = true;
            this.comboBoxServiceName.Items.AddRange(new object[] {
            "Холодная вода",
            "Горячая вода",
            "Газ",
            "Электричество"});
            this.comboBoxServiceName.Location = new System.Drawing.Point(151, 52);
            this.comboBoxServiceName.Name = "comboBoxServiceName";
            this.comboBoxServiceName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServiceName.TabIndex = 3;
            // 
            // textBoxMeter
            // 
            this.textBoxMeter.Location = new System.Drawing.Point(151, 94);
            this.textBoxMeter.Name = "textBoxMeter";
            this.textBoxMeter.Size = new System.Drawing.Size(121, 20);
            this.textBoxMeter.TabIndex = 4;
            // 
            // SetReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 203);
            this.Controls.Add(this.textBoxMeter);
            this.Controls.Add(this.comboBoxServiceName);
            this.Controls.Add(this.buttonSetMeter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetReportForm";
            this.Text = "Внести показания счетчиков";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSetMeter;
        private System.Windows.Forms.ComboBox comboBoxServiceName;
        private System.Windows.Forms.TextBox textBoxMeter;
    }
}