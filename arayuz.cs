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
    public partial class arayuz : Form
    {
      
        public arayuz()
        {
            InitializeComponent();
        }
        void gridAyari()
        {
            dataGridView1.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            dataGridView1.Columns["tc_no"].HeaderText = "TC No";
            dataGridView1.Columns["adi"].HeaderText = "Adı";
            dataGridView1.Columns["soyadi"].HeaderText = "Soyadı";
            dataGridView1.Columns["islem_turu"].HeaderText = "İşlem Türü";
            dataGridView1.Columns["tel_no"].HeaderText = "Telefon No";
            dataGridView1.Columns["islem_ucret"].HeaderText = "İşlem Ücreti";
            dataGridView1.Columns["alinan_tutar"].HeaderText = "Alınan Tutar";
            dataGridView1.Columns["kalan_tutar"].HeaderText = "Kalan Tutar";
            dataGridView1.Columns["kullanici_notu"].HeaderText = "Not";
            dataGridView1.Columns["kullanici_notu"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["tc_no"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["adi"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["soyadi"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["islem_turu"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["tel_no"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["islem_ucret"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["alinan_tutar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["kalan_tutar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["islem_turu"].Width = 150;
            dataGridView1.Columns["tc_no"].Width = 90;
            dataGridView1.Columns["tel_no"].Width = 90;
            dataGridView1.Columns["islem_ucret"].Width = 60;
            dataGridView1.Columns["alinan_tutar"].Width = 60;
            dataGridView1.Columns["kalan_tutar"].Width = 60;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void listele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=vt.mdb");
            baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from musteri_bilgi", baglanti);
            adtr.Fill(ds, "okunan bilgi");
            dataGridView1.DataSource = ds.Tables["okunan bilgi"];
            gridAyari();
            baglanti.Close();

        }
        public void hesapla()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=vt.mdb");
            baglanti.Open();
            int satir = dataGridView1.Rows.Count ;
            int toptutar = 0;
            for (int i = 0; i < satir; i++)
            {
                toptutar += Convert.ToInt32(dataGridView1.Rows[i].Cells["islem_ucret"].Value);
            }
            Program.toplam = toptutar;
            int alinantutar = 0;
            for (int i = 0; i < satir; i++)
            {
                alinantutar += Convert.ToInt32(dataGridView1.Rows[i].Cells["alinan_tutar"].Value);
            }
            Program.alinan = alinantutar;
            int kalantutar = 0;
            for (int i = 0; i < satir; i++)
            {
                kalantutar += Convert.ToInt32(dataGridView1.Rows[i].Cells["kalan_tutar"].Value);
            }
            Program.kalan = kalantutar;

            baglanti.Close();
        }
       

        private void arayuz_Load(object sender, EventArgs e)
        {

            listele();
           
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            ekle frm = new ekle();
            frm.Show();
            this.Close();
        }
        string secili_kayit;
        bool kontrol = false;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secili = dataGridView1.SelectedCells[0].RowIndex;
                secili_kayit = dataGridView1.Rows[secili].Cells[0].Value.ToString();
                kontrol = true;
                Program.tc_no = dataGridView1.Rows[secili].Cells[0].Value.ToString();
                Program.adi = dataGridView1.Rows[secili].Cells[1].Value.ToString();
                Program.soyadi = dataGridView1.Rows[secili].Cells[2].Value.ToString();
                Program.islem_turu = dataGridView1.Rows[secili].Cells[3].Value.ToString();
                Program.tel_no = dataGridView1.Rows[secili].Cells[4].Value.ToString();
                Program.islem_ucret = dataGridView1.Rows[secili].Cells[5].Value.ToString();
                Program.alinan_tutar = dataGridView1.Rows[secili].Cells[6].Value.ToString();
                Program.kalan_tutar = dataGridView1.Rows[secili].Cells[7].Value.ToString();
                Program.not = dataGridView1.Rows[secili].Cells[8].Value.ToString();
                txt_adi.Text = Program.adi;
                txt_soyadi.Text = Program.soyadi;
                txt_alinan.Text = Program.alinan_tutar + " TL";
                txt_kalan.Text = Program.kalan_tutar + " TL";
                rtb_not.Text = Program.not;
            }
            catch
            {
              
            }

        }

        private void btn_silme_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=vt.mdb");
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand("delete from musteri_bilgi where tc_no=@tc_no", baglanti);
                sil.Parameters.AddWithValue("@tc_no", secili_kayit);
                DialogResult onay = MessageBox.Show(secili_kayit + " TC Nolu Kişiyi Silmek İstediğinize Emin Misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşti...");
                }
                baglanti.Close();
                listele();
                txt_adi.Clear();
                txt_soyadi.Clear();
                txt_alinan.Clear();
                txt_kalan.Clear();
                txt_ara.Clear();
                rtb_not.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                duzenle frm = new duzenle();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Çıkış İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void veriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekle frm = new ekle();
            frm.Show();
            this.Close();
        }

        private void veriDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                duzenle frm = new duzenle();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void veriSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=vt.mdb");
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand("delete from musteri_bilgi where tc_no=@tc_no", baglanti);
                sil.Parameters.AddWithValue("@tc_no", secili_kayit);
                DialogResult onay = MessageBox.Show(secili_kayit + " TC Nolu Kişiyi Silmek İstediğinize Emin Misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşti...");
                }
                baglanti.Close();
                listele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz!");
            }
        }

        private void toplamAlınanTutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapla();
            hesap frm = new hesap();
            frm.Show();
        }

       

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Çıkış İşlemi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

      

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=vt.mdb");
            baglanti.Open();
            
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from musteri_bilgi where tc_no like '"+txt_ara.Text+ "%' or adi like '" + txt_ara.Text + "%' or soyadi like '" + txt_ara.Text + "%'", baglanti);
            DataTable secili = new DataTable();
            adtr.Fill(secili);
            dataGridView1.DataSource = secili;
            gridAyari();
            baglanti.Close();

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkinda frm = new hakkinda();
            frm.Show();
        }
    }
}
