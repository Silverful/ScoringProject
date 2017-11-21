namespace scoringProject
{
    partial class Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.privateData = new System.Windows.Forms.TabPage();
            this.creditType = new System.Windows.Forms.TabPage();
            this.work = new System.Windows.Forms.TabPage();
            this.history = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back to Client Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.privateData);
            this.tabControl1.Controls.Add(this.creditType);
            this.tabControl1.Controls.Add(this.work);
            this.tabControl1.Controls.Add(this.history);
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 338);
            this.tabControl1.TabIndex = 2;
            // 
            // privateData
            // 
            this.privateData.Location = new System.Drawing.Point(4, 22);
            this.privateData.Name = "privateData";
            this.privateData.Padding = new System.Windows.Forms.Padding(3);
            this.privateData.Size = new System.Drawing.Size(652, 312);
            this.privateData.TabIndex = 0;
            this.privateData.Text = "Личные данные";
            this.privateData.UseVisualStyleBackColor = true;
            // 
            // creditType
            // 
            this.creditType.Location = new System.Drawing.Point(4, 22);
            this.creditType.Name = "creditType";
            this.creditType.Padding = new System.Windows.Forms.Padding(3);
            this.creditType.Size = new System.Drawing.Size(652, 312);
            this.creditType.TabIndex = 1;
            this.creditType.Text = "Вид кредита";
            this.creditType.UseVisualStyleBackColor = true;
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(4, 22);
            this.work.Name = "work";
            this.work.Padding = new System.Windows.Forms.Padding(3);
            this.work.Size = new System.Drawing.Size(652, 312);
            this.work.TabIndex = 2;
            this.work.Text = "Работа, доход";
            this.work.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(4, 22);
            this.history.Name = "history";
            this.history.Padding = new System.Windows.Forms.Padding(3);
            this.history.Size = new System.Drawing.Size(652, 312);
            this.history.TabIndex = 3;
            this.history.Text = "Кредитная история";
            this.history.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Анкетирование";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анкетирование";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage privateData;
        private System.Windows.Forms.TabPage creditType;
        private System.Windows.Forms.TabPage work;
        private System.Windows.Forms.TabPage history;
        private System.Windows.Forms.Label label1;
    }
}