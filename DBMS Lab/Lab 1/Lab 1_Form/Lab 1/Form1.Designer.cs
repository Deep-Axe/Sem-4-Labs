namespace Lab_1
{
    partial class Form1
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
            this.name = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.branch = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.regNo = new System.Windows.Forms.CheckBox();
            this.appNo = new System.Windows.Forms.CheckBox();
            this.regNoInp = new System.Windows.Forms.Label();
            this.appNoInp = new System.Windows.Forms.Label();
            this.textBoxregNoinp = new System.Windows.Forms.TextBox();
            this.textBoxappNoInp = new System.Windows.Forms.TextBox();
            this.pNo = new System.Windows.Forms.Label();
            this.aNo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aaNumBox = new System.Windows.Forms.TextBox();
            this.pDeet = new System.Windows.Forms.GroupBox();
            this.confirm1 = new System.Windows.Forms.RadioButton();
            this.pDeet.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(28, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(275, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(108, 76);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 3;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.RegNo_CheckedChanged);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Items.AddRange(new object[] {
            "CSE",
            "CSE-AI/ML",
            "DSE",
            "CCE",
            "IT",
            "MnC",
            "CS-FT",
            "Mechanical",
            "MechX",
            "ECE",
            "EEE",
            "ENI",
            "EEE-VLSI"});
            this.comboBoxBranch.Location = new System.Drawing.Point(108, 284);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBranch.TabIndex = 4;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(28, 76);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 6;
            this.gender.Text = "Gender";
            this.gender.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(182, 76);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 7;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(265, 76);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(51, 17);
            this.radioButtonOther.TabIndex = 8;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            this.radioButtonOther.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(108, 104);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Location = new System.Drawing.Point(28, 284);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(41, 13);
            this.branch.TabIndex = 10;
            this.branch.Text = "Branch";
            this.branch.Click += new System.EventHandler(this.label3_Click);
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(28, 104);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(68, 13);
            this.dob.TabIndex = 11;
            this.dob.Text = "Date Of Birth";
            this.dob.Click += new System.EventHandler(this.label4_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(28, 330);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(55, 13);
            this.id.TabIndex = 12;
            this.id.Text = "Unique ID";
            // 
            // regNo
            // 
            this.regNo.AutoSize = true;
            this.regNo.Location = new System.Drawing.Point(108, 329);
            this.regNo.Name = "regNo";
            this.regNo.Size = new System.Drawing.Size(128, 17);
            this.regNo.TabIndex = 13;
            this.regNo.Text = "Registeration Number";
            this.regNo.UseVisualStyleBackColor = true;
            this.regNo.CheckedChanged += new System.EventHandler(this.regNo_CheckedChanged_1);
            // 
            // appNo
            // 
            this.appNo.AutoSize = true;
            this.appNo.Location = new System.Drawing.Point(242, 328);
            this.appNo.Name = "appNo";
            this.appNo.Size = new System.Drawing.Size(118, 17);
            this.appNo.TabIndex = 14;
            this.appNo.Text = "Application Number";
            this.appNo.UseVisualStyleBackColor = true;
            this.appNo.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // regNoInp
            // 
            this.regNoInp.AutoSize = true;
            this.regNoInp.Location = new System.Drawing.Point(28, 362);
            this.regNoInp.Name = "regNoInp";
            this.regNoInp.Size = new System.Drawing.Size(112, 13);
            this.regNoInp.TabIndex = 17;
            this.regNoInp.Text = "Registeration Number:";
            this.regNoInp.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // appNoInp
            // 
            this.appNoInp.AutoSize = true;
            this.appNoInp.Location = new System.Drawing.Point(28, 385);
            this.appNoInp.Name = "appNoInp";
            this.appNoInp.Size = new System.Drawing.Size(102, 13);
            this.appNoInp.TabIndex = 18;
            this.appNoInp.Text = "Application Number:";
            this.appNoInp.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // textBoxregNoinp
            // 
            this.textBoxregNoinp.Location = new System.Drawing.Point(147, 359);
            this.textBoxregNoinp.Name = "textBoxregNoinp";
            this.textBoxregNoinp.Size = new System.Drawing.Size(148, 20);
            this.textBoxregNoinp.TabIndex = 19;
            // 
            // textBoxappNoInp
            // 
            this.textBoxappNoInp.Location = new System.Drawing.Point(147, 385);
            this.textBoxappNoInp.Name = "textBoxappNoInp";
            this.textBoxappNoInp.Size = new System.Drawing.Size(148, 20);
            this.textBoxappNoInp.TabIndex = 20;
            this.textBoxappNoInp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pNo
            // 
            this.pNo.AutoSize = true;
            this.pNo.Location = new System.Drawing.Point(22, 31);
            this.pNo.Name = "pNo";
            this.pNo.Size = new System.Drawing.Size(78, 13);
            this.pNo.TabIndex = 22;
            this.pNo.Text = "Phone Number";
            this.pNo.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // aNo
            // 
            this.aNo.AutoSize = true;
            this.aNo.Location = new System.Drawing.Point(22, 57);
            this.aNo.Name = "aNo";
            this.aNo.Size = new System.Drawing.Size(81, 13);
            this.aNo.TabIndex = 23;
            this.aNo.Text = "Aadhar Number";
            this.aNo.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aaNumBox
            // 
            this.aaNumBox.Location = new System.Drawing.Point(106, 50);
            this.aaNumBox.Name = "aaNumBox";
            this.aaNumBox.Size = new System.Drawing.Size(187, 20);
            this.aaNumBox.TabIndex = 25;
            this.aaNumBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // pDeet
            // 
            this.pDeet.Controls.Add(this.aaNumBox);
            this.pDeet.Controls.Add(this.textBox1);
            this.pDeet.Controls.Add(this.aNo);
            this.pDeet.Controls.Add(this.pNo);
            this.pDeet.Location = new System.Drawing.Point(31, 433);
            this.pDeet.Name = "pDeet";
            this.pDeet.Size = new System.Drawing.Size(327, 83);
            this.pDeet.TabIndex = 27;
            this.pDeet.TabStop = false;
            this.pDeet.Text = "Personal Details";
            this.pDeet.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // confirm1
            // 
            this.confirm1.AutoSize = true;
            this.confirm1.Location = new System.Drawing.Point(147, 522);
            this.confirm1.Name = "confirm1";
            this.confirm1.Size = new System.Drawing.Size(138, 17);
            this.confirm1.TabIndex = 26;
            this.confirm1.TabStop = true;
            this.confirm1.Text = "Confirmation to register!!";
            this.confirm1.UseVisualStyleBackColor = true;
            this.confirm1.CheckedChanged += new System.EventHandler(this.confirm1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 580);
            this.Controls.Add(this.confirm1);
            this.Controls.Add(this.pDeet);
            this.Controls.Add(this.textBoxappNoInp);
            this.Controls.Add(this.textBoxregNoinp);
            this.Controls.Add(this.appNoInp);
            this.Controls.Add(this.regNoInp);
            this.Controls.Add(this.appNo);
            this.Controls.Add(this.regNo);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.radioButtonOther);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Lab 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pDeet.ResumeLayout(false);
            this.pDeet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.CheckBox regNo;
        private System.Windows.Forms.CheckBox appNo;
        private System.Windows.Forms.Label regNoInp;
        private System.Windows.Forms.Label appNoInp;
        private System.Windows.Forms.TextBox textBoxregNoinp;
        private System.Windows.Forms.TextBox textBoxappNoInp;
        private System.Windows.Forms.Label pNo;
        private System.Windows.Forms.Label aNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox aaNumBox;
        private System.Windows.Forms.GroupBox pDeet;
        private System.Windows.Forms.RadioButton confirm1;

    }
}

