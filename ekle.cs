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
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_islemturu.Text == "")
                {
                    MessageBox.Show("Lütfen İşlem Türünü Seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable gecici = new DataTable();
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=vt.mdb");
                    baglanti.Open();
                    OleDbCommand kont = new OleDbCommand("select * from musteri_bilgi where tc_no like '"+txt_tc.Text+"'",baglanti);
                    OleDbDataAdapter adap = new OleDbDataAdapter(kont);
                    adap.Fill(gecici);
                    if (gecici.Rows.Count == 1)
                    {
                        MessageBox.Show("Bu TC No'ya Sahip Bir Müşteri Zaten Var..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        OleDbCommand komut = new OleDbCommand("insert into musteri_bilgi(tc_no,adi,soyadi,islem_turu,tel_no,islem_ucret,alinan_tutar,kullanici_notu) values (@tc_no,@adi,@soyadi,@islem_turu,@tel_no,@islem_ucret,@alinan_tutar,@kullanici_notu)", baglanti);
                        komut.Parameters.AddWithValue("@tc_no", txt_tc.Text);
                        komut.Parameters.AddWithValue("@adi", txt_ad.Text);
                        komut.Parameters.AddWithValue("@soyadi", txt_soyad.Text);
                        komut.Parameters.AddWithValue("@islem_turu", cmb_islemturu.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@tel_no", txt_telno.Text);
                        komut.Parameters.AddWithValue("@islem_ucret", txt_islemucret.Text);
                        komut.Parameters.AddWithValue("@alinan_tutar", txt_alinantutar.Text);
                        komut.Parameters.AddWithValue("@kullanici_notu", rtb_not.Text);
                        int isuc = Convert.ToInt32(txt_islemucret.Text);
                        int altut = Convert.ToInt32(txt_alinantutar.Text);
                        if (isuc>=altut)
                        {
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Kayıt İşlemi Başarılı...");
                            arayuz frm = new arayuz();
                            frm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Alınan Tutar İşlem Ücretinden Fazla Olamaz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                       
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Verileri Uygun Giriniz...","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
