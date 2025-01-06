using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private DateTime selectedDOB;
        private Label phoneErrorLabel;
        private Label aadhaarErrorLabel;
        private string sex = "Not specified";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxregNoinp.Visible = false;
            textBoxappNoInp.Visible = false;
            regNoInp.Visible = false;
            appNoInp.Visible = false;

            phoneErrorLabel = new Label();
            aadhaarErrorLabel = new Label();

            phoneErrorLabel.ForeColor = Color.Red;
            aadhaarErrorLabel.ForeColor = Color.Red;

            phoneErrorLabel.Visible = false;
            aadhaarErrorLabel.Visible = false;

            this.Controls.Add(phoneErrorLabel);
            this.Controls.Add(aadhaarErrorLabel);

            aaNumBox.Location = new Point(106, 50); 
            aaNumBox.Size = new Size(187, 20);      

            
            aaNumBox.Margin = new Padding(3, 3, 3, 3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (confirm1.Checked)
            {
                
                string name = string.IsNullOrEmpty(textBoxName.Text) ? "Name not provided" : textBoxName.Text;
                string regNo = textBoxregNoinp.Visible ?
                               (string.IsNullOrEmpty(textBoxregNoinp.Text) ? "Registration No not provided" : textBoxregNoinp.Text) :
                               "Registration No not provided";
                string appNo = textBoxappNoInp.Visible ?
                               (string.IsNullOrEmpty(textBoxappNoInp.Text) ? "Application No not provided" : textBoxappNoInp.Text) :
                               "Application No not provided";

                string dob = selectedDOB != default(DateTime) ? selectedDOB.ToShortDateString() : "DOB not provided";
                string selectedOption = comboBoxBranch.SelectedItem as string ?? "No option selected";
                
                string details = "Name: " + name + "\n" +
                                 "Registration No: " + regNo + "\n" +
                                 "Gender: " + sex + "\n" +
                                 "Application No: " + appNo + "\n" +
                                 "Date of Birth: " + dob + "\n" +
                                 "Selected Branch: " + selectedOption;

                details += "\nPhone Number: " + (textBox1.Text.Length == 10 ? textBox1.Text : "Invalid phone number");
                details += "\nAadhaar Number: " + (aaNumBox.Text.Length == 12 ? aaNumBox.Text : "Invalid Aadhaar number");

                MessageBox.Show(details, "Entered Details");

            }
            else
            {
               
                MessageBox.Show("Confirmation missing. Please confirm the details before proceeding.", "Confirmation Pending");
            }
        }

        private void RegNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
               sex = "Male";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFemale.Checked)
            {
                sex = "Female";
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDOB = e.Start; 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOther.Checked)
            {
                sex = "Other";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (appNo.Checked)
            {
                textBoxappNoInp.Visible = true;
                appNoInp.Visible = true;
            }
            else
            {
                textBoxappNoInp.Visible = false;
                appNoInp.Visible = false;
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void regNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (regNo.Checked)
            {
                textBoxregNoinp.Visible = true;
                regNoInp.Visible = true;
            }
            else
            {
                textBoxregNoinp.Visible = false;
                regNoInp.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = textBox1.Text;
            if (phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit))
            {
                phoneErrorLabel.Visible = false;
            }
            else
            {
                phoneErrorLabel.Text = "Invalid phone number. Must be 10 digits.";
                phoneErrorLabel.Visible = true;
                phoneErrorLabel.Location = new Point(textBox1.Left, textBox1.Bottom + 5); 
            }
        }

        private void confirm1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string aadhaarNumber = aaNumBox.Text;
            if (aadhaarNumber.Length == 12 && aadhaarNumber.All(char.IsDigit))
            {
                aadhaarErrorLabel.Visible = false;
            }
            else
            {
                
                aadhaarErrorLabel.Text = "Invalid Aadhaar number. Must be 12 digits.";
                aadhaarErrorLabel.Visible = true;
                aadhaarErrorLabel.Location = new Point(aaNumBox.Left + 3, aaNumBox.Bottom + 3);
            }
        }
    }
}
