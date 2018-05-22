using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Promotive_Promosyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void kapat_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void parabirim_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            parabirim_Box.Items.Add("Tokyo");
        }
    }
}
