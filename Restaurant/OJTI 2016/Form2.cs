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
    public partial class Form2 : Form
    {
        public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mures\Documents\Visual Studio 2015\Projects\OJTI 2016\OJTI 2016\bin\Debug\GOOD_FOOD.mdf;Integrated Security=True;Connect Timeout=30;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox5.Text)
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Clienti(parola,nume,prenume,adresa,email)values('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox6.Text + "')", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
               // MessageBox.Show("bv");
                this.Hide();
                Form1 s = new Form1();
                s.Show();
            }
            else MessageBox.Show("Parola nu este la fel");

        }
    }
}
