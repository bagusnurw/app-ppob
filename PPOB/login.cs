using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPOB
{
    public partial class login_pulsa : Form
    {
        public login_pulsa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            if (UsernameText.Text == user && PasswordText.Text == pass)
            {
                this.Hide();
                DBLPulsa form = new DBLPulsa();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf Password yang anda masukkan salah!!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
