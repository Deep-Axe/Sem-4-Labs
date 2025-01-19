namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.uNameReg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pass_reg = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BranchReg = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uNameReg
            // 
            this.uNameReg.AutoSize = true;
            this.uNameReg.Location = new System.Drawing.Point(12, 29);
            this.uNameReg.Name = "uNameReg";
            this.uNameReg.Size = new System.Drawing.Size(66, 13);
            this.uNameReg.TabIndex = 0;
            this.uNameReg.Text = "User Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pass_reg
            // 
            this.pass_reg.AutoSize = true;
            this.pass_reg.Location = new System.Drawing.Point(12, 68);
            this.pass_reg.Name = "pass_reg";
            this.pass_reg.Size = new System.Drawing.Size(59, 13);
            this.pass_reg.TabIndex = 2;
            this.pass_reg.Text = "Password: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirm Password: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 5;
            // 
            // BranchReg
            // 
            this.BranchReg.AutoSize = true;
            this.BranchReg.Location = new System.Drawing.Point(12, 164);
            this.BranchReg.Name = "BranchReg";
            this.BranchReg.Size = new System.Drawing.Size(47, 13);
            this.BranchReg.TabIndex = 6;
            this.BranchReg.Text = "Branch: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bengaluru",
            "Manipal",
            "Mumbai",
            "Chandigarh",
            "Delhi NCR",
            "Chennai"});
            this.comboBox1.Location = new System.Drawing.Point(85, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(85, 215);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 8;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BranchReg);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pass_reg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uNameReg);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uNameReg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pass_reg;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label BranchReg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button regButton;
    }
}