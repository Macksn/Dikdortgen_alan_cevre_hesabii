using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dikdörtgenin_alanı_ve_çevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunkenar, kısakenar, alan;
            uzunkenar = Convert.ToInt16(textBox1.Text);
            kısakenar = Convert.ToInt16(textBox2.Text);
            alan = uzunkenar * kısakenar;
            label3.Text = alan.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int uzunkenar, kısakenar, çevre;
            uzunkenar = Convert.ToInt16(textBox1.Text);
            kısakenar = Convert.ToInt16(textBox2.Text);
            çevre =  (uzunkenar + kısakenar)  * 2;
            label3.Text = çevre.ToString();

                
        }
    }
}
