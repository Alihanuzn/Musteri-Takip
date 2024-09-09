using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KilicKasa
{
    public partial class giris_ekrani : Form
    {
        private const string V = "SELECT * FROM kadi_sifre WHERE Kullanıcı Adı=@kadi AND Şifre=@sifre";

        public giris_ekrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?","Çıkış İşlemi",MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
               // Program.kullanici.Add("alihan");
               // Program.sifre.Add("1234");
               // Program.kulllaniciKontrol = txt_kul.Text;
              //  Program.sifreKontrol = txt_sif.Text;
                OleDbConnection con;
                OleDbCommand cmd;
                OleDbDataReader dr;
                int i = 0;
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=vt.mdb");
                string a, b;
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ("SELECT * FROM kadi_sifre");
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a = dr["kadi"].ToString();
                    b = dr["sifre"].ToString();
                    if (a == txt_kul.Text && b == txt_sif.Text)
                    {
                       // MessageBox.Show("Hoş Geldiniz", "GİRİŞ BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        arayuz frm2 = new arayuz();
                        frm2.Show();
                        this.Hide();
                        con.Close();
                        i = 1;
                        break;
                    }
                }
                if (txt_kul.Text == "")
                {
                    MessageBox.Show("Lütfen Kullanıcı Adı Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    i = 1;
                }
                else if (txt_sif.Text == "")
                {
                    MessageBox.Show("Lütfen Şifre Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    i = 1;
                }
                if (i == 0)
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            
             con.Close();

                /*   if (Program.kullanici.Contains(Program.kulllaniciKontrol)==true && Program.sifre.Contains(Program.sifreKontrol)==true)
                  {
                      arayuz frm = new arayuz();
                      frm.Show();
                      this.Visible = false;
                  }

                else
                 {

                     MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı Lütfen Yeniden Deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }*/
            }
            catch
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre ile Giriş Yapınız...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_kul.Clear();
                txt_sif.Clear();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt_kul.Clear();
            txt_sif.Clear();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Çıkış İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
