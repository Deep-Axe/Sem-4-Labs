using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.DataAccess.Types; 


namespace WindowsFormsApplication1
{
    public partial class student_data : Form
    {
        DataRow dr;
        DataSet ds;
        DataTable dt;
        
        OracleDataAdapter da;
        int i = 1;

        public student_data()
        {   
            InitializeComponent();
            
        }

        private void CGPATb_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_data_Load(object sender, EventArgs e)
        {

        }
        public OracleConnection connect_db()

        {
            OracleConnection conn = null;
            String oradb = "Data Source=172.16.54.24:1521/ICTORCL;User ID=CCE230953160;Password = student";
            try
            {
                conn = new OracleConnection(oradb);
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch
            {
                MessageBox.Show("Connection Failure");
            }
            return conn;
        }
        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void rollNoTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void cgpa_Click(object sender, EventArgs e)
        {

        }

        private void course_name_Click(object sender, EventArgs e)
        {

        }

        private void roll_no_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void update_but_Click(object sender, EventArgs e)
        {

        }

        private void show_button_Click(object sender, EventArgs e)
        {
            OracleConnection conn = null;
            OracleCommand comm = null;

            try
            {
                conn = connect_db();
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Database connection is not established.");
                    return;
                }

                comm = new OracleCommand();
                comm.Connection = conn;

               
                comm.CommandText = "SELECT * FROM CCE230953160.STUDENT_VC";
                comm.CommandType = CommandType.Text;

                ds = new DataSet();
                da = new OracleDataAdapter(comm);

                int rowsAffected = da.Fill(ds, "student_vc");

                MessageBox.Show("Rows affected by Fill: " + rowsAffected);

                if (rowsAffected == 0)
                {
                    MessageBox.Show("No rows returned from the database.");
                    return;
                }

                dt = ds.Tables["student_vc"];

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found in the table.");
                    return;
                }

                MessageBox.Show("Number of rows found:" + dt.Rows.Count);

                if (i < dt.Rows.Count)
                {
                    dr = dt.Rows[i];
                    nameTB.Text = dr["name"].ToString();
                    rollNoTB.Text = dr["roll_number"].ToString();
                    CGPATb.Text = dr["cgpa"].ToString();
                    CourseTB.Text = dr["course"].ToString();
                }
                else
                {
                    MessageBox.Show("No more rows to display.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (comm != null)
                    comm.Dispose();
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }




    }
}
