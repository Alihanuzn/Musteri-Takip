
namespace KilicKasa
{
    partial class duzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.cmb_islemturu = new System.Windows.Forms.ComboBox();
            this.rtb_not = new System.Windows.Forms.RichTextBox();
            this.txt_islemucret = new System.Windows.Forms.TextBox();
            this.txt_telno = new System.Windows.Forms.TextBox();
            this.txt_alinantutar = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btn_iptal);
            this.groupBox1.Controls.Add(this.btn_kayit);
            this.groupBox1.Controls.Add(this.cmb_islemturu);
            this.groupBox1.Controls.Add(this.rtb_not);
            this.groupBox1.Controls.Add(this.txt_islemucret);
            this.groupBox1.Controls.Add(this.txt_telno);
            this.groupBox1.Controls.Add(this.txt_alinantutar);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 573);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Düzenle";
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_iptal.BackgroundImage = global::KilicKasa.Properties.Resources.carp;
            this.btn_iptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.FlatAppearance.BorderSize = 0;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iptal.Location = new System.Drawing.Point(197, 461);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(145, 88);
            this.btn_iptal.TabIndex = 17;
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kayit.BackgroundImage = global::KilicKasa.Properties.Resources.if_Symbol___Check_58687;
            this.btn_kayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kayit.FlatAppearance.BorderSize = 0;
            this.btn_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayit.Location = new System.Drawing.Point(13, 461);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(145, 88);
            this.btn_kayit.TabIndex = 16;
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // cmb_islemturu
            // 
            this.cmb_islemturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_islemturu.FormattingEnabled = true;
            this.cmb_islemturu.Items.AddRange(new object[] {
            "Yeni Kasa (Standart 260cm)",
            "Tamir",
            "Canlı Hayvan Aracı Kapağı",
            "Çatı",
            "Tekli İlave",
            "Çifli İlave",
            "Arka Koruma Borusu",
            "Özel"});
            this.cmb_islemturu.Location = new System.Drawing.Point(133, 155);
            this.cmb_islemturu.Name = "cmb_islemturu";
            this.cmb_islemturu.Size = new System.Drawing.Size(209, 26);
            this.cmb_islemturu.TabIndex = 15;
            // 
            // rtb_not
            // 
            this.rtb_not.Location = new System.Drawing.Point(13, 306);
            this.rtb_not.Name = "rtb_not";
            this.rtb_not.Size = new System.Drawing.Size(329, 149);
            this.rtb_not.TabIndex = 14;
            this.rtb_not.Text = "";
            // 
            // txt_islemucret
            // 
            this.txt_islemucret.Location = new System.Drawing.Point(133, 217);
            this.txt_islemucret.Name = "txt_islemucret";
            this.txt_islemucret.Size = new System.Drawing.Size(209, 24);
            this.txt_islemucret.TabIndex = 13;
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(133, 187);
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(209, 24);
            this.txt_telno.TabIndex = 12;
            // 
            // txt_alinantutar
            // 
            this.txt_alinantutar.Location = new System.Drawing.Point(133, 247);
            this.txt_alinantutar.Name = "txt_alinantutar";
            this.txt_alinantutar.Size = new System.Drawing.Size(209, 24);
            this.txt_alinantutar.TabIndex = 11;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(133, 127);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(209, 24);
            this.txt_soyad.TabIndex = 10;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(133, 97);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(209, 24);
            this.txt_ad.TabIndex = 9;
            // 
            // txt_tc
            // 
            this.txt_tc.Enabled = false;
            this.txt_tc.Location = new System.Drawing.Point(133, 67);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(209, 24);
            this.txt_tc.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Not :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Alınan Tutar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "İşlem Ücreti :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "İşlem Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No :";
            // 
            // duzenle
            // 
            this.AcceptButton = this.btn_kayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_iptal;
            this.ClientSize = new System.Drawing.Size(379, 597);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "duzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "duzenle";
            this.Load += new System.EventHandler(this.duzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.ComboBox cmb_islemturu;
        private System.Windows.Forms.RichTextBox rtb_not;
        private System.Windows.Forms.TextBox txt_islemucret;
        private System.Windows.Forms.TextBox txt_telno;
        private System.Windows.Forms.TextBox txt_alinantutar;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}