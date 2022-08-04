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
    public partial class Yönetici : Form
    {
        public Yönetici()
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
            yöneticibilgiler form2 = new yöneticibilgiler();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hastabilgileri form2 = new hastabilgileri();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            doktorlar form2 = new doktorlar();
            form2.Show();
        }

        private void Yönetici_Load(object sender, EventArgs e)
        {

        }
    }
}
