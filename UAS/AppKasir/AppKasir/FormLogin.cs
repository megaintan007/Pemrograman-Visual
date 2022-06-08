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

namespace AppKasir
{
    public partial class FormLogin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Koneksi Konn = new Koneksi();


        public FormLogin()
        {
            InitializeComponent();
        }
        //Menginisialisasi tombol login

        private void button1_Click(object sender, EventArgs e)
        {
            //Koneksi ke Database
            SqlDataReader reader = null;
            SqlConnection Conn = Konn.GetConn();
            {
                Conn.Open();
                cmd = new SqlCommand("select * from TBL_Kasir where KodeKasir='" + textBox1.Text + "' and PasswordKasir='" + textBox2.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FormMenuUtama.menu.menuLogin.Enabled = false;
                    FormMenuUtama.menu.menuLogout.Enabled = true;
                    FormMenuUtama.menu.menuMaster.Enabled = true;
                    FormMenuUtama.menu.menuTransaksi.Enabled = true;
                    FormMenuUtama.menu.menuLaporan.Enabled = true;
                    FormMenuUtama.menu.menuUtility.Enabled = true;

                    FormMenuUtama frmUtama = new FormMenuUtama();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal Login!");
                }
            }
        }
        //Menginisialisasi tombol cancel
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
