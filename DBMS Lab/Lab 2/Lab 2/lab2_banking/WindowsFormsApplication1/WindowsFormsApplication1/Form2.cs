using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2(string userName)
        {
            InitializeComponent();
            this.Text = "User Dashboard";
            uName_Val.Text = userName;
            AppendBalance();
            setCurrDate();
            LastVisit();  
        }
        private void AppendBalance()
        {
            Random rand = new Random();

            // Generate a random number between 1000 and 100 billion (100,000,000,000)
            long Balance = (long)(rand.NextDouble() * (100000000000L - 1000) + 1000); // Ensure you use 'L' for long literals

            // Use string interpolation and format the number with commas (thousands separator)
            balanceVal.Text = String.Format("${0:N0}", Balance);

        }
        private void LastVisit()
        {
            DateTime today = DateTime.Now;
            DateTime maxBoundary = today.AddDays(-21);
            Random rand = new Random();
            int randDay = rand.Next(0, 22);
            DateTime LVdate = maxBoundary.AddDays(randDay);
            LADate_Val.Text = LVdate.ToString("dd/MM/yyy");

        }
        private void setCurrDate() {
            DateVal.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void transfer_button_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void uName_Val_Click(object sender, EventArgs e)
        {

        }

        private void balanceVal_Click(object sender, EventArgs e)
        {

        }

        private void DateVal_Click(object sender, EventArgs e)
        {

        }

        private void LADate_Val_Click(object sender, EventArgs e)
        {

        }
    }
}
