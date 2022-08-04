using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    public partial class doktor : Form
    {
        public doktor()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doktorlar form3 = new doktorlar();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            randevu form2 = new randevu();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            randevu form1 = new randevu();
            form1.Show();
        }

        private void doktor_Load(object sender, EventArgs e)
        {

        }
    }
}
