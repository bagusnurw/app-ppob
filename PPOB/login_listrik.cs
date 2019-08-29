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
    public partial class login_listrik : Form
    {
        public login_listrik()
        {
            InitializeComponent();
        }

        private void login_listrik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            if (UsernameText.Text == user && PasswordText.Text == pass)
            {
                this.Hide();
                DBLListrik form = new DBLListrik();
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
