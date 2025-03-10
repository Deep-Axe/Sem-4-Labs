namespace WindowsFormsApplication1
{
    partial class student_data
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.rollNoTB = new System.Windows.Forms.TextBox();
            this.CourseTB = new System.Windows.Forms.TextBox();
            this.CGPATb = new System.Windows.Forms.TextBox();
            this.roll_no = new System.Windows.Forms.Label();
            this.course_name = new System.Windows.Forms.Label();
            this.cgpa = new System.Windows.Forms.Label();
            this.save_but = new System.Windows.Forms.Button();
            this.update_but = new System.Windows.Forms.Button();
            this.prev_but = new System.Windows.Forms.Button();
            this.close_but = new System.Windows.Forms.Button();
            this.next_but = new System.Windows.Forms.Button();
            this.show_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(54, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name : ";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(104, 53);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 1;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // rollNoTB
            // 
            this.rollNoTB.Location = new System.Drawing.Point(104, 85);
            this.rollNoTB.Name = "rollNoTB";
            this.rollNoTB.Size = new System.Drawing.Size(100, 20);
            this.rollNoTB.TabIndex = 2;
            this.rollNoTB.TextChanged += new System.EventHandler(this.rollNoTB_TextChanged);
            // 
            // CourseTB
            // 
            this.CourseTB.Location = new System.Drawing.Point(104, 139);
            this.CourseTB.Name = "CourseTB";
            this.CourseTB.Size = new System.Drawing.Size(100, 20);
            this.CourseTB.TabIndex = 3;
            this.CourseTB.TextChanged += new System.EventHandler(this.CourseTB_TextChanged);
            // 
            // CGPATb
            // 
            this.CGPATb.Location = new System.Drawing.Point(104, 171);
            this.CGPATb.Name = "CGPATb";
            this.CGPATb.Size = new System.Drawing.Size(100, 20);
            this.CGPATb.TabIndex = 4;
            this.CGPATb.TextChanged += new System.EventHandler(this.CGPATb_TextChanged);
            // 
            // roll_no
            // 
            this.roll_no.AutoSize = true;
            this.roll_no.Location = new System.Drawing.Point(47, 92);
            this.roll_no.Name = "roll_no";
            this.roll_no.Size = new System.Drawing.Size(51, 13);
            this.roll_no.TabIndex = 5;
            this.roll_no.Text = "Roll No. :";
            this.roll_no.Click += new System.EventHandler(this.roll_no_Click);
            // 
            // course_name
            // 
            this.course_name.AutoSize = true;
            this.course_name.Location = new System.Drawing.Point(57, 145);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(43, 13);
            this.course_name.TabIndex = 6;
            this.course_name.Text = "Course:";
            this.course_name.Click += new System.EventHandler(this.course_name_Click);
            // 
            // cgpa
            // 
            this.cgpa.AutoSize = true;
            this.cgpa.Location = new System.Drawing.Point(56, 174);
            this.cgpa.Name = "cgpa";
            this.cgpa.Size = new System.Drawing.Size(42, 13);
            this.cgpa.TabIndex = 7;
            this.cgpa.Text = "CGPA :";
            this.cgpa.Click += new System.EventHandler(this.cgpa_Click);
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(112, 224);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(77, 23);
            this.save_but.TabIndex = 8;
            this.save_but.Text = "Save";
            this.save_but.UseVisualStyleBackColor = true;
            // 
            // update_but
            // 
            this.update_but.Location = new System.Drawing.Point(26, 224);
            this.update_but.Name = "update_but";
            this.update_but.Size = new System.Drawing.Size(74, 23);
            this.update_but.TabIndex = 9;
            this.update_but.Text = "Update";
            this.update_but.UseVisualStyleBackColor = true;
            this.update_but.Click += new System.EventHandler(this.update_but_Click);
            // 
            // prev_but
            // 
            this.prev_but.Location = new System.Drawing.Point(12, 272);
            this.prev_but.Name = "prev_but";
            this.prev_but.Size = new System.Drawing.Size(75, 23);
            this.prev_but.TabIndex = 10;
            this.prev_but.Text = "Previous";
            this.prev_but.UseVisualStyleBackColor = true;
            // 
            // close_but
            // 
            this.close_but.Location = new System.Drawing.Point(114, 272);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(75, 23);
            this.close_but.TabIndex = 11;
            this.close_but.Text = "Close";
            this.close_but.UseVisualStyleBackColor = true;
            // 
            // next_but
            // 
            this.next_but.Location = new System.Drawing.Point(211, 272);
            this.next_but.Name = "next_but";
            this.next_but.Size = new System.Drawing.Size(75, 23);
            this.next_but.TabIndex = 12;
            this.next_but.Text = "Next";
            this.next_but.UseVisualStyleBackColor = true;
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(211, 224);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 23);
            this.show_button.TabIndex = 13;
            this.show_button.Text = "Show";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // student_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 325);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.next_but);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.prev_but);
            this.Controls.Add(this.update_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.cgpa);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.roll_no);
            this.Controls.Add(this.CGPATb);
            this.Controls.Add(this.CourseTB);
            this.Controls.Add(this.rollNoTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.name);
            this.Name = "student_data";
            this.Text = "Student Data";
            this.Load += new System.EventHandler(this.student_data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox rollNoTB;
        private System.Windows.Forms.TextBox CourseTB;
        private System.Windows.Forms.TextBox CGPATb;
        private System.Windows.Forms.Label roll_no;
        private System.Windows.Forms.Label course_name;
        private System.Windows.Forms.Label cgpa;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Button update_but;
        private System.Windows.Forms.Button prev_but;
        private System.Windows.Forms.Button close_but;
        private System.Windows.Forms.Button next_but;
        private System.Windows.Forms.Button show_button;
    }
}

