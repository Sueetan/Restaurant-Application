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
    public partial class Form4 : Form
    {
        int ani, cm, kg,s;
        public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mures\Documents\Visual Studio 2015\Projects\OJTI 2016\OJTI 2016\bin\Debug\GOOD_FOOD.mdf;Integrated Security=True;Connect Timeout=30;";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            s = 0;
            ani = Convert.ToInt32(textBox1.Text);
            cm = Convert.ToInt32(textBox2.Text);
            kg = Convert.ToInt32(textBox3.Text);
            s = ani + cm + kg;
            if (s < 250)  label_mesaj.Text = "1800";
            else if (s >= 250 && s <= 275)  label_mesaj.Text = "2200";
            else  label_mesaj.Text = "2500";
            label_mesaj1.Text = label_mesaj.Text;
            label_mesaj2.Text = label_mesaj.Text;
            label = label_mesaj.Text;
            da.UpdateCommand = new SqlCommand("Update Clienti set kcal_zilnice= '" + label_mesaj.Text + "' where email= '" + Form3.client.email.ToString() + "'", con);
            da.UpdateCommand.ExecuteNonQuery();
            da.UpdateCommand.Dispose();
            con.Close();
        }
        public static string label;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 0)
            {
                dataGridView2.Rows.Add(dataGridView1["denumire_produs", e.RowIndex].Value.ToString(), dataGridView1["kcal", e.RowIndex].Value.ToString(), dataGridView1["pret", e.RowIndex].Value.ToString(), dataGridView1["Cantitate", e.RowIndex].Value.ToString());
                

                if (textBox4.Text != "")
                    sk = Convert.ToInt32(textBox4.Text);
                else sk = 0;
                 sk1 = Convert.ToInt32(dataGridView1["kcal", e.RowIndex].Value);
                 sk2 = Convert.ToInt32(dataGridView1["Cantitate", e.RowIndex].Value);
                
                sumKcal = sk + sk1 * sk2;
                 
                if (textBox5.Text != "")
                    sp = Convert.ToInt32(textBox5.Text);
                else sp = 0;
                 sp1 = Convert.ToInt32(dataGridView1["pret", e.RowIndex].Value);
                 sp2 = Convert.ToInt32(dataGridView1["Cantitate", e.RowIndex].Value);
                sumpret = sp + sp1 * sp2;
                textBox4.Text = sumKcal.ToString();
                textBox6.Text = sumKcal.ToString();
                textBox5.Text = sumpret.ToString();
                textBox7.Text = sumpret.ToString();
            
            }
            SqlCommand cmd;
            DateTime dt = DateTime.Now;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            cmd = new SqlCommand("Insert into Subcomenzi(Denumire,kcal) values (@denumire,@kcal)", con);
            cmd.Parameters.AddWithValue("denumire", dataGridView1["denumire_produs", e.RowIndex].Value.ToString());
            cmd.Parameters.AddWithValue("kcal", dataGridView1["kcal", e.RowIndex].Value.ToString());
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            graph();
        }
        public static string[] dn = new string[100];
        public static int[] kc= new int [100];
        void update()
        {
            

        }
        void graph()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select denumire,kcal from Subcomenzi ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.chart1.Series["Denumire produs"].Points.AddXY(dr.GetValue(0), dr.GetInt32(1));
            }
            con.Close();
            cmd.Dispose();
        }
        public static int sumKcal,sk,sk1,sk2,sp,sumpret,sp1,sp2;

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
               // this.dataGridView1.Rows.Add(dataGridView2["denumire_produs", e.RowIndex].Value.ToString(), dataGridView2["kcal", e.RowIndex].Value.ToString(), dataGridView2["pret", e.RowIndex].Value.ToString(), dataGridView1["Cantitate", e.RowIndex].Value.ToString());
                
                if (textBox6.Text != "")
                    sk = Convert.ToInt32(textBox4.Text);
                else sk = 0;
                 sk1 = Convert.ToInt32(dataGridView2[1, e.RowIndex].Value);
                 sk2 = Convert.ToInt32(dataGridView2[3, e.RowIndex].Value);
                sumKcal = sk - sk1 * sk2;
                if (textBox7.Text != "")
                    sp = Convert.ToInt32(textBox5.Text);
                else sp = 0;
                 sp1 = Convert.ToInt32(dataGridView2[2, e.RowIndex].Value);
                 sp2 = Convert.ToInt32(dataGridView2[3, e.RowIndex].Value);
                sumpret = sp - sp1 * sp2;
                textBox4.Text = sumKcal.ToString();
                textBox6.Text = sumKcal.ToString();
                textBox5.Text = sumpret.ToString();
                textBox7.Text = sumpret.ToString();
                dataGridView2.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            adauga();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 ssss = new Form5();
            this.Hide();
            ssss.Show();
        }
        public Form4()
        {
            InitializeComponent();
            
        }
        private void adauga()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_produs", typeof(int));
            dt.Columns.Add("denumire_produs", typeof(string));
            dt.Columns.Add("descriere", typeof(string));
            dt.Columns.Add("pret", typeof(int));
            dt.Columns.Add("kcal", typeof(int));
            dt.Columns.Add("felul", typeof(int));
            dt.Columns.Add("Cantitate", typeof(int));
           // dataGridView2.DataSource = dt;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            dataGridView2.Columns.Add(btn1);
            btn1.Name = "dataGridViewDeleteButton";
            btn1.HeaderText = "Elimina";
            btn1.Text = "Elimina";
            btn1.UseColumnTextForButtonValue = true;
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select id_produs,denumire_produs,descriere,pret,kcal,felul from Meniu",con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                dt.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), 1);
            }
            dataGridView1.DataSource = dt;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.Name = "dataGridViewDeleteButton";
            btn.HeaderText = "Adauga";
            btn.Text = "Adauga";
            btn.UseColumnTextForButtonValue = true;



            con.Close();
            cmd.Dispose();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
