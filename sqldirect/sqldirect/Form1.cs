using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sqldirect
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-THLGAI4\\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }



        private void btninsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insertemployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", editempID.Text);
                cmd.Parameters.AddWithValue("@Fname", editfname.Text);
                cmd.Parameters.AddWithValue("@Lname", editlname.Text);
                cmd.Parameters.AddWithValue("@Email", editemail.Text);
                cmd.Parameters.AddWithValue("@Salary", editsalary.Text);

                cmd.ExecuteNonQuery();
                btnload_Click(sender, e);
                MessageBox.Show("Employee inserted successfully.");

            }

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("viewallemployees", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateEmployeeData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // assuming you have text boxes for these values 
                cmd.Parameters.AddWithValue("@EmployeeID ", editempID.Text);
                cmd.Parameters.AddWithValue("@Fname", editfname.Text);
                cmd.Parameters.AddWithValue("@Lname", editlname.Text);
                cmd.Parameters.AddWithValue("@Email", editemail.Text);
                cmd.Parameters.AddWithValue("@Salary", editsalary.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    btnload_Click(sender, e);
                    MessageBox.Show("Employee updated successfully.");
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }
            }
            

        }
        private void btndelete_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DeleteEmployeeData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID ", editempID.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    btnload_Click(sender, e);
                    MessageBox.Show(" Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                conn.Close();
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            editempID.Text = "";
            editfname.Text = "";
            editlname.Text = "";
            editemail.Text = "";
            editsalary.Text = "";

        }
    }
}
