using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        DataTable dtProdukSimpan = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            dtProdukSimpan.Columns.Add("Item");
            dtProdukSimpan.Columns.Add("Qty");
            dtProdukSimpan.Columns.Add("Price");
            dtProdukSimpan.Columns.Add("Total");
            dgvProdukSimpan.DataSource = dtProdukSimpan; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (dtProdukSimpan.Rows.Count <= 0)
            {
                dtProdukSimpan.Rows.Add("T-Shirt Kerah Bulat", "1", "150000", "150000");

            }
            else
            {
                bool isAvail = false;
                foreach (DataRow item in dtProdukSimpan.Rows)
                {
                    isAvail = true;
                    if (item[0].ToString() == "T-Shirt Kerah Bulat")
                    {
                        item[1] = Convert.ToInt32(item[1].ToString())+1;
                        item[2] = Convert.ToInt32(item[2].ToString()) + 150000;
                        item[3] = Convert.ToInt32(item[1].ToString()) * Convert.ToInt32(item[2].ToString());
                    }
                }
                if (!isAvail)
                {
                    dtProdukSimpan.Rows.Add("T-Shirt Kerah Bulat", "1", "150000", "150000");
                }
            }
            dgvProdukSimpan.DataSource = dtProdukSimpan;
            lblSubTotal_Click(sender, e);
            lblTotal_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtProdukSimpan.Rows.Count <= 0)
            {
                dtProdukSimpan.Rows.Add("T-Shirt Kerah Bulat", "1", "150000", "150000");

            }
            else
            {
                bool isAvail = false;
                foreach (DataRow item in dtProdukSimpan.Rows)
                {
                    isAvail = true;
                    if (item[0].ToString() == "T-Shirt Kerah Bulat")
                    {
                        item[1] = Convert.ToInt32(item[1].ToString()) + 1;
                        item[2] = Convert.ToInt32(item[2].ToString()) + 150000;
                        item[3] = Convert.ToInt32(item[1].ToString()) * Convert.ToInt32(item[2].ToString());
                    }
                }
                if (!isAvail)
                {
                    dtProdukSimpan.Rows.Add("T-Shirt Kerah Bulat", "1", "150000", "150000");
                }
            }
            dgvProdukSimpan.DataSource = dtProdukSimpan;
            lblSubTotal_Click(sender, e);
            lblTotal_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dtProdukSimpan.Rows.Count <= 0)
            {
                dtProdukSimpan.Rows.Add("AIRsm Katun", "1", "200000", "200000");

            }
            else
            {
                bool isAvail = false;
                foreach (DataRow item in dtProdukSimpan.Rows)
                {
                    if (item[0].ToString() == "AIRsm Katun")
                    {
                        isAvail = true;
                        item[1] = Convert.ToInt32(item[1].ToString()) + 1;
                        item[2] = Convert.ToInt32(item[2].ToString()) + 200000;
                        item[3] = Convert.ToInt32(item[1].ToString()) * Convert.ToInt32(item[2].ToString());
                    }
                }
                if (!isAvail)
                {
                    dtProdukSimpan.Rows.Add("AIRsm Katun", "1", "200000", "200000");
                }
            }
            dgvProdukSimpan.DataSource = dtProdukSimpan;
            lblSubTotal_Click(sender, e);
            lblTotal_Click(sender, e);
        }

        private void tShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        private void lblSubTotal_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dgvProdukSimpan.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvProdukSimpan.Rows[i].Cells[3].Value);
            }
            lblSubTotal.Text = sum.ToString();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double tax = 0.10;
            for (int i = 0; i < dgvProdukSimpan.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvProdukSimpan.Rows[i].Cells[3].Value);
            }
            double sumTax = sum * tax;
            sum = sum + sumTax;
            lblTotal.Text = sum.ToString();
        }

        private void dgvProdukSimpan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
            dtProdukSimpan.Rows[e.RowIndex][3] = (Convert.ToInt32(dtProdukSimpan.Rows[e.RowIndex][1]) * Convert.ToInt32(dtProdukSimpan.Rows[e.RowIndex][3]));
            
            lblSubTotal_Click(sender, e);
            lblTotal_Click(sender, e);
        }
    }
}
