using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Promotive_Promosyon
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kapat_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giriş_Button_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = username.Text;
            string şifre = password.Text;

            if (username.text == "admin" || password.text == "admin") {
                Form2 ana = new Form2();
                this.Hide();
                ana.Show();
            }

            else if (string.IsNullOrWhiteSpace(username.text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boşluktan oluşmaz");
            }

            else if (string.IsNullOrWhiteSpace(password.text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boşluktan oluşmaz");
            }

            else if (username.text.Length < 5)
            {
                MessageBox.Show("Kullanıcı adı veya şifre 5 karakterden fazla olamaz");
            }

            else if (password.text.Length < 5)
            {
                MessageBox.Show("Kullanıcı adı veya şifre 5 karakterden fazla olamaz");
            }

        }

        private void mini_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.promotivepromosyon.com");
        }

        private void username_OnTextChange(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void password_OnTextChange(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
