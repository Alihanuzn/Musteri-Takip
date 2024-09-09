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
    public partial class hesap : Form
    {
        public hesap()
        {
            InitializeComponent();
        }

        private void hesap_Load(object sender, EventArgs e)
        {
            lbl_toplam.Text = Convert.ToString(Program.toplam)+" TL" ;
            lbl_alinan.Text = Convert.ToString(Program.alinan)+ " TL";
            lbl_alinacak.Text = Convert.ToString(Program.kalan) + " TL";
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
