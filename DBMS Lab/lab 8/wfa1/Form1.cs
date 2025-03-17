using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class student_data : Form
    {
        private DataSet ds;
        private DataTable dt;
        private BindingSource bindingSource;
        private OracleDataAdapter da;
        

        public student_data()
        {
            InitializeComponent();
        }

        private void student_data_Load(object sender, EventArgs e)
        {
            // BindData();
        }

        // Database connection method
        public OracleConnection connect_db()
        {
            OracleConnection conn = null;
            string oradb = "Data Source=172.16.54.24:1521/ICTORCL;User ID=CCE230953160;Password = student";
            try
            {
                conn = new OracleConnection(oradb);
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failure: " + ex.Message);
            }
            return conn;
        }
        private void show_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Establish a database connection
                OracleConnection conn = connect_db();
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Database connection is not established.");
                    return;
                }

                // Create the query to get the first record (you can modify this for any specific record)
                string query = "SELECT * FROM CCE230953160.STUDENT_VC"; // Modify the query if needed
                da = new OracleDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "student_vc");

                // Check if the dataset contains data
                if (ds.Tables["student_vc"].Rows.Count > 0)
                {
                    dt = ds.Tables["student_vc"];
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;

                    // Bind textboxes to corresponding columns
                    nameTB.DataBindings.Clear();
                    nameTB.DataBindings.Add("Text", bindingSource, "name");

                    rollNoTB.DataBindings.Clear();
                    rollNoTB.DataBindings.Add("Text", bindingSource, "roll_number");

                    CGPATb.DataBindings.Clear();
                    CGPATb.DataBindings.Add("Text", bindingSource, "cgpa");

                    CourseTB.DataBindings.Clear();
                    CourseTB.DataBindings.Add("Text", bindingSource, "course");
                }
                else
                {
                    MessageBox.Show("No data found.");
                }

                conn.Close();  // Close the connection after data retrieval
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data: " + ex.Message);
            }
        }



        // Bind data from Oracle DB to controls
        private void BindData()
        {
            try
            {
                OracleConnection conn = connect_db();
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Database connection is not established.");
                    return;
                }

                // Create data adapter and fill the dataset
                string query = "SELECT * FROM CCE230953160.STUDENT_VC";
                da = new OracleDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "student_vc");

                if (ds.Tables["student_vc"].Rows.Count > 0)
                {
                    dt = ds.Tables["student_vc"];
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;

                    // Bind textboxes to corresponding columns
                    nameTB.DataBindings.Clear();
                    nameTB.DataBindings.Add("Text", bindingSource, "name");

                    rollNoTB.DataBindings.Clear();
                    rollNoTB.DataBindings.Add("Text", bindingSource, "roll_number");

                    CGPATb.DataBindings.Clear();
                    CGPATb.DataBindings.Add("Text", bindingSource, "cgpa");

                    CourseTB.DataBindings.Clear();
                    CourseTB.DataBindings.Add("Text", bindingSource, "course");
                }
                else
                {
                    MessageBox.Show("No data available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while binding data: " + ex.Message);
            }
        }

        // Show next record
        private void next_but_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.Position++;
            }
            else
            {
                MessageBox.Show("You are already at the last record.");
            }
        }

        // Show previous record
        private void prev_but_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.Position--;
            }
            else
            {
                MessageBox.Show("You are already at the first record.");
            }
        }

        // Save updated data
        private void save_but_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any fields are empty
                if (string.IsNullOrWhiteSpace(nameTB.Text) ||
                    string.IsNullOrWhiteSpace(rollNoTB.Text) ||
                    string.IsNullOrWhiteSpace(CGPATb.Text) ||
                    string.IsNullOrWhiteSpace(CourseTB.Text))
                {
                    MessageBox.Show("Please fill all fields before saving.");
                    return;
                }

                // Validate CGPA - Ensure it's a valid number
                double cgpa;
                if (!double.TryParse(CGPATb.Text, out cgpa))
                {
                    MessageBox.Show("Please enter a valid CGPA.");
                    return;
                }

                // Add a new row to the DataTable
                DataRow newRow = dt.NewRow();
                newRow["name"] = nameTB.Text;
                newRow["roll_number"] = rollNoTB.Text;
                newRow["cgpa"] = cgpa;
                newRow["course"] = CourseTB.Text;

                // Add the new row to the DataTable
                dt.Rows.Add(newRow);

                // Establish a database connection
                OracleConnection conn = connect_db();
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Database connection is not established.");
                    return;
                }

                // Prepare the INSERT command to save new data
                string insertQuery = "INSERT INTO CCE230953160.STUDENT_VC (name, roll_number, cgpa, course) " +
                                     "VALUES (:name, :roll_number, :cgpa, :course)";
                OracleCommand comm = new OracleCommand(insertQuery, conn);

                // Add parameters to the command
                comm.Parameters.Add("name", OracleDbType.Varchar2).Value = nameTB.Text;
                comm.Parameters.Add("roll_number", OracleDbType.Varchar2).Value = rollNoTB.Text;
                comm.Parameters.Add("cgpa", OracleDbType.Double).Value = cgpa;
                comm.Parameters.Add("course", OracleDbType.Varchar2).Value = CourseTB.Text;

                // Execute the INSERT command
                int rowsAffected = comm.ExecuteNonQuery();

                // Check if the new record was successfully inserted
                if (rowsAffected > 0)
                {
                    MessageBox.Show("New student data added successfully.");
                    // Refresh the data to reflect the new row
                    BindData();
                }
                else
                {
                    MessageBox.Show("Error while adding new student data.");
                }

                // Close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving: " + ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void roll_no_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }
        // Close the form
        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rollNoTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void CGPATb_TextChanged(object sender, EventArgs e)
        {

        }
        private void cgpa_Click(object sender, EventArgs e)
        {

        }
        private void update_but_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any fields are empty
                if (string.IsNullOrWhiteSpace(nameTB.Text) ||
                    string.IsNullOrWhiteSpace(rollNoTB.Text) ||
                    string.IsNullOrWhiteSpace(CGPATb.Text) ||
                    string.IsNullOrWhiteSpace(CourseTB.Text))
                {
                    MessageBox.Show("Please fill all fields before updating.");
                    return;
                }

                // Validate CGPA - Ensure it's a valid number
                double cgpa;
                if (!double.TryParse(CGPATb.Text, out cgpa))
                {
                    MessageBox.Show("Please enter a valid CGPA.");
                    return;
                }

                // Get the current DataRow from the DataTable via the BindingSource
                DataRow row = dt.Rows[bindingSource.Position];

                // Update DataTable with new values from TextBoxes
                row["name"] = nameTB.Text;
                row["roll_number"] = rollNoTB.Text;
                row["cgpa"] = cgpa;
                row["course"] = CourseTB.Text;

                // Establish a database connection
                OracleConnection conn = connect_db();
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Database connection is not established.");
                    return;
                }

                // Prepare the UPDATE command to save changes
                string updateQuery = "UPDATE CCE230953160.STUDENT_VC SET name = :name, cgpa = :cgpa, course = :course WHERE roll_number = :roll_number";
                OracleCommand comm = new OracleCommand(updateQuery, conn);

                // Add parameters to the command
                comm.Parameters.Add("name", OracleDbType.Varchar2).Value = nameTB.Text;
                comm.Parameters.Add("cgpa", OracleDbType.Double).Value = cgpa;
                comm.Parameters.Add("course", OracleDbType.Varchar2).Value = CourseTB.Text;
                comm.Parameters.Add("roll_number", OracleDbType.Varchar2).Value = rollNoTB.Text;

                // Execute the UPDATE command
                int rowsAffected = comm.ExecuteNonQuery();

                // Check if the record was successfully updated
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student data updated successfully.");
                    // After updating, refresh the data
                    BindData();
                }
                else
                {
                    MessageBox.Show("No rows updated. Check if the roll number exists.");
                }

                // Close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating: " + ex.Message);
            }
        }

        private void course_name_Click(object sender, EventArgs e)
        {

        }


    }
}
