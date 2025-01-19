namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.uName_ChangePass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.currPass_changePass = new System.Windows.Forms.Label();
            this.newPass_changePass = new System.Windows.Forms.Label();
            this.confirm_changePass = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uName_ChangePass
            // 
            this.uName_ChangePass.AutoSize = true;
            this.uName_ChangePass.Location = new System.Drawing.Point(32, 41);
            this.uName_ChangePass.Name = "uName_ChangePass";
            this.uName_ChangePass.Size = new System.Drawing.Size(66, 13);
            this.uName_ChangePass.TabIndex = 0;
            this.uName_ChangePass.Text = "User Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 1;
            // 
            // currPass_changePass
            // 
            this.currPass_changePass.Location = new System.Drawing.Point(32, 84);
            this.currPass_changePass.Name = "currPass_changePass";
            this.currPass_changePass.Size = new System.Drawing.Size(66, 41);
            this.currPass_changePass.TabIndex = 2;
            this.currPass_changePass.Text = "Current Password: ";
            this.currPass_changePass.Click += new System.EventHandler(this.label1_Click);
            // 
            // newPass_changePass
            // 
            this.newPass_changePass.Location = new System.Drawing.Point(32, 137);
            this.newPass_changePass.Name = "newPass_changePass";
            this.newPass_changePass.Size = new System.Drawing.Size(66, 36);
            this.newPass_changePass.TabIndex = 3;
            this.newPass_changePass.Text = "New Password: ";
            this.newPass_changePass.Click += new System.EventHandler(this.label2_Click);
            // 
            // confirm_changePass
            // 
            this.confirm_changePass.Location = new System.Drawing.Point(108, 193);
            this.confirm_changePass.Name = "confirm_changePass";
            this.confirm_changePass.Size = new System.Drawing.Size(75, 23);
            this.confirm_changePass.TabIndex = 4;
            this.confirm_changePass.Text = "Confirm";
            this.confirm_changePass.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.confirm_changePass);
            this.Controls.Add(this.newPass_changePass);
            this.Controls.Add(this.currPass_changePass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uName_ChangePass);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uName_ChangePass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label currPass_changePass;
        private System.Windows.Forms.Label newPass_changePass;
        private System.Windows.Forms.Button confirm_changePass;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}