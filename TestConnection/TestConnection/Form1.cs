using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String conString = "Data Source=(localdb)\\ProjectsV12;Initial Catalog=TestDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
//                string q = "select Emp_No, Emp_Name from Test";
                string q = "insert into test(Emp_No, Emp_name, Mobile_No, Role, Skills, Experience, Reason_for_Release, Remarks, Employee_Status, GPM, Month, Released_date_in_RMG, Status) values('" + txtId.Text.ToString() + "', '" + txtName.Text.ToString() + "', '" + txtMobile.Text.ToString() + "','" + txtRole.Text.ToString() + "','" + txtSkills.Text.ToString() + "','" + txtExperience.Text.ToString() + "','" + txtrelease.Text.ToString() + "','" + txtremarks.Text.ToString() + "','" + txtestatus.Text.ToString() + "','" + txtgpm.Text.ToString() + "','" + txtmonth.Text.ToString() + "','" + txtrmg.Text.ToString() + "','" + txtStatus.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made successfully...!");
             }
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtMobile.Text = "";
            txtRole.Text = "";
            txtSkills.Text = "";
            txtExperience.Text = "";
            txtrelease.Text = "";
            txtremarks.Text = "";
            txtestatus.Text = "";
            txtgpm.Text = "";
            txtmonth.Text = "";
            txtrmg.Text = "";
            txtStatus.Text = ""; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     }
}
