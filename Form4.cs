using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace beebotappfinal
{
    public partial class Form4 : Form
    {
        

        private int pictureBoxSpeed2 = 100; //hareket için kabul edilen px miktarımız
        private int hak2 = 5; // bölüm için kabul edilen hak 
        private int puan2 = 0; //puan hesaplamak için değişekn
        private int sayac2 = 0; //progressbar dolumu için değişken
        private int i = 0; // müzik açma kapama  için değişken
        private string yildiz2;  // oyun sonu ekranda yazdırılan mesaj için değişken
        private int x;  //arının x koordinatı
        private int y; //arının y koordinatı
        private int yukaris2 = 0; //yön tuları sonucu artan ve bu artısa göre hareket sınırı belirlemek için yaptığımız değişken
        private int asagis2 = 0;
        private int sagas2 = 0;
        private int solas2 = 0;
        private int a;  // yukarigit fonksiyonarlının kaç defa basıldığına göre döngü sayesinde işlemi gerçekleştirmek amacıyla verilmiş değişken(a b c d her yön için ayrı değpişkendir)
        private int b;
        private int c;
        private int d;
        private bool mesajGosterildiYukari = false;  // mesajların sadece 1 kere gösterilmesi için koyduğumuz 1 ve 0 a göre ayarlanmış değişkenler
        private bool mesajGosterildiAsagi = false;
        private bool mesajGosterildiSaga = false;
        private bool mesajGosterildiSola = false;
        private bool resmidegistir = false; // çiçek ve kötü arının yerinin sadece 1 kere değişmesini sağlayan değişken
    
    
        public Form4()
        {
            InitializeComponent();
            x = player1.Location.X;   // arının x ve y lokasyonu 
            y = player1.Location.Y;
        }
        private void yukarigit2()         // bu fonksiyonlaraa göre arının kare sınırlarına göre kontrol edilmesi sonucu hareket  edip etmemesini eğer sınır dısında ise mesaj ile uyarı göndermesini sağlar.
        {                                 // ve yeni lokasyonu sonucu arıyı yönlendirir
            if (yukaris2 > 0)
            {
                if (y > 3)
                {
                    y -= pictureBoxSpeed2;
                    hak2--;
                    player1.Image = ımageList2.Images[1];
                }
                else if (!mesajGosterildiYukari)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("YUKARIYA GİDİLEMEZ");
                    mesajGosterildiYukari = true;
                }
            }
            yukaris2--;
            player1.Location = new Point(x, y);
        }
        private void asagigit2()
        {
            if (asagis2 > 0)
            {
                if (y < 203)
                {
                    y += pictureBoxSpeed2;
                    hak2--;
                    player1.Image = ımageList2.Images[3];
                }
                else if (!mesajGosterildiAsagi)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("AŞAĞIYA GİDİLEMEZ");
                    mesajGosterildiAsagi = true;
                }
            }
            asagis2--;
            player1.Location = new Point(x, y);
        }
        private void sagagit2()
        {
            if (sagas2 > 0)
            {
                if (x < 235)
                {
                    x += pictureBoxSpeed2;
                    hak2--;
                    player1.Image = ımageList2.Images[2];
                }
                else if (!mesajGosterildiSaga)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("SAĞA GİDİLEMEZ");
                    mesajGosterildiSaga = true;
                }
            }
            
            sagas2--;
            player1.Location = new Point(x, y);
        }
        private void solagit2()
        {
            if (solas2 > 0)
            {
                if (x > 35)
                {
                    x -= pictureBoxSpeed2;
                    hak2--;
                    player1.Image = ımageList2.Images[0];
                }
                else if (!mesajGosterildiSola)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("SOLA GİDİLEMEZ");
                    mesajGosterildiSola = true;
                }
            }
            solas2--;
            player1.Location = new Point(x, y);
        }
        private void butonlarikapa2()
        {
            yuvarlakbutonClass12.Enabled = false;
            yuvarlakbutonClass11.Enabled = false;
            yuvarlakbutonClass13.Enabled = false;
            yuvarlakbutonClass14.Enabled = false;
        }
        private void butonlariac2()
        {
            yuvarlakbutonClass12.Enabled = true;
            yuvarlakbutonClass11.Enabled = true;
            yuvarlakbutonClass13.Enabled = true;
            yuvarlakbutonClass14.Enabled = true;
        }
        private void sonuc()
        {
            if (player1.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                if (hak2 > 0)
                {
                    puan2 = 2;
                }
                if (progressBar1.Value <= 25)
                {
                    puan2 += 4;
                }
                else if (progressBar1.Value <= 50)
                {
                    puan2 += 3;
                }
                else if (progressBar1.Value <= 75)
                {
                    puan2 += 2;
                }
                else if (progressBar1.Value < 100)
                {
                    puan2 += 1;
                }
                if (puan2 == 6)
                {
                    yildiz2 = "3 yıldız ile bu bölümü sonlandırdınız.";
                }
                else if (puan2 == 5)
                {
                    yildiz2 = "2 yıldız ile bu bölümü sonlandırdınız.";
                }
                else if (puan2 == 4)
                {
                    yildiz2 = "1 yıldız ile bu bölümü sonlandırdınız.";
                }
                else
                {
                    yildiz2 = "0 yıldız ile bu bölümü sonlandırdınız.";
                }
                MessageBox.Show(yildiz2, "TEBRİKLER");
                butonlarikapa2();
                timer1.Stop();
            }
            else if (hak2 <= 0)
            {
                yildiz2 = "Oyunu kaybettiniz.Tüm haklarınız bitti!";
                MessageBox.Show(yildiz2, "ÜZGÜNÜZ");
                butonlarikapa2();
                timer1.Stop();
            }
            if (player1.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                timer1.Stop();
                yildiz2 = "Kötü arıya değerek kaybettiniz.";
                MessageBox.Show(yildiz2, "ÜZGÜNÜZ");
                butonlarikapa2();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                pictureBox2.Image = ımageList1.Images[i];
                i--;
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation =  @"C:\Users\elifo\OneDrive\Masaüstü\beebotappfinal\bin\Debug\all-songs.wav"; 
                ses.Stop();
            }
            else
            {
                pictureBox2.Image = ımageList1.Images[i];
                i++;
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = @"C:\Users\elifo\OneDrive\Masaüstü\beebotappfinal\bin\Debug\all-songs.wav";
                ses.Play();
            }
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void yuvarlakbutonClass12_Click(object sender, EventArgs e)
        {
            yukaris2++;
        }
        private void yuvarlakbutonClass13_Click(object sender, EventArgs e)
        {
            sagas2++;
        }
        private void yuvarlakbutonClass11_Click(object sender, EventArgs e)
        {
            solas2++;
        }
        private void yuvarlakbutonClass14_Click(object sender, EventArgs e)
        {
            asagis2++;
        }
        private void yuvarlakbutonClass15_Click(object sender, EventArgs e)
        {
            {
                for (a = 0; a <= yukaris2; a++)
                {
                    yukarigit2();
                }
                for (b = 0; b <= asagis2; b++)
                {
                    asagigit2();
                }
                for (c = 0; c <= sagas2; c++)
                {
                    sagagit2();
                }
                for (d = 0; d <= solas2; d++)
                {
                    solagit2();
                }
            }
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            int z;
            int w;
            int q;
            int s;
            z = pictureBox18.Location.X;
            w = pictureBox18.Location.Y;
            q = pictureBox12.Location.X;
            s = pictureBox12.Location.Y;
            if (resmidegistir == false) // sadece bi kere değişmesi için 1 0 kontrolu yaptıktan sonra arının  x koordinatını 100 arttırıp çiçeğin x koordinatını 100 azalttık
            {
                q += 100;
                z -= 100;
                resmidegistir = true;
            }
            pictureBox18.Location = new Point(z, w);
            pictureBox12.Location = new Point(q, s);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (progressBar1.Value <= 99 && hak2 > 0 && !player1.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                timer1.Stop();
                if (progressBar1.Value == 100)
                {
                    yildiz2 = "Oyunu kaybettiniz";
                    MessageBox.Show(yildiz2, "ÜZGÜNÜZ");
                    butonlarikapa2();
                }
            }
            sonuc();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            MessageBox.Show("KÖTÜ ARIDAN UZAK DURUN.ONA DEĞERSENİZ KAYBEDERSİNİZ.ÇİÇEĞİN ÜSTÜNE TIKLAYARAK ARI VE ÇİÇEĞİN YERİNİ DEĞİŞTİREBİLİR BÖYLECE İYİ ARINI ÇİÇEĞE ULAŞIMINI KOLAYLAŞTIRABİLİRSİNİZ");
            timer1.Enabled = true;
        }
    }
}
