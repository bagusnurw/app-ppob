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
    public partial class pulsa : Form
    {
        SqlConnection CON = new SqlConnection
            (@"Data Source=KIDZ-PC\SQLEXPRESS;Initial Catalog=data_bagusnr;Integrated Security=True");

        public pulsa()
        {
            InitializeComponent();
        }       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("INSERT INTO P (Provider, [No. HP], Nominal, [Tanggal Trx]) VALUES ('" + CBProvider.SelectedItem + "', '" + TextNohp.Text + "', '" + CBNominal.SelectedItem + "', '" + dateTimePickerPulsa.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaksi Sukses");
            CON.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextNohp_TextChanged(object sender, EventArgs e)
        {

        }

        private void pulsa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
