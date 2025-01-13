namespace WindowsFormsApplication1
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
            this.username_label = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.signingIn = new System.Windows.Forms.Button();
            this.registeration = new System.Windows.Forms.Button();
            this.changePassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.Location = new System.Drawing.Point(12, 91);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(60, 20);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "User Name";
            this.username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(97, 88);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(175, 20);
            this.UserNameTB.TabIndex = 1;
            this.UserNameTB.TextChanged += new System.EventHandler(this.UserNameTB_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(46, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(101, 13);
            this.title.TabIndex = 2;
            this.title.Text = "Banking Application";
            this.title.Click += new System.EventHandler(this.label2_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(12, 141);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(97, 134);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(175, 20);
            this.PasswordTB.TabIndex = 4;
            this.PasswordTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // signingIn
            // 
            this.signingIn.Location = new System.Drawing.Point(102, 209);
            this.signingIn.Name = "signingIn";
            this.signingIn.Size = new System.Drawing.Size(89, 31);
            this.signingIn.TabIndex = 5;
            this.signingIn.Text = "Sign In";
            this.signingIn.UseVisualStyleBackColor = true;
            this.signingIn.Click += new System.EventHandler(this.signingIn_Click);
            // 
            // registeration
            // 
            this.registeration.Location = new System.Drawing.Point(12, 209);
            this.registeration.Name = "registeration";
            this.registeration.Size = new System.Drawing.Size(84, 31);
            this.registeration.TabIndex = 6;
            this.registeration.Text = "Register";
            this.registeration.UseVisualStyleBackColor = true;
            this.registeration.Click += new System.EventHandler(this.registeration_Click);
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(210, 209);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(103, 31);
            this.changePassButton.TabIndex = 7;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 291);
            this.Controls.Add(this.changePassButton);
            this.Controls.Add(this.registeration);
            this.Controls.Add(this.signingIn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.username_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button signingIn;
        private System.Windows.Forms.Button registeration;
        private System.Windows.Forms.Button changePassButton;
    }
}

