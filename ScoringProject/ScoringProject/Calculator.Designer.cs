namespace scoringProject
{
    partial class Calculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOverpay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMonthRent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCreditName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarSum = new System.Windows.Forms.TrackBar();
            this.trackBarPeriod = new System.Windows.Forms.TrackBar();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Калькулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Необходимая сумма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок кредита:";
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonCount.Location = new System.Drawing.Point(16, 330);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(362, 49);
            this.buttonCount.TabIndex = 3;
            this.buttonCount.Text = "Расчитать";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxOverpay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxRate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxMonthRent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxCreditName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(397, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 354);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textBoxOverpay
            // 
            this.textBoxOverpay.Location = new System.Drawing.Point(10, 276);
            this.textBoxOverpay.Name = "textBoxOverpay";
            this.textBoxOverpay.Size = new System.Drawing.Size(167, 20);
            this.textBoxOverpay.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(6, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Переплата";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(10, 209);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(167, 20);
            this.textBoxRate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ставка";
            // 
            // textBoxMonthRent
            // 
            this.textBoxMonthRent.Location = new System.Drawing.Point(10, 139);
            this.textBoxMonthRent.Name = "textBoxMonthRent";
            this.textBoxMonthRent.Size = new System.Drawing.Size(166, 20);
            this.textBoxMonthRent.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ежемесячный платеж";
            // 
            // comboBoxCreditName
            // 
            this.comboBoxCreditName.FormattingEnabled = true;
            this.comboBoxCreditName.Items.AddRange(new object[] {
            "Автокредит",
            "Ипотека",
            "Нецелевой потребительский кредит",
            "Потребительский кредит"});
            this.comboBoxCreditName.Location = new System.Drawing.Point(10, 65);
            this.comboBoxCreditName.Name = "comboBoxCreditName";
            this.comboBoxCreditName.Size = new System.Drawing.Size(166, 21);
            this.comboBoxCreditName.TabIndex = 1;
            this.comboBoxCreditName.SelectedValueChanged += new System.EventHandler(this.comboBoxCreditName_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Выбранный кредит";
            // 
            // trackBarSum
            // 
            this.trackBarSum.LargeChange = 1;
            this.trackBarSum.Location = new System.Drawing.Point(16, 160);
            this.trackBarSum.Maximum = 300000;
            this.trackBarSum.Name = "trackBarSum";
            this.trackBarSum.Size = new System.Drawing.Size(332, 45);
            this.trackBarSum.TabIndex = 5;
            this.trackBarSum.ValueChanged += new System.EventHandler(this.trackBarSum_ValueChanged);
            // 
            // trackBarPeriod
            // 
            this.trackBarPeriod.Location = new System.Drawing.Point(16, 279);
            this.trackBarPeriod.Name = "trackBarPeriod";
            this.trackBarPeriod.Size = new System.Drawing.Size(332, 45);
            this.trackBarPeriod.TabIndex = 6;
            this.trackBarPeriod.ValueChanged += new System.EventHandler(this.trackBarPeriod_ValueChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonBack.Location = new System.Drawing.Point(16, 400);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(362, 49);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Вернуться обратно";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(200, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(149, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "0";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::scoringProject.Properties.Resources.фон1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.trackBarPeriod);
            this.Controls.Add(this.trackBarSum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор кредитов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOverpay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMonthRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCreditName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarSum;
        private System.Windows.Forms.TrackBar trackBarPeriod;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}