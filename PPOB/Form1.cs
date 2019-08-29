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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (pulsa frm = new pulsa())
            {
                frm.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void PPOB_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (listrik frm = new listrik())
            {
                frm.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (voucher frm = new voucher())
            {
                frm.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_pulsa login = new login_pulsa();
            login.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login_listrik login = new login_listrik();
            login.Show();
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            login_voucher login = new login_voucher();
            login.Show();
            
        }

    }
}
