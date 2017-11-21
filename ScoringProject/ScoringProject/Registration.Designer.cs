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
            this.textBoxPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passportData = new System.Windows.Forms.TabPage();
            this.textBoxPassportPlace = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPassportCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPassportDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPassportSeries = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contactData = new System.Windows.Forms.TabPage();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxHomeNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.educationData = new System.Windows.Forms.TabPage();
            this.checkedListBoxEducation = new System.Windows.Forms.CheckedListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.adressData = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.familyData = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.checkedListBoxFamily = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxAdressIndex = new System.Windows.Forms.TextBox();
            this.textBoxAdressRegion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxAdressCity = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxAdressArea = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxAdressCorp = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxAdressNumber = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxAdressFlat = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxAdressBuildning = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxAdressStreet = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.personalData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.passportData.SuspendLayout();
            this.contactData.SuspendLayout();
            this.educationData.SuspendLayout();
            this.adressData.SuspendLayout();
            this.familyData.SuspendLayout();
            this.SuspendLayout();
            // 
            // butComplete
            // 
            this.butComplete.Location = new System.Drawing.Point(200, 325);
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
            this.personalData.Controls.Add(this.textBoxPlaceOfBirth);
            this.personalData.Controls.Add(this.label19);
            this.personalData.Controls.Add(this.textBoxPassword);
            this.personalData.Controls.Add(this.label18);
            this.personalData.Controls.Add(this.textBoxLogin);
            this.personalData.Controls.Add(this.label16);
            this.personalData.Controls.Add(this.buttonNext);
            this.personalData.Controls.Add(this.groupBox1);
            this.personalData.Controls.Add(this.label6);
            this.personalData.Controls.Add(this.textBoxINN);
            this.personalData.Controls.Add(this.label5);
            this.personalData.Controls.Add(this.textBoxDateOfBirth);
            this.personalData.Controls.Add(this.label4);
            this.personalData.Controls.Add(this.textBoxPatronymic);
            this.personalData.Controls.Add(this.label3);
            this.personalData.Controls.Add(this.textBoxSurname);
            this.personalData.Controls.Add(this.label2);
            this.personalData.Controls.Add(this.textBoxName);
            this.personalData.Controls.Add(this.label1);
            this.personalData.Location = new System.Drawing.Point(4, 22);
            this.personalData.Name = "personalData";
            this.personalData.Padding = new System.Windows.Forms.Padding(3);
            this.personalData.Size = new System.Drawing.Size(552, 284);
            this.personalData.TabIndex = 0;
            this.personalData.Text = "Персональные данные";
            this.personalData.UseVisualStyleBackColor = true;
            // 
            // textBoxPlaceOfBirth
            // 
            this.textBoxPlaceOfBirth.Location = new System.Drawing.Point(187, 205);
            this.textBoxPlaceOfBirth.Name = "textBoxPlaceOfBirth";
            this.textBoxPlaceOfBirth.Size = new System.Drawing.Size(119, 20);
            this.textBoxPlaceOfBirth.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label19.Location = new System.Drawing.Point(16, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(156, 20);
            this.label19.TabIndex = 17;
            this.label19.Text = "Место рождения:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPassword.Location = new System.Drawing.Point(395, 55);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(151, 20);
            this.textBoxPassword.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label18.Location = new System.Drawing.Point(312, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxLogin.Location = new System.Drawing.Point(387, 19);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(159, 20);
            this.textBoxLogin.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label16.Location = new System.Drawing.Point(312, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "Логин: ";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(400, 224);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(106, 30);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.checkBoxFemale);
            this.groupBox1.Controls.Add(this.checkBoxMale);
            this.groupBox1.Location = new System.Drawing.Point(365, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 46);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(100, 13);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(73, 17);
            this.checkBoxFemale.TabIndex = 1;
            this.checkBoxFemale.Text = "Женский";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(6, 13);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(72, 17);
            this.checkBoxMale.TabIndex = 0;
            this.checkBoxMale.Text = "Мужской";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(312, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Пол:";
            // 
            // textBoxINN
            // 
            this.textBoxINN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxINN.Location = new System.Drawing.Point(73, 167);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(233, 20);
            this.textBoxINN.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(15, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ИНН:";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(172, 135);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(134, 20);
            this.textBoxDateOfBirth.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения: ";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPatronymic.Location = new System.Drawing.Point(117, 95);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(189, 20);
            this.textBoxPatronymic.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSurname.Location = new System.Drawing.Point(113, 55);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(193, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.Location = new System.Drawing.Point(68, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(238, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passportData
            // 
            this.passportData.Controls.Add(this.textBoxPassportPlace);
            this.passportData.Controls.Add(this.label11);
            this.passportData.Controls.Add(this.textBoxPassportCode);
            this.passportData.Controls.Add(this.label10);
            this.passportData.Controls.Add(this.textBoxPassportDate);
            this.passportData.Controls.Add(this.label9);
            this.passportData.Controls.Add(this.textBoxPassportNumber);
            this.passportData.Controls.Add(this.label8);
            this.passportData.Controls.Add(this.textBoxPassportSeries);
            this.passportData.Controls.Add(this.label7);
            this.passportData.Controls.Add(this.button1);
            this.passportData.Location = new System.Drawing.Point(4, 22);
            this.passportData.Name = "passportData";
            this.passportData.Padding = new System.Windows.Forms.Padding(3);
            this.passportData.Size = new System.Drawing.Size(552, 284);
            this.passportData.TabIndex = 1;
            this.passportData.Text = "Паспортные данные";
            this.passportData.UseVisualStyleBackColor = true;
            // 
            // textBoxPassportPlace
            // 
            this.textBoxPassportPlace.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassportPlace.Location = new System.Drawing.Point(128, 177);
            this.textBoxPassportPlace.Name = "textBoxPassportPlace";
            this.textBoxPassportPlace.Size = new System.Drawing.Size(295, 20);
            this.textBoxPassportPlace.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(16, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Кем выдан:";
            // 
            // textBoxPassportCode
            // 
            this.textBoxPassportCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassportCode.Location = new System.Drawing.Point(207, 135);
            this.textBoxPassportCode.Name = "textBoxPassportCode";
            this.textBoxPassportCode.Size = new System.Drawing.Size(216, 20);
            this.textBoxPassportCode.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(16, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Код подразделения:";
            // 
            // textBoxPassportDate
            // 
            this.textBoxPassportDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassportDate.Location = new System.Drawing.Point(148, 93);
            this.textBoxPassportDate.Name = "textBoxPassportDate";
            this.textBoxPassportDate.Size = new System.Drawing.Size(275, 20);
            this.textBoxPassportDate.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(16, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дата выдачи:";
            // 
            // textBoxPassportNumber
            // 
            this.textBoxPassportNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassportNumber.Location = new System.Drawing.Point(175, 55);
            this.textBoxPassportNumber.Name = "textBoxPassportNumber";
            this.textBoxPassportNumber.Size = new System.Drawing.Size(248, 20);
            this.textBoxPassportNumber.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(16, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер паспорта:";
            // 
            // textBoxPassportSeries
            // 
            this.textBoxPassportSeries.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassportSeries.Location = new System.Drawing.Point(173, 16);
            this.textBoxPassportSeries.Name = "textBoxPassportSeries";
            this.textBoxPassportSeries.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassportSeries.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Серия паспорта: ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(431, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // contactData
            // 
            this.contactData.Controls.Add(this.textBoxEmail);
            this.contactData.Controls.Add(this.label14);
            this.contactData.Controls.Add(this.textBoxHomeNumber);
            this.contactData.Controls.Add(this.label13);
            this.contactData.Controls.Add(this.textBoxPhoneNumber);
            this.contactData.Controls.Add(this.label12);
            this.contactData.Controls.Add(this.button2);
            this.contactData.Location = new System.Drawing.Point(4, 22);
            this.contactData.Name = "contactData";
            this.contactData.Padding = new System.Windows.Forms.Padding(3);
            this.contactData.Size = new System.Drawing.Size(552, 284);
            this.contactData.TabIndex = 2;
            this.contactData.Text = "Контактная информация";
            this.contactData.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmail.Location = new System.Drawing.Point(82, 125);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(344, 20);
            this.textBoxEmail.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(23, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "E-mail:";
            // 
            // textBoxHomeNumber
            // 
            this.textBoxHomeNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxHomeNumber.Location = new System.Drawing.Point(220, 72);
            this.textBoxHomeNumber.Name = "textBoxHomeNumber";
            this.textBoxHomeNumber.Size = new System.Drawing.Size(206, 20);
            this.textBoxHomeNumber.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label13.Location = new System.Drawing.Point(23, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Домашний телефон:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(220, 18);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(206, 20);
            this.textBoxPhoneNumber.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label12.Location = new System.Drawing.Point(23, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Мобильный телефон:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(431, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // educationData
            // 
            this.educationData.Controls.Add(this.checkedListBoxEducation);
            this.educationData.Controls.Add(this.label15);
            this.educationData.Controls.Add(this.button3);
            this.educationData.Location = new System.Drawing.Point(4, 22);
            this.educationData.Name = "educationData";
            this.educationData.Size = new System.Drawing.Size(552, 284);
            this.educationData.TabIndex = 3;
            this.educationData.Text = "Образование";
            this.educationData.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxEducation
            // 
            this.checkedListBoxEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkedListBoxEducation.FormattingEnabled = true;
            this.checkedListBoxEducation.Items.AddRange(new object[] {
            "Ученая степень",
            "Несколько высших",
            "Высшее",
            "Незаконченное высшее",
            "Среднее специальное",
            "Среднее",
            "Ниже среднего"});
            this.checkedListBoxEducation.Location = new System.Drawing.Point(23, 57);
            this.checkedListBoxEducation.Name = "checkedListBoxEducation";
            this.checkedListBoxEducation.Size = new System.Drawing.Size(242, 172);
            this.checkedListBoxEducation.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label15.Location = new System.Drawing.Point(19, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Образование:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Далее";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // adressData
            // 
            this.adressData.Controls.Add(this.textBoxAdressStreet);
            this.adressData.Controls.Add(this.label28);
            this.adressData.Controls.Add(this.textBoxAdressFlat);
            this.adressData.Controls.Add(this.label26);
            this.adressData.Controls.Add(this.textBoxAdressBuildning);
            this.adressData.Controls.Add(this.label27);
            this.adressData.Controls.Add(this.textBoxAdressCorp);
            this.adressData.Controls.Add(this.label24);
            this.adressData.Controls.Add(this.textBoxAdressNumber);
            this.adressData.Controls.Add(this.label25);
            this.adressData.Controls.Add(this.textBoxAdressCity);
            this.adressData.Controls.Add(this.label22);
            this.adressData.Controls.Add(this.textBoxAdressArea);
            this.adressData.Controls.Add(this.label23);
            this.adressData.Controls.Add(this.textBoxAdressRegion);
            this.adressData.Controls.Add(this.label21);
            this.adressData.Controls.Add(this.textBoxAdressIndex);
            this.adressData.Controls.Add(this.label20);
            this.adressData.Controls.Add(this.button4);
            this.adressData.Location = new System.Drawing.Point(4, 22);
            this.adressData.Name = "adressData";
            this.adressData.Size = new System.Drawing.Size(552, 284);
            this.adressData.TabIndex = 4;
            this.adressData.Text = "Адрес";
            this.adressData.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 30);
            this.button4.TabIndex = 13;
            this.button4.Text = "Далее";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // familyData
            // 
            this.familyData.Controls.Add(this.label17);
            this.familyData.Controls.Add(this.checkedListBoxFamily);
            this.familyData.Location = new System.Drawing.Point(4, 22);
            this.familyData.Name = "familyData";
            this.familyData.Size = new System.Drawing.Size(552, 284);
            this.familyData.TabIndex = 5;
            this.familyData.Text = "Семья";
            this.familyData.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label17.Location = new System.Drawing.Point(18, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Семейное положение:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // checkedListBoxFamily
            // 
            this.checkedListBoxFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkedListBoxFamily.FormattingEnabled = true;
            this.checkedListBoxFamily.Items.AddRange(new object[] {
            "Женат/Замужен",
            "Холост/Не замужем",
            "Гражданский брак",
            "Разведен/Разведена",
            "Вдова/Вдовец"});
            this.checkedListBoxFamily.Location = new System.Drawing.Point(18, 71);
            this.checkedListBoxFamily.Name = "checkedListBoxFamily";
            this.checkedListBoxFamily.Size = new System.Drawing.Size(298, 151);
            this.checkedListBoxFamily.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label20.Location = new System.Drawing.Point(13, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "Индекс";
            // 
            // textBoxAdressIndex
            // 
            this.textBoxAdressIndex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAdressIndex.Location = new System.Drawing.Point(81, 19);
            this.textBoxAdressIndex.Name = "textBoxAdressIndex";
            this.textBoxAdressIndex.Size = new System.Drawing.Size(222, 20);
            this.textBoxAdressIndex.TabIndex = 15;
            // 
            // textBoxAdressRegion
            // 
            this.textBoxAdressRegion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAdressRegion.Location = new System.Drawing.Point(207, 58);
            this.textBoxAdressRegion.Name = "textBoxAdressRegion";
            this.textBoxAdressRegion.Size = new System.Drawing.Size(96, 20);
            this.textBoxAdressRegion.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label21.Location = new System.Drawing.Point(13, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(188, 20);
            this.label21.TabIndex = 16;
            this.label21.Text = "Область/регион/край";
            // 
            // textBoxAdressCity
            // 
            this.textBoxAdressCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAdressCity.Location = new System.Drawing.Point(153, 143);
            this.textBoxAdressCity.Name = "textBoxAdressCity";
            this.textBoxAdressCity.Size = new System.Drawing.Size(150, 20);
            this.textBoxAdressCity.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label22.Location = new System.Drawing.Point(13, 141);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(134, 20);
            this.label22.TabIndex = 20;
            this.label22.Text = "Город/поселок";
            // 
            // textBoxAdressArea
            // 
            this.textBoxAdressArea.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAdressArea.Location = new System.Drawing.Point(81, 102);
            this.textBoxAdressArea.Name = "textBoxAdressArea";
            this.textBoxAdressArea.Size = new System.Drawing.Size(222, 20);
            this.textBoxAdressArea.TabIndex = 19;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label23.Location = new System.Drawing.Point(13, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 20);
            this.label23.TabIndex = 18;
            this.label23.Text = "Район";
            // 
            // textBoxAdressCorp
            // 
            this.textBoxAdressCorp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxAdressCorp.Location = new System.Drawing.Point(391, 58);
            this.textBoxAdressCorp.Name = "textBoxAdressCorp";
            this.textBoxAdressCorp.Size = new System.Drawing.Size(138, 20);
            this.textBoxAdressCorp.TabIndex = 25;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label24.Location = new System.Drawing.Point(309, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 20);
            this.label24.TabIndex = 24;
            this.label24.Text = "Корпус";
            // 
            // textBoxAdressNumber
            // 
            this.textBoxAdressNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxAdressNumber.Location = new System.Drawing.Point(433, 19);
            this.textBoxAdressNumber.Name = "textBoxAdressNumber";
            this.textBoxAdressNumber.Size = new System.Drawing.Size(96, 20);
            this.textBoxAdressNumber.TabIndex = 23;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label25.Location = new System.Drawing.Point(309, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 20);
            this.label25.TabIndex = 22;
            this.label25.Text = "Номер дома";
            // 
            // textBoxAdressFlat
            // 
            this.textBoxAdressFlat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxAdressFlat.Location = new System.Drawing.Point(405, 143);
            this.textBoxAdressFlat.Name = "textBoxAdressFlat";
            this.textBoxAdressFlat.Size = new System.Drawing.Size(124, 20);
            this.textBoxAdressFlat.TabIndex = 29;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label26.Location = new System.Drawing.Point(309, 139);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 20);
            this.label26.TabIndex = 28;
            this.label26.Text = "Квартира";
            // 
            // textBoxAdressBuildning
            // 
            this.textBoxAdressBuildning.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxAdressBuildning.Location = new System.Drawing.Point(406, 98);
            this.textBoxAdressBuildning.Name = "textBoxAdressBuildning";
            this.textBoxAdressBuildning.Size = new System.Drawing.Size(123, 20);
            this.textBoxAdressBuildning.TabIndex = 27;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label27.Location = new System.Drawing.Point(309, 98);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 20);
            this.label27.TabIndex = 26;
            this.label27.Text = "Строение";
            // 
            // textBoxAdressStreet
            // 
            this.textBoxAdressStreet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAdressStreet.Location = new System.Drawing.Point(81, 185);
            this.textBoxAdressStreet.Name = "textBoxAdressStreet";
            this.textBoxAdressStreet.Size = new System.Drawing.Size(222, 20);
            this.textBoxAdressStreet.TabIndex = 31;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label28.Location = new System.Drawing.Point(13, 185);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 20);
            this.label28.TabIndex = 30;
            this.label28.Text = "Улица";
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
            this.personalData.ResumeLayout(false);
            this.personalData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.passportData.ResumeLayout(false);
            this.passportData.PerformLayout();
            this.contactData.ResumeLayout(false);
            this.contactData.PerformLayout();
            this.educationData.ResumeLayout(false);
            this.educationData.PerformLayout();
            this.adressData.ResumeLayout(false);
            this.adressData.PerformLayout();
            this.familyData.ResumeLayout(false);
            this.familyData.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxPassportPlace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPassportCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPassportDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPassportNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPassportSeries;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxHomeNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox checkedListBoxEducation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckedListBox checkedListBoxFamily;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPlaceOfBirth;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxAdressStreet;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxAdressFlat;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxAdressBuildning;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxAdressCorp;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxAdressNumber;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxAdressCity;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxAdressArea;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxAdressRegion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxAdressIndex;
        private System.Windows.Forms.Label label20;
    }
}