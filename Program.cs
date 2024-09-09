using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KilicKasa
{
    static class Program
    {
        public static string tc_no, adi, soyadi, tel_no, islem_ucret, alinan_tutar,kalan_tutar, islem_turu, not;
        public static int alinan, kalan, toplam;
       // public static ArrayList kullanici = new ArrayList();
      //  public static ArrayList sifre = new ArrayList();
       // public static string kulllaniciKontrol, sifreKontrol;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new giris_ekrani());
        }
    }
}
