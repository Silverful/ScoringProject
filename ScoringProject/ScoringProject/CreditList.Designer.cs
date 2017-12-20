namespace scoringProject
{
    partial class CreditList
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
            this.richTextBoxCreditInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelCreditName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(422, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Обратно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxCreditInfo
            // 
            this.richTextBoxCreditInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBoxCreditInfo.Location = new System.Drawing.Point(16, 79);
            this.richTextBoxCreditInfo.Name = "richTextBoxCreditInfo";
            this.richTextBoxCreditInfo.Size = new System.Drawing.Size(406, 213);
            this.richTextBoxCreditInfo.TabIndex = 1;
            this.richTextBoxCreditInfo.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация о кредитах:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(428, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Следующий";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(428, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Предыдущий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelCreditName
            // 
            this.labelCreditName.AutoSize = true;
            this.labelCreditName.BackColor = System.Drawing.Color.Transparent;
            this.labelCreditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelCreditName.Location = new System.Drawing.Point(12, 53);
            this.labelCreditName.Name = "labelCreditName";
            this.labelCreditName.Size = new System.Drawing.Size(92, 20);
            this.labelCreditName.TabIndex = 6;
            this.labelCreditName.Text = "creditname";
            // 
            // CreditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::scoringProject.Properties.Resources.фон1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labelCreditName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxCreditInfo);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CreditList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список кредитов";
            this.Load += new System.EventHandler(this.CreditList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxCreditInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelCreditName;
    }
}