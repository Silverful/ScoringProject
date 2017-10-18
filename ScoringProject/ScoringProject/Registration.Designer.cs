namespace scoringProject
{
    partial class Registration
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
            this.butComplete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personalData = new System.Windows.Forms.TabPage();
            this.passportData = new System.Windows.Forms.TabPage();
            this.contactData = new System.Windows.Forms.TabPage();
            this.educationData = new System.Windows.Forms.TabPage();
            this.adressData = new System.Windows.Forms.TabPage();
            this.familyData = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butComplete
            // 
            this.butComplete.Location = new System.Drawing.Point(189, 324);
            this.butComplete.Name = "butComplete";
            this.butComplete.Size = new System.Drawing.Size(188, 33);
            this.butComplete.TabIndex = 0;
            this.butComplete.Text = "Завершить регистрацию";
            this.butComplete.UseVisualStyleBackColor = true;
            this.butComplete.Click += new System.EventHandler(this.butComplete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personalData);
            this.tabControl1.Controls.Add(this.passportData);
            this.tabControl1.Controls.Add(this.contactData);
            this.tabControl1.Controls.Add(this.educationData);
            this.tabControl1.Controls.Add(this.adressData);
            this.tabControl1.Controls.Add(this.familyData);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 310);
            this.tabControl1.TabIndex = 1;
            // 
            // personalData
            // 
            this.personalData.Location = new System.Drawing.Point(4, 22);
            this.personalData.Name = "personalData";
            this.personalData.Padding = new System.Windows.Forms.Padding(3);
            this.personalData.Size = new System.Drawing.Size(552, 284);
            this.personalData.TabIndex = 0;
            this.personalData.Text = "Персональные данные";
            this.personalData.UseVisualStyleBackColor = true;
            // 
            // passportData
            // 
            this.passportData.Location = new System.Drawing.Point(4, 22);
            this.passportData.Name = "passportData";
            this.passportData.Padding = new System.Windows.Forms.Padding(3);
            this.passportData.Size = new System.Drawing.Size(552, 284);
            this.passportData.TabIndex = 1;
            this.passportData.Text = "Паспортные данные";
            this.passportData.UseVisualStyleBackColor = true;
            // 
            // contactData
            // 
            this.contactData.Location = new System.Drawing.Point(4, 22);
            this.contactData.Name = "contactData";
            this.contactData.Padding = new System.Windows.Forms.Padding(3);
            this.contactData.Size = new System.Drawing.Size(552, 284);
            this.contactData.TabIndex = 2;
            this.contactData.Text = "Контактная информация";
            this.contactData.UseVisualStyleBackColor = true;
            // 
            // educationData
            // 
            this.educationData.Location = new System.Drawing.Point(4, 22);
            this.educationData.Name = "educationData";
            this.educationData.Size = new System.Drawing.Size(552, 284);
            this.educationData.TabIndex = 3;
            this.educationData.Text = "Образование";
            this.educationData.UseVisualStyleBackColor = true;
            // 
            // adressData
            // 
            this.adressData.Location = new System.Drawing.Point(4, 22);
            this.adressData.Name = "adressData";
            this.adressData.Size = new System.Drawing.Size(552, 284);
            this.adressData.TabIndex = 4;
            this.adressData.Text = "Адрес";
            this.adressData.UseVisualStyleBackColor = true;
            // 
            // familyData
            // 
            this.familyData.Location = new System.Drawing.Point(4, 22);
            this.familyData.Name = "familyData";
            this.familyData.Size = new System.Drawing.Size(552, 284);
            this.familyData.TabIndex = 5;
            this.familyData.Text = "Семья";
            this.familyData.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.butComplete);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butComplete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personalData;
        private System.Windows.Forms.TabPage passportData;
        private System.Windows.Forms.TabPage contactData;
        private System.Windows.Forms.TabPage educationData;
        private System.Windows.Forms.TabPage adressData;
        private System.Windows.Forms.TabPage familyData;
    }
}