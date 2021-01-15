using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class TeacherAdmission : Form
    {
        public TeacherAdmission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8AMRJ28V;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                con.Open();

                String sql = "INSERT INTO teacher(teacher_name,teacher_address) VALUES('" + textBox1.Text + "','" + textBox2.Text + "');";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                String sql1 = "SELECT MAX(teacher_id) FROM teacher";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Teacher Data Inserted Successfully... Teacher ID: '" + dr.GetInt32(0) + "'");
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
