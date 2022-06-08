using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKasir
{
    public partial class FormTransaksiPenjualan : Form
    {
        public FormTransaksiPenjualan()
        {
            InitializeComponent();
        }

        string name;
        int price;
        int tot;

        private void button1_Click(object sender, EventArgs e)
        {
            //Pokok
            if (checkBox1.Checked)
            {
                name = "Beras";
                int Qty = int.Parse(numericUpDown1.Value.ToString());
                price = 12000;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }
            if (checkBox2.Checked)
            {
                name = "Gula";
                int Qty = int.Parse(numericUpDown2.Value.ToString());
                price = 15000;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }
            if (checkBox3.Checked)
            {
                name = "Minyak Goreng";
                int Qty = int.Parse(numericUpDown3.Value.ToString());
                price = 15000;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }
            if (checkBox4.Checked)
            {
                name = "Kopi";
                int Qty = int.Parse(numericUpDown4.Value.ToString());
                price = 6000;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }
            if (checkBox5.Checked)
            {
                name = "Teh";
                int Qty = int.Parse(numericUpDown5.Value.ToString());
                price = 5500;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }
            if (checkBox6.Checked)
            {
                name = "Mie Instan";
                int Qty = int.Parse(numericUpDown6.Value.ToString());
                price = 3000;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }
            if (checkBox7.Checked)
            {
                name = "Tepung";
                int Qty = int.Parse(numericUpDown7.Value.ToString());
                price = 11500;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }

            //Sekunder
            if (checkBox8.Checked)
            {
                name = "Sabun";
                int Qty = int.Parse(numericUpDown8.Value.ToString());
                price = 4000;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }
            if (checkBox9.Checked)
            {
                name = "Shampo";
                int Qty = int.Parse(numericUpDown9.Value.ToString());
                price = 2000;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }
            if (checkBox10.Checked)
            {
                name = "Pasta Gigi";
                int Qty = int.Parse(numericUpDown10.Value.ToString());
                price = 12300;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }
            if (checkBox11.Checked)
            {
                name = "Detergent";
                int Qty = int.Parse(numericUpDown11.Value.ToString());
                price = 5000;
                tot = Qty * price;
                this.dataGridView1.Rows.Add(name, price, Qty, tot);
            }

            int sum = 0;
            for(int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }
            textBox1.Text = sum.ToString();
        }
    }
}
