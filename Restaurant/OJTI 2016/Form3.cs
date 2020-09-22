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

namespace OJTI_2016
{
    public partial class Form3 : Form
    {
        public static class client
        {
            public static string email { get; set; }
        }
        public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mures\Documents\Visual Studio 2015\Projects\OJTI 2016\OJTI 2016\bin\Debug\GOOD_FOOD.mdf;Integrated Security=True;Connect Timeout=30;";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter("Select count(*) from Clienti where email='" + textBox1.Text + "' and Parola='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                client.email = textBox1.Text;
                this.Hide();
                Form4 ssss = new Form4();
                ssss.Show();
            }
            else MessageBox.Show("verifica datele");
        }
    }
}
