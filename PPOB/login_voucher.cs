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
    public partial class login_voucher : Form
    {
        public login_voucher()
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
                DBLVoucher form = new DBLVoucher();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf Password yang anda masukkan salah!!");
            }
        }
    }
}
