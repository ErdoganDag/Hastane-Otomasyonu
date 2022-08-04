using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
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

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            giris fr1 = new giris();
            fr1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doktor fr2 = new doktor();
            fr2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hastakabul form2 = new Hastakabul();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            iletişim form2 = new iletişim();
            form2.Show();
        }
    }
}
