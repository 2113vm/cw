namespace CW.Forms
{
    partial class KassaCardForm
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
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddPayments = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(73, 56);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(162, 23);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Добавить домовладельца";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddPayments
            // 
            this.buttonAddPayments.Location = new System.Drawing.Point(73, 125);
            this.buttonAddPayments.Name = "buttonAddPayments";
            this.buttonAddPayments.Size = new System.Drawing.Size(162, 23);
            this.buttonAddPayments.TabIndex = 1;
            this.buttonAddPayments.Text = "Внести платеж";
            this.buttonAddPayments.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // KassaCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAddPayments);
            this.Controls.Add(this.buttonAddUser);
            this.Name = "KassaCardForm";
            this.Text = "KassaCardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddPayments;
        private System.Windows.Forms.Button button3;
    }
}