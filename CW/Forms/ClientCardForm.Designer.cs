namespace CW.Forms
{
    partial class ClientCardForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelHotWater = new System.Windows.Forms.Label();
            this.labelColdWater = new System.Windows.Forms.Label();
            this.labelElect = new System.Windows.Forms.Label();
            this.labelGas = new System.Windows.Forms.Label();
            this.buttonGetReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "КАРТОЧКА ПОЛЬЗОВАТЕЛЯ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label2";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 35);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(35, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "label3";
            // 
            // labelHotWater
            // 
            this.labelHotWater.AutoSize = true;
            this.labelHotWater.Location = new System.Drawing.Point(107, 72);
            this.labelHotWater.Name = "labelHotWater";
            this.labelHotWater.Size = new System.Drawing.Size(75, 13);
            this.labelHotWater.TabIndex = 3;
            this.labelHotWater.Text = "labelHotWater";
            // 
            // labelColdWater
            // 
            this.labelColdWater.AutoSize = true;
            this.labelColdWater.Location = new System.Drawing.Point(107, 85);
            this.labelColdWater.Name = "labelColdWater";
            this.labelColdWater.Size = new System.Drawing.Size(79, 13);
            this.labelColdWater.TabIndex = 4;
            this.labelColdWater.Text = "labelColdWater";
            // 
            // labelElect
            // 
            this.labelElect.AutoSize = true;
            this.labelElect.Location = new System.Drawing.Point(107, 98);
            this.labelElect.Name = "labelElect";
            this.labelElect.Size = new System.Drawing.Size(53, 13);
            this.labelElect.TabIndex = 5;
            this.labelElect.Text = "labelElect";
            // 
            // labelGas
            // 
            this.labelGas.AutoSize = true;
            this.labelGas.Location = new System.Drawing.Point(107, 111);
            this.labelGas.Name = "labelGas";
            this.labelGas.Size = new System.Drawing.Size(48, 13);
            this.labelGas.TabIndex = 6;
            this.labelGas.Text = "labelGas";
            // 
            // buttonGetReport
            // 
            this.buttonGetReport.Location = new System.Drawing.Point(76, 159);
            this.buttonGetReport.Name = "buttonGetReport";
            this.buttonGetReport.Size = new System.Drawing.Size(106, 28);
            this.buttonGetReport.TabIndex = 7;
            this.buttonGetReport.Text = "Отчет";
            this.buttonGetReport.UseVisualStyleBackColor = true;
            this.buttonGetReport.Click += new System.EventHandler(this.buttonGetReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Горячая вода:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Холодная вода:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Электричество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Газ:";
            // 
            // ClientCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 199);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGetReport);
            this.Controls.Add(this.labelGas);
            this.Controls.Add(this.labelElect);
            this.Controls.Add(this.labelColdWater);
            this.Controls.Add(this.labelHotWater);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Name = "ClientCardForm";
            this.Text = "Карточка пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelHotWater;
        private System.Windows.Forms.Label labelColdWater;
        private System.Windows.Forms.Label labelElect;
        private System.Windows.Forms.Label labelGas;
        private System.Windows.Forms.Button buttonGetReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}