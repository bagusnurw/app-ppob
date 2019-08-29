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
    public partial class DBLListrik : Form
    {
        SqlConnection CON = new SqlConnection
            (@"Data Source=KIDZ-PC\SQLEXPRESS;Initial Catalog=data_bagusnr;Integrated Security=True");

        public DBLListrik()
        {
            InitializeComponent();
            
        }
        
        public void load_data()
        {
            if(CON.State == ConnectionState.Open){
                CON.Close();
            }
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from L";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                CON.Close();
         }

        private void DBLListrik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_bagusnrDataSet.L' table. You can move, or remove it, as needed.
            this.lTableAdapter.Fill(this.data_bagusnrDataSet.L);
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSearch.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ComboJenis.Text = row.Cells[0].Value.ToString();
                TextMeter.Text = row.Cells[1].Value.ToString();
                ComboNominalPLN.Text = row.Cells[2].Value.ToString();
                dateTimePickerListrik.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin untuk menghapus data ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM L WHERE [No. Meter] = '" + TextMeter.Text + "'");
                cmd.ExecuteNonQuery();
                load_data();
                MessageBox.Show("Data Berhasil Dihapus!");
                CON.Close();
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("UPDATE L SET [Jenis Pembayaran] = '" + ComboJenis.SelectedItem + "', Nominal = '" + ComboNominalPLN.SelectedItem + "', [Tanggal Trx] = '" + dateTimePickerListrik.Text + "' WHERE [No. Meter] = '" + TextMeter.Text + "'");
            cmd.ExecuteNonQuery();
            load_data();
            MessageBox.Show("Data Berhasil Diperbarui");
            CON.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextMeter.Text))
            {
                load_data();
            }
            else
            {
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("SELECT * FROM L WHERE [No. Meter] = '" + TextMeter.Text + "'");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                CON.Close();
            }
        }
    }
}
