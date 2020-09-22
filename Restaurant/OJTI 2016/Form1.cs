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
using System.IO;

namespace OJTI_2016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mures\Documents\Visual Studio 2015\Projects\OJTI 2016\OJTI 2016\bin\Debug\GOOD_FOOD.mdf;Integrated Security=True;Connect Timeout=30;";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 sss = new Form3();
            sss.Show();
        }
        private void stergere()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Meniu");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        private void Initializare()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd;
            StreamReader sr = new StreamReader(Application.StartupPath + @"\..\..\meniu.txt");
            string sir,sir1;
            char[] split = { ';' };
            con.Open();
             sir = sr.ReadLine();
           // sir = sr.ReadLine().ElementAtOrDefault(1);
            while ((sir1 = sr.ReadLine()) != null)
            {
          
                string[] siruri = sir1.Split(split);
                cmd = new SqlCommand("insert into Meniu(id_produs,denumire_produs,descriere,pret,kcal,felul)values(@id,@denumire_produs,@descriere,@pret,@kcal,@felul)", con);
                cmd.Parameters.AddWithValue("id", siruri[0].Trim());
                cmd.Parameters.AddWithValue("denumire_produs", siruri[1].Trim());
                cmd.Parameters.AddWithValue("descriere", siruri[2].Trim());
                cmd.Parameters.AddWithValue("pret", siruri[3].Trim());
                cmd.Parameters.AddWithValue("kcal", siruri[4].Trim());
                cmd.Parameters.AddWithValue("felul", siruri[5].Trim());
                cmd.ExecuteNonQuery();
                
                
            }
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            stergere();
            Initializare();
        }
    }
}
