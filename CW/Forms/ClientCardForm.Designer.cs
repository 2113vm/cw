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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonHotWater = new System.Windows.Forms.Button();
            this.buttonElect = new System.Windows.Forms.Button();
            this.buttonGas = new System.Windows.Forms.Button();
            this.buttonColdWater = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "КАРТОЧКА ПОЛЬЗОВАТЕЛЯ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(293, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label2";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(293, 88);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(35, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // buttonHotWater
            // 
            this.buttonHotWater.Location = new System.Drawing.Point(33, 154);
            this.buttonHotWater.Name = "buttonHotWater";
            this.buttonHotWater.Size = new System.Drawing.Size(106, 28);
            this.buttonHotWater.TabIndex = 7;
            this.buttonHotWater.Text = "Горячая вода";
            this.buttonHotWater.UseVisualStyleBackColor = true;
            // 
            // buttonElect
            // 
            this.buttonElect.Location = new System.Drawing.Point(344, 154);
            this.buttonElect.Name = "buttonElect";
            this.buttonElect.Size = new System.Drawing.Size(108, 28);
            this.buttonElect.TabIndex = 9;
            this.buttonElect.Text = "Электричество";
            this.buttonElect.UseVisualStyleBackColor = true;
            // 
            // buttonGas
            // 
            this.buttonGas.Location = new System.Drawing.Point(516, 154);
            this.buttonGas.Name = "buttonGas";
            this.buttonGas.Size = new System.Drawing.Size(108, 28);
            this.buttonGas.TabIndex = 10;
            this.buttonGas.Text = "Газ";
            this.buttonGas.UseVisualStyleBackColor = true;
            // 
            // buttonColdWater
            // 
            this.buttonColdWater.Location = new System.Drawing.Point(181, 154);
            this.buttonColdWater.Name = "buttonColdWater";
            this.buttonColdWater.Size = new System.Drawing.Size(106, 28);
            this.buttonColdWater.TabIndex = 11;
            this.buttonColdWater.Text = "Холодная вода";
            this.buttonColdWater.UseVisualStyleBackColor = true;
            // 
            // ClientCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 273);
            this.Controls.Add(this.buttonColdWater);
            this.Controls.Add(this.buttonGas);
            this.Controls.Add(this.buttonElect);
            this.Controls.Add(this.buttonHotWater);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Name = "ClientCardForm";
            this.Text = "ClientCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonHotWater;
        private System.Windows.Forms.Button buttonElect;
        private System.Windows.Forms.Button buttonGas;
        private System.Windows.Forms.Button buttonColdWater;
    }
}