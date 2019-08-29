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
    public partial class listrik : Form
    {
        SqlConnection CON = new SqlConnection
            (@"Data Source=KIDZ-PC\SQLEXPRESS;Initial Catalog=data_bagusnr;Integrated Security=True");

        public listrik()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listrik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("INSERT INTO L ([Jenis Pembayaran], [No. Meter], Nominal, [Tanggal Trx]) VALUES ('" + CBJenis.SelectedItem + "', '" + TextNoMeter.Text + "', '" + CBNominalListrik.SelectedItem + "', '" + dateTimePickerListrik.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaksi Sukses");
            CON.Close();
        }
    }
}
