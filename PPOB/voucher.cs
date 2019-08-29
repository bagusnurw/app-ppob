using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPOB
{
    public partial class voucher : Form
    {
        SqlConnection CON = new SqlConnection
            (@"Data Source=KIDZ-PC\SQLEXPRESS;Initial Catalog=data_bagusnr;Integrated Security=True");

        public voucher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("INSERT INTO V (Platform, Nominal, [Tanggal Trx], [No. Pembelian]) VALUES ('" + CBProduk.SelectedItem + "', '" + CBNominalVoucher.SelectedItem + "', '" + dateTimePickerVoucher.Text + "', '" + TextNoPemb.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaksi Sukses");
            CON.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void voucher_Load(object sender, EventArgs e)
        {

        }
    }
}
