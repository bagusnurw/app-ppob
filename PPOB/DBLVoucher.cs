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
    public partial class DBLVoucher : Form
    {
        SqlConnection CON = new SqlConnection
            (@"Data Source=KIDZ-PC\SQLEXPRESS;Initial Catalog=data_bagusnr;Integrated Security=True");

        public DBLVoucher()
        {    
            InitializeComponent();
        }

        public void load_data()
        {
            if (CON.State == ConnectionState.Open)
            {
                CON.Close();
            }
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from V";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewVoucher.DataSource = dt;
            CON.Close();
        }

        private void DBLVoucher_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'data_bagusnrDataSet.V' table. You can move, or remove it, as needed.
            this.vTableAdapter.Fill(this.data_bagusnrDataSet.V);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSearch.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewVoucher.Rows[e.RowIndex];
                CBProduk.Text = row.Cells[0].Value.ToString();
                CBNominalVoucher.Text = row.Cells[1].Value.ToString();
                dateTimePickerVoucher.Text = row.Cells[2].Value.ToString();
                TextNoPemb.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin untuk menghapus data ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM V WHERE [No. Pembelian] = '" + TextNoPemb.Text + "'");
                cmd.ExecuteNonQuery();
                load_data();
                MessageBox.Show("Data Berhasil Dihapus!");
                CON.Close();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("UPDATE V SET Platform = '" + CBProduk.SelectedItem + "', Nominal = '" + CBNominalVoucher.SelectedItem + "', [Tanggal Trx] = '" + dateTimePickerVoucher.Text + "' WHERE [No. Pembelian] = '" + TextNoPemb.Text + "'");
            cmd.ExecuteNonQuery();
            load_data();
            MessageBox.Show("Data Berhasil Diperbarui");
            CON.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextNoPemb.Text))
            {
                load_data();
            }
            else
            {
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("SELECT * FROM V WHERE [No. Pembelian] = '" + TextNoPemb.Text + "'");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewVoucher.DataSource = dt;
                CON.Close();
            }
        }
    }
}
