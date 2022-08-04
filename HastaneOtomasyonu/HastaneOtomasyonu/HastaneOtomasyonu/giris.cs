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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cnd;
        SqlDataReader dr;
        SqlDataReader de;

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("server=.; Initial Catalog=Hastane;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cnd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM yönetici where kullanici_kullanici_adi='" + textBox1.Text + "'AND kullanici_sifre='" + textBox2.Text + "'";
            
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                Yönetici form2 = new Yönetici();
                form2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
            }
            

        }
    }
}