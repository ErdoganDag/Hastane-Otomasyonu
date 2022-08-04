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
    public partial class doktorlar : Form
    {
        public doktorlar()
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
            con = new SqlConnection("server=.; Initial Catalog=Hastane;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *From doktor", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "doktor");
            dataGridView1.DataSource = ds.Tables["doktor"];
            con.Close();
        }
    }
}
