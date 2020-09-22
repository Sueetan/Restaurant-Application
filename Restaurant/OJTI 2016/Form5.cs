using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJTI_2016
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static DataGridView dgv = new DataGridView();
        private void Form5_Load(object sender, EventArgs e)
        {
            adauga();   
        }
        public static DataTable dt = new DataTable();
        void adauga()
        {
            
           
            this.dgvv.DataSource = dt;
            /*DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            dgvv.Columns.Add(btn1);
            btn1.Name = "dataGridViewDeleteButton";
            btn1.HeaderText = "Elimina";
            btn1.Text = "Elimina";
            btn1.UseColumnTextForButtonValue = true;*/
            dgvv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            label_mesaj2.Text = Form4.label;
        }
        private void label_mesaj2_Click(object sender, EventArgs e)
        {

        }
    }
}
