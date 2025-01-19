namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.uName_disp = new System.Windows.Forms.Label();
            this.balance_disp = new System.Windows.Forms.Label();
            this.date_disp = new System.Windows.Forms.Label();
            this.lAccess_disp = new System.Windows.Forms.Label();
            this.last5Trans_disp = new System.Windows.Forms.Label();
            this.transfer_button = new System.Windows.Forms.Button();
            this.uName_Val = new System.Windows.Forms.Label();
            this.balanceVal = new System.Windows.Forms.Label();
            this.DateVal = new System.Windows.Forms.Label();
            this.LADate_Val = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uName_disp
            // 
            this.uName_disp.AutoSize = true;
            this.uName_disp.Location = new System.Drawing.Point(30, 53);
            this.uName_disp.Name = "uName_disp";
            this.uName_disp.Size = new System.Drawing.Size(66, 13);
            this.uName_disp.TabIndex = 0;
            this.uName_disp.Text = "User Name: ";
            // 
            // balance_disp
            // 
            this.balance_disp.AutoSize = true;
            this.balance_disp.Location = new System.Drawing.Point(30, 84);
            this.balance_disp.Name = "balance_disp";
            this.balance_disp.Size = new System.Drawing.Size(52, 13);
            this.balance_disp.TabIndex = 1;
            this.balance_disp.Text = "Balance: ";
            // 
            // date_disp
            // 
            this.date_disp.AutoSize = true;
            this.date_disp.Location = new System.Drawing.Point(2, 9);
            this.date_disp.Name = "date_disp";
            this.date_disp.Size = new System.Drawing.Size(36, 13);
            this.date_disp.TabIndex = 2;
            this.date_disp.Text = "Date: ";
            // 
            // lAccess_disp
            // 
            this.lAccess_disp.AutoSize = true;
            this.lAccess_disp.Location = new System.Drawing.Point(30, 115);
            this.lAccess_disp.Name = "lAccess_disp";
            this.lAccess_disp.Size = new System.Drawing.Size(71, 13);
            this.lAccess_disp.TabIndex = 3;
            this.lAccess_disp.Text = "Last Access: ";
            // 
            // last5Trans_disp
            // 
            this.last5Trans_disp.AutoSize = true;
            this.last5Trans_disp.Location = new System.Drawing.Point(30, 149);
            this.last5Trans_disp.Name = "last5Trans_disp";
            this.last5Trans_disp.Size = new System.Drawing.Size(95, 13);
            this.last5Trans_disp.TabIndex = 4;
            this.last5Trans_disp.Text = "Last 5 Transaction";
            // 
            // transfer_button
            // 
            this.transfer_button.Location = new System.Drawing.Point(162, 333);
            this.transfer_button.Name = "transfer_button";
            this.transfer_button.Size = new System.Drawing.Size(75, 23);
            this.transfer_button.TabIndex = 5;
            this.transfer_button.Text = "Transfer Money";
            this.transfer_button.UseVisualStyleBackColor = true;
            this.transfer_button.Click += new System.EventHandler(this.transfer_button_Click);
            // 
            // uName_Val
            // 
            this.uName_Val.AutoSize = true;
            this.uName_Val.Location = new System.Drawing.Point(113, 53);
            this.uName_Val.Name = "uName_Val";
            this.uName_Val.Size = new System.Drawing.Size(53, 13);
            this.uName_Val.TabIndex = 6;
            this.uName_Val.Text = "Jane Doe";
            this.uName_Val.Click += new System.EventHandler(this.uName_Val_Click);
            // 
            // balanceVal
            // 
            this.balanceVal.AutoSize = true;
            this.balanceVal.Location = new System.Drawing.Point(113, 84);
            this.balanceVal.Name = "balanceVal";
            this.balanceVal.Size = new System.Drawing.Size(16, 13);
            this.balanceVal.TabIndex = 7;
            this.balanceVal.Text = "$ ";
            this.balanceVal.Click += new System.EventHandler(this.balanceVal_Click);
            // 
            // DateVal
            // 
            this.DateVal.AutoSize = true;
            this.DateVal.Location = new System.Drawing.Point(61, 9);
            this.DateVal.Name = "DateVal";
            this.DateVal.Size = new System.Drawing.Size(61, 13);
            this.DateVal.TabIndex = 8;
            this.DateVal.Text = "01-01-1970";
            this.DateVal.Click += new System.EventHandler(this.DateVal_Click);
            // 
            // LADate_Val
            // 
            this.LADate_Val.AutoSize = true;
            this.LADate_Val.Location = new System.Drawing.Point(113, 115);
            this.LADate_Val.Name = "LADate_Val";
            this.LADate_Val.Size = new System.Drawing.Size(61, 13);
            this.LADate_Val.TabIndex = 9;
            this.LADate_Val.Text = "01-01-1970";
            this.LADate_Val.Click += new System.EventHandler(this.LADate_Val_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 368);
            this.Controls.Add(this.LADate_Val);
            this.Controls.Add(this.DateVal);
            this.Controls.Add(this.balanceVal);
            this.Controls.Add(this.uName_Val);
            this.Controls.Add(this.transfer_button);
            this.Controls.Add(this.last5Trans_disp);
            this.Controls.Add(this.lAccess_disp);
            this.Controls.Add(this.date_disp);
            this.Controls.Add(this.balance_disp);
            this.Controls.Add(this.uName_disp);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uName_disp;
        private System.Windows.Forms.Label balance_disp;
        private System.Windows.Forms.Label date_disp;
        private System.Windows.Forms.Label lAccess_disp;
        private System.Windows.Forms.Label last5Trans_disp;
        private System.Windows.Forms.Button transfer_button;
        private System.Windows.Forms.Label uName_Val;
        private System.Windows.Forms.Label balanceVal;
        private System.Windows.Forms.Label DateVal;
        private System.Windows.Forms.Label LADate_Val;
    }
}