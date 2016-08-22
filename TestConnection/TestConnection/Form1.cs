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

        public String conString = "Data Source=govindaraj\\SQLExpress;Initial Catalog=ConnectionDb;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into test(Emp_No, Emp_name, ISU, Account_Name, Skillsets, Released_Date, Reporting_Person) values('" + txtId.Text.ToString() + "', '" + txtName.Text.ToString() + "', '" + txtISU.Text.ToString() + "','" + txtAN.Text.ToString() + "','" + txtSkills.Text.ToString() + "','" + txtRD.Text.ToString() + "','" + txt_RP.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made successfully...!");
             }
            txtId.Text = "";
            txtName.Text = "";
            txtISU.Text = "";
            txtAN.Text = "";
            txtSkills.Text = "";
            txtRD.Text = "";
            txt_RP.Text = "";
        }
     }
}
