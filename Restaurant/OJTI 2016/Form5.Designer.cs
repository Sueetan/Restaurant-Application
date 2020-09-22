namespace OJTI_2016
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvv = new System.Windows.Forms.DataGridView();
            this.denumire_produs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label_mesaj2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvv
            // 
            this.dgvv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumire_produs,
            this.kcal,
            this.pret,
            this.cantitate});
            this.dgvv.Location = new System.Drawing.Point(57, 260);
            this.dgvv.Name = "dgvv";
            this.dgvv.Size = new System.Drawing.Size(769, 67);
            this.dgvv.TabIndex = 19;
            this.dgvv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // denumire_produs
            // 
            this.denumire_produs.HeaderText = "denumire_produs";
            this.denumire_produs.Name = "denumire_produs";
            // 
            // kcal
            // 
            this.kcal.HeaderText = "kcal";
            this.kcal.Name = "kcal";
            // 
            // pret
            // 
            this.pret.HeaderText = "pret";
            this.pret.Name = "pret";
            // 
            // cantitate
            // 
            this.cantitate.HeaderText = "cantitate";
            this.cantitate.Name = "cantitate";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(118, 380);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(118, 409);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 25;
            // 
            // label_mesaj2
            // 
            this.label_mesaj2.AutoSize = true;
            this.label_mesaj2.Location = new System.Drawing.Point(115, 354);
            this.label_mesaj2.Name = "label_mesaj2";
            this.label_mesaj2.Size = new System.Drawing.Size(73, 13);
            this.label_mesaj2.TabIndex = 24;
            this.label_mesaj2.Text = "Necesar zilnic";
            this.label_mesaj2.Click += new System.EventHandler(this.label_mesaj2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 38);
            this.button3.TabIndex = 23;
            this.button3.Text = "Finalizare";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Pret Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Kcal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Necesar zilnic";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label_mesaj2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvv);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvv;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label_mesaj2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumire_produs;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}