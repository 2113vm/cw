namespace CW.Forms
{
    partial class AddClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxThirdName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxTenants = new System.Windows.Forms.TextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.textBoxCreateLogin = new System.Windows.Forms.TextBox();
            this.textBoxCreatePassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxColdProvider = new System.Windows.Forms.ComboBox();
            this.comboBoxHotProvider = new System.Windows.Forms.ComboBox();
            this.comboBoxGasProvider = new System.Windows.Forms.ComboBox();
            this.comboBoxElectProvider = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(104, 431);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(120, 37);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Площадь квартиры:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Количество проживающих:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Придумайте логин:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Придумайте пароль:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Серия и номер паспорта:";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(17, 41);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(131, 20);
            this.textBoxSecondName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(186, 41);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(130, 20);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // textBoxThirdName
            // 
            this.textBoxThirdName.Location = new System.Drawing.Point(343, 41);
            this.textBoxThirdName.Name = "textBoxThirdName";
            this.textBoxThirdName.Size = new System.Drawing.Size(170, 20);
            this.textBoxThirdName.TabIndex = 12;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(17, 94);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(299, 20);
            this.textBoxAddress.TabIndex = 13;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(343, 93);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(54, 20);
            this.textBoxArea.TabIndex = 14;
            // 
            // textBoxTenants
            // 
            this.textBoxTenants.Location = new System.Drawing.Point(17, 151);
            this.textBoxTenants.Name = "textBoxTenants";
            this.textBoxTenants.Size = new System.Drawing.Size(56, 20);
            this.textBoxTenants.TabIndex = 15;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(196, 151);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(120, 20);
            this.textBoxPassport.TabIndex = 16;
            // 
            // textBoxCreateLogin
            // 
            this.textBoxCreateLogin.Location = new System.Drawing.Point(237, 222);
            this.textBoxCreateLogin.Name = "textBoxCreateLogin";
            this.textBoxCreateLogin.Size = new System.Drawing.Size(160, 20);
            this.textBoxCreateLogin.TabIndex = 17;
            // 
            // textBoxCreatePassword
            // 
            this.textBoxCreatePassword.Location = new System.Drawing.Point(237, 246);
            this.textBoxCreatePassword.Name = "textBoxCreatePassword";
            this.textBoxCreatePassword.Size = new System.Drawing.Size(160, 20);
            this.textBoxCreatePassword.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Укажите поставщика холодной воды:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Укажите поставщика горячей воды:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Укажите поставщика газа:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 367);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Укажите поставщика электричество:";
            // 
            // comboBoxColdProvider
            // 
            this.comboBoxColdProvider.FormattingEnabled = true;
            this.comboBoxColdProvider.Location = new System.Drawing.Point(313, 288);
            this.comboBoxColdProvider.Name = "comboBoxColdProvider";
            this.comboBoxColdProvider.Size = new System.Drawing.Size(200, 21);
            this.comboBoxColdProvider.TabIndex = 23;
            // 
            // comboBoxHotProvider
            // 
            this.comboBoxHotProvider.FormattingEnabled = true;
            this.comboBoxHotProvider.Location = new System.Drawing.Point(313, 312);
            this.comboBoxHotProvider.Name = "comboBoxHotProvider";
            this.comboBoxHotProvider.Size = new System.Drawing.Size(200, 21);
            this.comboBoxHotProvider.TabIndex = 24;
            // 
            // comboBoxGasProvider
            // 
            this.comboBoxGasProvider.FormattingEnabled = true;
            this.comboBoxGasProvider.Location = new System.Drawing.Point(313, 338);
            this.comboBoxGasProvider.Name = "comboBoxGasProvider";
            this.comboBoxGasProvider.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGasProvider.TabIndex = 25;
            // 
            // comboBoxElectProvider
            // 
            this.comboBoxElectProvider.FormattingEnabled = true;
            this.comboBoxElectProvider.Location = new System.Drawing.Point(313, 364);
            this.comboBoxElectProvider.Name = "comboBoxElectProvider";
            this.comboBoxElectProvider.Size = new System.Drawing.Size(200, 21);
            this.comboBoxElectProvider.TabIndex = 26;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(240, 431);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 37);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 480);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxElectProvider);
            this.Controls.Add(this.comboBoxGasProvider);
            this.Controls.Add(this.comboBoxHotProvider);
            this.Controls.Add(this.comboBoxColdProvider);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCreatePassword);
            this.Controls.Add(this.textBoxCreateLogin);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.textBoxTenants);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxThirdName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddUser);
            this.Name = "AddClientForm";
            this.Text = "Добавить пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxThirdName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxTenants;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.TextBox textBoxCreateLogin;
        private System.Windows.Forms.TextBox textBoxCreatePassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxColdProvider;
        private System.Windows.Forms.ComboBox comboBoxHotProvider;
        private System.Windows.Forms.ComboBox comboBoxGasProvider;
        private System.Windows.Forms.ComboBox comboBoxElectProvider;
        private System.Windows.Forms.Button buttonCancel;
    }
}