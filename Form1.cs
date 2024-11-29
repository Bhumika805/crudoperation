using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crudoperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Conn = "Data Source=DESKTOP-O8JUFNV\\SQLEXPRESS;Initial Catalog=MCA;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            String query = "insert into Employee1 values (@Name,@LastName,@age,@Salary,@City,@Department)";
            SqlCommand com = new SqlCommand(query, conn);
            int age = Convert.ToInt32(textBox3.Text);
            int Salary = Convert.ToInt32(textBox4.Text);
            com.Parameters.AddWithValue("@Name", textBox1.Text);
            com.Parameters.AddWithValue("@age", age);
            com.Parameters.AddWithValue("@Salary", Salary);
            com.Parameters.AddWithValue("@LastName", textBox2.Text);
            com.Parameters.AddWithValue("@City", textBox5.Text);
            com.Parameters.AddWithValue("@Department", textBox6.Text);

            com.ExecuteNonQuery();

        }
    }
}