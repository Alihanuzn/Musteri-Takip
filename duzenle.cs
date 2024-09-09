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
    public partial class duzenle : Form
    {
        public duzenle()
        {
            InitializeComponent();
        }

        private void duzenle_Load(object sender, EventArgs e)
        {
            txt_tc.Text = Program.tc_no;
            txt_ad.Text = Program.adi;
            txt_soyad.Text = Program.soyadi;
            cmb_islemturu.SelectedItem = Program.islem_turu;
            txt_telno.Text = Program.tel_no;
            txt_islemucret.Text = Program.islem_ucret;
            txt_alinantutar.Text = Program.alinan_tutar;
            rtb_not.Text = Program.not;
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_islemturu.Text == "")
                {
                    MessageBox.Show("Lütfen İşlem Türünü Seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int karaktersayisi = txt_tc.TextLength;
                    if (karaktersayisi == 11)
                    {
                        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=vt.mdb");
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand("update musteri_bilgi set adi=@adi,soyadi=@soyadi,islem_turu=@islem_turu,tel_no=@tel_no,islem_ucret=@islem_ucret,alinan_tutar=@alinan_tutar,kullanici_notu=@kullanici_notu where tc_no=@tc_no", baglanti);
                        komut.Parameters.AddWithValue("@adi", txt_ad.Text);
                        komut.Parameters.AddWithValue("@soyadi", txt_soyad.Text);
                        komut.Parameters.AddWithValue("@islem_turu", cmb_islemturu.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@tel_no", txt_telno.Text);
                        komut.Parameters.AddWithValue("@islem_ucret", txt_islemucret.Text);
                        komut.Parameters.AddWithValue("@alinan_tutar", txt_alinantutar.Text);
                        komut.Parameters.AddWithValue("@kullanici_notu", rtb_not.Text);
                        komut.Parameters.AddWithValue("@tc_no", txt_tc.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Düzenleme İşlemi Başarı İle Gerçekleşti...");
                        arayuz frm = new arayuz();
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("TC No 11 Haneli Olmalıdır...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Verileri Uygun Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            arayuz frm = new arayuz();
            frm.Show();
            this.Close();
        }
    }
}
