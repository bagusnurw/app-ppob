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
    public partial class DBLPulsa : Form
    {
        SqlConnection CON = new SqlConnection
            (@"Data Source=KIDZ-PC\SQLEXPRESS;Initial Catalog=data_bagusnr;Integrated Security=True");

        public DBLPulsa()
        {
            InitializeComponent();
            
        }

        private void DBLPulsa_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'data_bagusnrDataSet.P' table. You can move, or remove it, as needed.
            this.pTableAdapter.Fill(this.data_bagusnrDataSet.P);
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
            cmd.CommandText = "select * from P";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewPulsa.DataSource = dt;
            CON.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewPulsa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSearch.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewPulsa.Rows[e.RowIndex];
                CBProvider.Text = row.Cells[0].Value.ToString();
                TextNohp.Text = row.Cells[1].Value.ToString();
                CBNominal.Text = row.Cells[2].Value.ToString();
                dateTimePickerPulsa.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin untuk menghapus data ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM P WHERE [No. HP] = '" + TextNohp.Text + "'");
                cmd.ExecuteNonQuery();
                load_data();
                MessageBox.Show("Data Berhasil Dihapus!");
                CON.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("UPDATE P SET Provider = '" + CBProvider.SelectedItem + "', Nominal = '" + CBNominal.SelectedItem + "', [Tanggal Trx] = '" + dateTimePickerPulsa.Text + "' WHERE [No. HP] = '" + TextNohp.Text + "'");
            cmd.ExecuteNonQuery();
            load_data();
            MessageBox.Show("Data Berhasil Diperbarui");
            CON.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextNohp.Text))
            {
                load_data();
            }
            else
            {
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("SELECT * FROM P WHERE [No. HP] = '" + TextNohp.Text + "'");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewPulsa.DataSource = dt;
                CON.Close();
            }
        }

        private void TextNohp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
