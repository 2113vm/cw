namespace CW.Forms
{
    partial class ReportForm
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
            this.buttonGetReport = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelBalanceStartPer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBalanceEnd = new System.Windows.Forms.Label();
            this.labelProviderName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПОДРОБНЫЙ ОТЧЕТ";
            // 
            // buttonGetReport
            // 
            this.buttonGetReport.Location = new System.Drawing.Point(126, 168);
            this.buttonGetReport.Name = "buttonGetReport";
            this.buttonGetReport.Size = new System.Drawing.Size(139, 23);
            this.buttonGetReport.TabIndex = 3;
            this.buttonGetReport.Text = "Просмотреть платежи";
            this.buttonGetReport.UseVisualStyleBackColor = true;
            this.buttonGetReport.Click += new System.EventHandler(this.buttonGetReport_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(167, 102);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(167, 128);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Items.AddRange(new object[] {
            "Холодная вода",
            "Горячая вода",
            "Электричество",
            "Газ"});
            this.comboBoxServices.Location = new System.Drawing.Point(167, 75);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(157, 21);
            this.comboBoxServices.TabIndex = 6;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 267);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(356, 120);
            this.dataGridViewData.TabIndex = 7;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(12, 204);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(145, 13);
            this.labelBalance.TabIndex = 8;
            this.labelBalance.Text = "Баланс на начало периода:";
            // 
            // labelBalanceStartPer
            // 
            this.labelBalanceStartPer.AutoSize = true;
            this.labelBalanceStartPer.Location = new System.Drawing.Point(164, 204);
            this.labelBalanceStartPer.Name = "labelBalanceStartPer";
            this.labelBalanceStartPer.Size = new System.Drawing.Size(0, 13);
            this.labelBalanceStartPer.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите услугу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата начала периода:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата конца периода:";
            // 
            // labelBalanceEnd
            // 
            this.labelBalanceEnd.AutoSize = true;
            this.labelBalanceEnd.Location = new System.Drawing.Point(12, 230);
            this.labelBalanceEnd.Name = "labelBalanceEnd";
            this.labelBalanceEnd.Size = new System.Drawing.Size(140, 13);
            this.labelBalanceEnd.TabIndex = 13;
            this.labelBalanceEnd.Text = "Баланс на конец периода:";
            // 
            // labelProviderName
            // 
            this.labelProviderName.AutoSize = true;
            this.labelProviderName.Location = new System.Drawing.Point(15, 411);
            this.labelProviderName.Name = "labelProviderName";
            this.labelProviderName.Size = new System.Drawing.Size(0, 13);
            this.labelProviderName.TabIndex = 14;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 436);
            this.Controls.Add(this.labelProviderName);
            this.Controls.Add(this.labelBalanceEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBalanceStartPer);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.comboBoxServices);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonGetReport);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "Подробный отчет";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelBalanceStartPer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBalanceEnd;
        private System.Windows.Forms.Label labelProviderName;
    }
}