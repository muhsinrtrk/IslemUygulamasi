using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslemUygulamasi
{
    public partial class frmIslemuygulaması : Form
    {
        public frmIslemuygulaması()
        {
            InitializeComponent();
        }
        public static void dosyaYaz(string bilgi)
        {
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;
            string logFilePath = ("D:\\Log.txt");
            logFilePath = logFilePath + " Tarih-" + System.DateTime.Today.ToString("dd-MM-yyyy") + "." + "txt";
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(bilgi);
            log.Close();
        }
        private void EkranDuzenle(bool islembasarili)
        {
            if (islembasarili == true)
            {
                mtxtBaslangic.Text = mtxtBitis.Text = "0";
            }
            mtxtBaslangic.Focus();
        }
        Boolean Dogrula(int baslangic, int bitis)
        {
            return (bitis > baslangic && bitis <10000) ? true : false;
        }
        private void LogTekyaz(string mesaj)
        {
            lstvTeksayilar.Items.Add(mesaj);
        }
        private void LogCiftyaz(string mesaj1)
        {
            lstvCiftsayilar.Items.Add(mesaj1);
        }
        private void LogAsalyaz(string mesaj)
        {
            lstvAsalsayilar.Items.Add(mesaj);
        }
        private void LogArmstrongyaz(string mesaj)
        {
            lstvArmstrongsayilar.Items.Add(mesaj);
        }
        public void fonkTeksayilar(int fBaslangic, int fBitis)
        {
            int[] Teksayilar = new int[10000];
            BigInteger tekToplam = 0, tekCarpim = 1;
            for (int i = fBaslangic; i <= fBitis; i++)
            {
                if ((i % 2) != 0)
                {
                    Teksayilar[i] = i;
                    LogTekyaz("Tek Sayı: " + Teksayilar[i]);
                    tekToplam += Teksayilar[i];
                    tekCarpim *= Teksayilar[i];
                    dosyaYaz(Convert.ToString(Teksayilar[i]));
                }
            }
            LogTekyaz("Tek Sayı Toplamı: " + tekToplam);
            LogTekyaz("Tek Sayı Çarpımı: " + tekCarpim);
            dosyaYaz("Tek Sayıların Toplamları: " + Convert.ToString(tekToplam));
            dosyaYaz("Tek Sayıların Çarpımları: " + Convert.ToString(tekCarpim));
        }
        public void fonkCiftsayilar(int fBaslangic, int fBitis)
        {
            int[] Ciftsayilar = new int[10000];
            BigInteger ciftToplam = 0, ciftCarpim = 1;
            for (int i = fBaslangic; i <= fBitis; i++)
            {
                if ((i % 2) == 0)
                {
                    Ciftsayilar[i] = i;
                    LogCiftyaz("Çift Sayı: " + Ciftsayilar[i]);
                    ciftToplam += Ciftsayilar[i];
                    ciftCarpim *= Ciftsayilar[i];
                    dosyaYaz(Convert.ToString(Ciftsayilar[i]));
                }
            }
            LogCiftyaz("Çift Sayı Toplamı: " + ciftToplam);
            LogCiftyaz("Çift Sayı Çarpımı: " + ciftCarpim);
            dosyaYaz("Çift Sayıların Toplamları: " + Convert.ToString(ciftToplam));
            dosyaYaz("Çift Sayıların Toplamları: " + Convert.ToString(ciftCarpim));
        }
        public void fonkAsalsayilar(int fBaslangic, int fBitis)
        {
            BigInteger asalSayacToplam = 0, asalSayacCarpim = 1;
            for (int asalSayac = fBaslangic; asalSayac <= fBitis; asalSayac++)
            {
                int kontrol = 0;
                for (int j = 2; j < asalSayac; j++)
                {
                    if ((asalSayac % j) == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol != 1 && asalSayac != 1)
                {
                    LogAsalyaz("Asal Sayı: " + asalSayac);
                    asalSayacToplam += asalSayac;
                    asalSayacCarpim *= asalSayac;
                    dosyaYaz(Convert.ToString(asalSayac));
                }
            }
            LogAsalyaz("Asal Sayı Toplamı:" + asalSayacToplam);
            LogAsalyaz("Asal Sayı Carpımı:" + asalSayacCarpim);
            dosyaYaz("Asal Sayıların Toplamları: " + Convert.ToString(asalSayacToplam));
            dosyaYaz("Asal Sayıların Toplamları: " + Convert.ToString(asalSayacCarpim));
        }
        public void fonkArmstrongsayilar(int fBaslangic, int fBitis)
        {
            BigInteger armstrongToplam = 0, armstrongCarpim = 1;
            int armstrongSayac, basamaksayısı, toplamDeger, geciciDeger;
            for (armstrongSayac = fBaslangic; armstrongSayac <= fBitis; armstrongSayac++)
            {
                geciciDeger = armstrongSayac;
                toplamDeger = 0;

                while (geciciDeger != 0)
                {
                    basamaksayısı = geciciDeger % 10;
                    geciciDeger = geciciDeger / 10;
                    toplamDeger = toplamDeger + (basamaksayısı * basamaksayısı * basamaksayısı);
                }
                if (toplamDeger == armstrongSayac)
                {
                    LogArmstrongyaz("Armstrong Sayıları: " + armstrongSayac);
                    armstrongToplam += armstrongSayac;
                    armstrongCarpim *= armstrongSayac;
                    dosyaYaz(Convert.ToString(armstrongSayac));
                }
            }
            LogArmstrongyaz("Armstrong Sayı Toplamları: " + armstrongToplam);
            LogArmstrongyaz("Armstrong Sayı Çarpımları: " + armstrongCarpim);
            dosyaYaz("Armstrong Sayıların Toplamları: " + Convert.ToString(armstrongToplam));
            dosyaYaz("Armstrong Sayıların Toplamları: " + Convert.ToString(armstrongCarpim));
        }
        public int Ustsinir = 3, Altsinir = 0, Tabnumarası = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(mtxtBaslangic.Text);
            int bitis = Convert.ToInt32(mtxtBitis.Text);
            if (Dogrula(baslangic, bitis))
            {
                if (Tabnumarası == 0)
                {
                    fonkTeksayilar(baslangic, bitis);

                }
                if (Tabnumarası == 1)
                {
                    fonkCiftsayilar(baslangic, bitis);
                }
                if (Tabnumarası == 2)
                {
                    fonkAsalsayilar(baslangic, bitis);
                }
                if (Tabnumarası == 3)
                {
                    fonkArmstrongsayilar(baslangic, bitis);
                } 
            }
            else 
            {
                MessageBox.Show("Başlangıç bitişten büyük!!! veya Birişi 10000'den büyük yazdınız!!!+");
            }
        }
        [Obsolete]
        private void frmIslemuygulaması_Shown(object sender, EventArgs e)
        {
            EkranDuzenle(true);
            nfyiResim.ShowBalloonTip(1500, "İşlem Uygulamasına Hoş Geldiniz!", "Nesne Yünelimli Proğramlama Ödevi1", ToolTipIcon.Info);
            string islemtipi = System.Configuration.ConfigurationSettings.AppSettings["islem_tipi"];
            if (islemtipi == "Tek Sayilar")
            {
                tbcIslemler.SelectedIndex = 0;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnIleri_Click(object sender, EventArgs e)
        {
            if(Ustsinir != Tabnumarası)
            {
                Tabnumarası += 1;
                tbcIslemler.SelectTab(Tabnumarası);
            }
            EkranDuzenle(true);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if(Altsinir != Tabnumarası)
            {
                Tabnumarası -= 1;
                tbcIslemler.SelectTab(Tabnumarası);
            }
            EkranDuzenle(true);
        }
    }
}
