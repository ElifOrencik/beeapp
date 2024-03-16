using Microsoft.VisualBasic.ApplicationServices;
using System.Media;
namespace beebotappfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                pictureBox2.Image = ýmageList1.Images[i];     //Bu kodlar sayesinde müzik resmine týklayýnca çalýþýp çalýþmamasýna göre belirlenmiþ resim gelir ve müzik açýlýp kapatýlýr.
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = @"C:\Users\elifo\OneDrive\Masaüstü\beebotappfinal\bin\Debug\all-songs.wav"; ;
                ses.Stop();
                i--;
            }
            else
            {
                pictureBox2.Image = ýmageList1.Images[i];
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = @"C:\Users\elifo\OneDrive\Masaüstü\beebotappfinal\bin\Debug\all-songs.wav";
                ses.Play();
                i++;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Bu kýsýmlarda seviyelerin kutularýna týkladýkca o bölüm açýlýr ve bölüm hakkýnda bilgi verme amaciyla messajebox gözükür.
            MessageBox.Show("BU SEVÝYEDE 4 ADET HAMLE HAKKINIZ BULUNMAKTADIR.HAMLELERÝNÝZ VE SÜRENÝZ BÝTMEDEN HEDEFE ULAÞTIÐINIZ AN OYUNU KAZANMIÞ OLURSUNUZ.MÜZÝK TUÞUNA BASARAK OYUN OYNARKEN OYUN MÜZÝÐÝNÝ DÝNLEYEBÝLÝRSÝNÝZ.ÇARPI TUÞUNA BASARAK BU EKRANA DÖNÜP OYUNUN DÝÐER BÖLÜMLERÝNÝ OYNAYABÝLÝRSÝNÝZ.BÖLÜMLERÝ SIRAYLA OYNARAK OYUNUN TADINI ÇIKARTIN. ÝYÝ ÞANSLAR", "BÝLGÝLENDÝRME");
            Form2 form2 = new Form2(); 
            form2.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU SEVÝYEDE 7 ADET HAMLE HAKKINIZ BULUNMAKTADIR.HAMLELERÝNÝZ VE SÜRENÝZ BÝTMEDEN HEDEFE ULAÞTIÐINIZ AN OYUNU KAZANMIÞ OLURSUNUZ.MÜZÝK TUÞUNA BASARAK OYUN OYNARKEN OYUN MÜZÝÐÝNÝ DÝNLEYEBÝLÝRSÝNÝZ.ÇARPI TUÞUNA BASARAK BU EKRANA DÖNÜP OYUNUN DÝÐER BÖLÜMLERÝNÝ OYNAYABÝLÝRSÝNÝZ.BÖLÜMLERÝ SIRAYLA OYNARAK OYUNUN TADINI ÇIKARTIN.BÖLÜM ÝÇERÝSÝNDE ENGELLERÝN ÜSTÜNE ÇIKMANIZ ÝMKANSIZDIR.TAÞ YOLDAN HAMLELERLE ÝLERLEYEREK HEDEFE ULAÞINIZ. ÝYÝ ÞANSLAR", "BÝLGÝLENDÝRME");
            Form3 form3 = new Form3(); 
            form3.Show();
            this.Hide();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU SEVÝYEDE 7 ADET HAMLE HAKKINIZ BULUNMAKTADIR.HAMLELERÝNÝZ VE SÜRENÝZ BÝTMEDEN HEDEFE ULAÞTIÐINIZ AN OYUNU KAZANMIÞ OLURSUNUZ.MÜZÝK TUÞUNA BASARAK OYUN OYNARKEN OYUN MÜZÝÐÝNÝ DÝNLEYEBÝLÝRSÝNÝZ.ÇARPI TUÞUNA BASARAK BU EKRANA DÖNÜP OYUNUN DÝÐER BÖLÜMLERÝNÝ OYNAYABÝLÝRSÝNÝZ.BÖLÜMLERÝ SIRAYLA OYNARAK OYUNUN TADINI ÇIKARTIN.BÖLÜM ÝÇERÝSÝNDE KÖTÜ ARIDAN UZAK DURUN.ONA DEÐDÝÐÝNÝZ ZAMAN OYUNU KAYBEDERSÝNÝZ ÇÝÇEÐÝN ÜSTÜNE TIKLAYARAK ARI VE ÇÝÇEÐÝN YERÝNÝ DEÐÝÞTÝREREK ÇÝÇEÐE ULAÞMAYI SAÐLAYABÝLÝRSÝNÝZ..TAÞ YOLDAN HAMLELERLE ÝLERLEYEREK HEDEFE ULAÞINIZ. ÝYÝ ÞANSLAR", "BÝLGÝLENDÝRME");
            Form4 form4 = new Form4(); 
            form4.Show();
            this.Hide();
        }
        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            //Soru iþsaretine týklandýðý zaman oyunun her bölümüne ait bilgi verilir.
            string bilgiler = "OYUN HAKKINDA BÝLGÝLER\n\n" +
             "1. bölüm: Bu bölümde amacýmýz çiçeðe en kýsa sürede, hamleleri bitirmeden ve sýnýrlarý geçmeden ulaþmaktýr. " +
             "Sýnýrlarý geçtiðiniz zaman uyarý gelir ve dýþarý çýkamazsýnýz. Sýnýrlarý geçmeniz sonucu bölüme tekrar baþlamak zorundasýnýz. " +
             "Çiçeðe ulaþtýðýnýzda bölümü bitirmiþ olursunuz. Sürenin bitmesi, sýnýrý geçmeniz ve hamle hakkýnýzý bitirmeniz sonucu " +
             "bölümü tekrar oynamak üzere çarpýya týklayarak oyunun ana kýsmýna dönerbilirsiniz.\n\n" +
             "2. bölüm: Bu bölümde diðer iki bölümün harici olarak tuþlara basýldýðý an hareket edilir. " +
             "Kenarlarda bulunan engellerin üstüne çýkýlamaz, taþ yol üstünden ileri geri sað ve sol hareket edilir.Yine ayný þartlar doðrultusu oyunu kazanýr veya kaybedersiniz.\n\n" +
             "3. bölüm: Bu bölümde ise bir kötü karakterimiz var ve bu kötü karaktere deðince yanýyoruz. " +
             "Kötü arýya deðmemek için öncelikle çiçeðin üstüne týklayarak kötü arý ile çiçeðin yerini deðiþtirip ve çiçeðe olan ulaþýmý saðlayarak " +
             "kýsa sürede bitirmemizi saðlýyoruz.";
            MessageBox.Show(bilgiler, "OYUN HAKKINDA BÝLGÝLER");
        }
        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            //Formdan çýkýnca uygulamanýn kapanmasýný saðlar
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //oyundan çýkýþ resmine týklanýnca uygulamanýn kapanmasýný saðlar.
            Application.Exit();
        }
    }
}