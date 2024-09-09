
namespace KilicKasa
{
    partial class hesap
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
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.lbl_alinan = new System.Windows.Forms.Label();
            this.lbl_alinacak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.lbl_toplam);
            this.groupBox1.Controls.Add(this.lbl_alinan);
            this.groupBox1.Controls.Add(this.lbl_alinacak);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_kayit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(239, 162);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(207, 31);
            this.lbl_toplam.TabIndex = 22;
            this.lbl_toplam.Text = "00000";
            this.lbl_toplam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_alinan
            // 
            this.lbl_alinan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_alinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alinan.Location = new System.Drawing.Point(239, 107);
            this.lbl_alinan.Name = "lbl_alinan";
            this.lbl_alinan.Size = new System.Drawing.Size(207, 31);
            this.lbl_alinan.TabIndex = 21;
            this.lbl_alinan.Text = "00000";
            this.lbl_alinan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_alinacak
            // 
            this.lbl_alinacak.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_alinacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alinacak.Location = new System.Drawing.Point(239, 48);
            this.lbl_alinacak.Name = "lbl_alinacak";
            this.lbl_alinacak.Size = new System.Drawing.Size(207, 31);
            this.lbl_alinacak.TabIndex = 20;
            this.lbl_alinacak.Text = "00000";
            this.lbl_alinacak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Toplam Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alınan Tutar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Alınacak Tutar :";
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kayit.BackgroundImage = global::KilicKasa.Properties.Resources.if_Symbol___Check_58687;
            this.btn_kayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kayit.FlatAppearance.BorderSize = 0;
            this.btn_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayit.Location = new System.Drawing.Point(176, 232);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(145, 88);
            this.btn_kayit.TabIndex = 16;
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 378);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hesap";
            this.Load += new System.EventHandler(this.hesap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.Label lbl_alinan;
        private System.Windows.Forms.Label lbl_alinacak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kayit;
    }
}