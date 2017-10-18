namespace scoringProject
{
    partial class ClientPage
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
            this.butBackToLogin = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // butBackToLogin
            // 
            this.butBackToLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butBackToLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.butBackToLogin.Location = new System.Drawing.Point(470, 321);
            this.butBackToLogin.Name = "butBackToLogin";
            this.butBackToLogin.Size = new System.Drawing.Size(102, 28);
            this.butBackToLogin.TabIndex = 1;
            this.butBackToLogin.Text = "To Login/Password";
            this.butBackToLogin.Click += new System.EventHandler(this.butBackToLogin_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(239, 315);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(231, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Credit List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(231, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Credit History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(257, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 27);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Test";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сведения о кредитах";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.butBackToLogin);
            this.Name = "ClientPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientPage";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton butBackToLogin;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Button button1;
    }
}