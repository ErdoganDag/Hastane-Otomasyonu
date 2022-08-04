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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public Form1 MdiParent { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {           
            con = new SqlConnection("server=.; Initial Catalog=Hastane;Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("Select *From yönetici where Adi=@kullanici_kullanici_adi and Sifre=@kullanici_sifre", con);
            da.SelectCommand.Parameters.AddWithValue("Adi", textBox1.Text);
            da.SelectCommand.Parameters.AddWithValue("Sifre", textBox2.Text);
            
            da.Fill(ds, "yönetici");
            con.Close();
        }
    }
}
