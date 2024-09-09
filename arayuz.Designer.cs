
namespace KilicKasa
{
    partial class arayuz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arayuz));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_silme = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_not = new System.Windows.Forms.RichTextBox();
            this.txt_kalan = new System.Windows.Forms.TextBox();
            this.txt_alinan = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.lbl_kalan = new System.Windows.Forms.Label();
            this.lbl_alinan = new System.Windows.Forms.Label();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.lbl_adi = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.veriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamAlınanTutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vt2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vt2DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_silme
            // 
            this.btn_silme.BackgroundImage = global::KilicKasa.Properties.Resources.if_administrator_delete_67245;
            this.btn_silme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_silme.FlatAppearance.BorderSize = 0;
            this.btn_silme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_silme.Location = new System.Drawing.Point(202, 43);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(184, 162);
            this.btn_silme.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_silme, "Silme");
            this.btn_silme.UseVisualStyleBackColor = true;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.BackgroundImage = global::KilicKasa.Properties.Resources.if_administrator_help_67246;
            this.btn_duzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_duzenle.FlatAppearance.BorderSize = 0;
            this.btn_duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duzenle.Location = new System.Drawing.Point(392, 43);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(184, 162);
            this.btn_duzenle.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_duzenle, "Düzenle");
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = global::KilicKasa.Properties.Resources.if_administrator_add_67244;
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Location = new System.Drawing.Point(12, 43);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(184, 162);
            this.btn_ekle.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_ekle, "Kayıt");
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 398);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtb_not);
            this.groupBox1.Controls.Add(this.txt_kalan);
            this.groupBox1.Controls.Add(this.txt_alinan);
            this.groupBox1.Controls.Add(this.txt_soyadi);
            this.groupBox1.Controls.Add(this.txt_adi);
            this.groupBox1.Controls.Add(this.txt_ara);
            this.groupBox1.Controls.Add(this.lbl_kalan);
            this.groupBox1.Controls.Add(this.lbl_alinan);
            this.groupBox1.Controls.Add(this.lbl_soyadi);
            this.groupBox1.Controls.Add(this.lbl_adi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1034, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 398);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ara :";
            // 
            // rtb_not
            // 
            this.rtb_not.Location = new System.Drawing.Point(30, 207);
            this.rtb_not.Name = "rtb_not";
            this.rtb_not.ReadOnly = true;
            this.rtb_not.Size = new System.Drawing.Size(262, 164);
            this.rtb_not.TabIndex = 10;
            this.rtb_not.Text = "";
            // 
            // txt_kalan
            // 
            this.txt_kalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kalan.Location = new System.Drawing.Point(123, 165);
            this.txt_kalan.Name = "txt_kalan";
            this.txt_kalan.ReadOnly = true;
            this.txt_kalan.Size = new System.Drawing.Size(155, 24);
            this.txt_kalan.TabIndex = 9;
            // 
            // txt_alinan
            // 
            this.txt_alinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_alinan.Location = new System.Drawing.Point(123, 135);
            this.txt_alinan.Name = "txt_alinan";
            this.txt_alinan.ReadOnly = true;
            this.txt_alinan.Size = new System.Drawing.Size(155, 24);
            this.txt_alinan.TabIndex = 8;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyadi.Location = new System.Drawing.Point(123, 105);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.ReadOnly = true;
            this.txt_soyadi.Size = new System.Drawing.Size(155, 24);
            this.txt_soyadi.TabIndex = 7;
            // 
            // txt_adi
            // 
            this.txt_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adi.Location = new System.Drawing.Point(123, 77);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.ReadOnly = true;
            this.txt_adi.Size = new System.Drawing.Size(155, 24);
            this.txt_adi.TabIndex = 6;
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(75, 38);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(167, 24);
            this.txt_ara.TabIndex = 5;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // lbl_kalan
            // 
            this.lbl_kalan.AutoSize = true;
            this.lbl_kalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kalan.Location = new System.Drawing.Point(13, 165);
            this.lbl_kalan.Name = "lbl_kalan";
            this.lbl_kalan.Size = new System.Drawing.Size(104, 18);
            this.lbl_kalan.TabIndex = 4;
            this.lbl_kalan.Text = "Kalan Tutar :";
            // 
            // lbl_alinan
            // 
            this.lbl_alinan.AutoSize = true;
            this.lbl_alinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alinan.Location = new System.Drawing.Point(9, 138);
            this.lbl_alinan.Name = "lbl_alinan";
            this.lbl_alinan.Size = new System.Drawing.Size(107, 18);
            this.lbl_alinan.TabIndex = 3;
            this.lbl_alinan.Text = "Alınan Tutar :";
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.AutoSize = true;
            this.lbl_soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyadi.Location = new System.Drawing.Point(47, 111);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(69, 18);
            this.lbl_soyadi.TabIndex = 2;
            this.lbl_soyadi.Text = "Soyadı :";
            // 
            // lbl_adi
            // 
            this.lbl_adi.AutoSize = true;
            this.lbl_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adi.Location = new System.Drawing.Point(75, 80);
            this.lbl_adi.Name = "lbl_adi";
            this.lbl_adi.Size = new System.Drawing.Size(41, 18);
            this.lbl_adi.TabIndex = 1;
            this.lbl_adi.Text = "Adı :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriEklemeToolStripMenuItem,
            this.veriSilmeToolStripMenuItem,
            this.veriDüzenlemeToolStripMenuItem,
            this.toolStripSeparator1,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 98);
            // 
            // veriEklemeToolStripMenuItem
            // 
            this.veriEklemeToolStripMenuItem.Image = global::KilicKasa.Properties.Resources.if_administrator_add_67244;
            this.veriEklemeToolStripMenuItem.Name = "veriEklemeToolStripMenuItem";
            this.veriEklemeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.veriEklemeToolStripMenuItem.Text = "Veri Ekleme";
            this.veriEklemeToolStripMenuItem.Click += new System.EventHandler(this.veriEklemeToolStripMenuItem_Click);
            // 
            // veriSilmeToolStripMenuItem
            // 
            this.veriSilmeToolStripMenuItem.Image = global::KilicKasa.Properties.Resources.if_administrator_delete_67245;
            this.veriSilmeToolStripMenuItem.Name = "veriSilmeToolStripMenuItem";
            this.veriSilmeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.veriSilmeToolStripMenuItem.Text = "Veri Silme";
            this.veriSilmeToolStripMenuItem.Click += new System.EventHandler(this.veriSilmeToolStripMenuItem_Click);
            // 
            // veriDüzenlemeToolStripMenuItem
            // 
            this.veriDüzenlemeToolStripMenuItem.Image = global::KilicKasa.Properties.Resources.if_administrator_help_67246;
            this.veriDüzenlemeToolStripMenuItem.Name = "veriDüzenlemeToolStripMenuItem";
            this.veriDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.veriDüzenlemeToolStripMenuItem.Text = "Veri Düzenleme";
            this.veriDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.veriDüzenlemeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::KilicKasa.Properties.Resources.carp;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1396, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplamAlınanTutarToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.hesapToolStripMenuItem.Text = "Hesap";
            // 
            // toplamAlınanTutarToolStripMenuItem
            // 
            this.toplamAlınanTutarToolStripMenuItem.Image = global::KilicKasa.Properties.Resources.hesap;
            this.toplamAlınanTutarToolStripMenuItem.Name = "toplamAlınanTutarToolStripMenuItem";
            this.toplamAlınanTutarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.toplamAlınanTutarToolStripMenuItem.Text = "Toplam Tutarlar";
            this.toplamAlınanTutarToolStripMenuItem.Click += new System.EventHandler(this.toplamAlınanTutarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Image = global::KilicKasa.Properties.Resources.carp;
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::KilicKasa.Properties.Resources.hakkinda;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // arayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1396, 640);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "arayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kılıç Kasa Müşteri Veri Bankası v1.0";
            this.Load += new System.EventHandler(this.arayuz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vt2DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_silme;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource vt2DataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamAlınanTutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.TextBox txt_kalan;
        private System.Windows.Forms.TextBox txt_alinan;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label lbl_kalan;
        private System.Windows.Forms.Label lbl_alinan;
        private System.Windows.Forms.Label lbl_soyadi;
        private System.Windows.Forms.Label lbl_adi;
        private System.Windows.Forms.RichTextBox rtb_not;
        private System.Windows.Forms.Label label1;
        // private vt2DataSet vt2DataSet;
    }
}