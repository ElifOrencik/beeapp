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
using System.Numerics;

namespace beebotappfinal
{
    public partial class Form2 : Form
    {
        private int pictureBoxSpeed1 = 100; //Hareket sonucu ilerlenecek piksel için değişken belirledik her yer değişimi sonucu 100px değişimi oluşucak.
        private int hak1 = 4; //her bölüm için atanan hak 
        private int puan1 = 0; //kaç yıldızla bittiğini hesaplamak için değişken
        private int sayac1 = 0; // progress barı doldurmak için değişken 
        private int i = 0; // müziği açıp kapamak için değişken
        private string yildiz1; // kaç yıldızla bittiğini yazdırmak için atadığımız değişken
        private int yukaris = 0; // yukarı butonuna her tıklandığı zaman artmasını ve bu artış sonucu işlem yapmayı sağladık
        private int asagis = 0;  
        private int sagas = 0;
        private int solas = 0;
        private bool mesajGosterildi = false;  //sınırları geçmesi sonucu ekranda çıkan mesajın 1 kere yazılmasını sağlayan 0 ve 1 ile kontrol edilen değişkenler
        private bool mesajGosterildi2 = false;
        private bool mesajGosterildi3 = false;
        private bool mesajGosterildi4 = false;
        private void butonlarikapa()
        {
            yuvarlakbutonClass12.Enabled = false;
            yuvarlakbutonClass11.Enabled = false;
            yuvarlakbutonClass13.Enabled = false;
            yuvarlakbutonClass14.Enabled = false;
        }
        private void butonlariac()
        {
            yuvarlakbutonClass12.Enabled = true;
            yuvarlakbutonClass11.Enabled = true;
            yuvarlakbutonClass13.Enabled = true;
            yuvarlakbutonClass14.Enabled = true;
        }
        private void sonuc()
        {
            if (player1.Bounds.IntersectsWith(pictureBox18.Bounds)) // arının çiçeginin üstüne gelmesi sonucu puan hesaplamak için kullandığımız kısım
            {
                if (hak1 > 0)
                {
                    puan1 = 2;
                }
                if (progressBar1.Value <= 25)
                {
                    puan1 += 4;
                }
                else if (progressBar1.Value <= 50)
                {
                    puan1 += 3;
                }
                else if (progressBar1.Value <= 75)
                {
                    puan1 += 2;
                }
                else if (progressBar1.Value < 100)
                {
                    puan1 += 1;
                }
                if (puan1 == 6)  //puanlara göre ekranda yazdırdığımız cümleler
                {
                    yildiz1 = "3 yıldız ile bu bölümü sonlandırdınız.";
                }
                else if (puan1 == 5)
                {
                    yildiz1 = "2 yıldız ile bu bölümü sonlandırdınız.";
                }
                else if (puan1 == 4)
                {
                    yildiz1 = "1 yıldız ile bu bölümü sonlandırdınız.";
                }
                else
                {
                    yildiz1 = "0 yıldız ile bu bölümü sonlandırdınız.";
                }

                MessageBox.Show(yildiz1, "TEBRİKLER");
                butonlarikapa(); // oyun bitince butonlar kapandı ve zaman durduruldu
                timer1.Stop();
            }
            if (hak1 <= 0)
            {
                //hak bitmesi sonucu ekranda mesaj yazdırılıp butonlar kapandı ve zaman durduruldu.
                yildiz1 = "Oyunu kaybettiniz.Tüm haklarınız bitti";
                MessageBox.Show(yildiz1, "ÜZGÜNÜZ");
                butonlarikapa();
                timer1.Stop();
            }
        }
        public Form2()
        {
            InitializeComponent();
            yuvarlakbutonClass11.Enabled = false;
            yuvarlakbutonClass13.Enabled = false;
            yuvarlakbutonClass14.Enabled = false;
            //form 2 açıldığı zaman başta sağ sol ve aşağ kısmı kapalı verdik çünkü sadece ileri gitmesini sağlamamız gerekiyordu ileriye gittiği zaman diğer butonları aktif hale getirdik 

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (i == 1)
            {
                pictureBox2.Image = ımageList1.Images[i];     //Form1de açıklandı.
                i--;
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = @"C:\Users\elifo\OneDrive\Masaüstü\beebotappfinal\bin\Debug\all-songs.wav";
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
        private void yukarihareketet()
        {
        bas:                                                        //bu fonksiyonlarda amaçlanan şey her yön tuşlarında artan yukarıs vb değişkenlerinin durumuna göre işelm yapması.Her işelm sonrası değişken azalıyor ve basıldığı kadar arının ilerlenmesi sağlanmış oluyor
            if (yukaris > 0 && yukaris < 3)                        //durumlara göre sınırların bağlamı içerisinde sınır dışına çıkıldığına dair mesaj iletiliyor ve zaman durduruluyor .İşlem yapılıyorsa eğer hak azaltılıyor cisim hareket ediyor arının resmi değişiyor.
            {                                                      //ve sonuc ekrana yazdırılıyor 
                player1.Image = ımageList2.Images[1];
                if (player1.Top - pictureBoxSpeed1 >= pictureBox18.Top)
                {
                    player1.Top -= pictureBoxSpeed1;
                    hak1--;
                    yukaris--;
                }
                sonuc();
                goto bas;
            }
            if (yukaris >= 3)
            {
                timer1.Stop();
                if (!mesajGosterildi)
                {
                    MessageBox.Show("SINIR DIŞINA ÇIKTINIZ.LÜTFEN KARELERDEN İLERLEYİN");
                    mesajGosterildi = true;
                }
            }
        }
        private void asagihareketet()
        {
        bas1:
            if (asagis > 0 && asagis < 1)
            {
                player1.Image = ımageList2.Images[3];
                if (player1.Bottom + pictureBoxSpeed1 <= pictureBox19.Bottom)
                {
                    player1.Top += pictureBoxSpeed1;
                    hak1--;
                    asagis--;
                }
                sonuc();
                goto bas1;
            }
            if (asagis >= 1)
            {
                timer1.Stop();
                if (!mesajGosterildi2)
                {
                    MessageBox.Show("SINIR DIŞINA ÇIKTINIZ.LÜTFEN KARELERDEN İLERLEYİN");
                    mesajGosterildi2 = true;
                }
            }
        }
        private void solahareketet()
        {
        bas2:
            if (solas > 0 && solas < 2)
            {
                player1.Image = ımageList2.Images[0];
                if (player1.Left - pictureBoxSpeed1 >= pictureBox19.Left)
                {
                    player1.Left -= pictureBoxSpeed1;
                    hak1--;
                    solas--;
                }
                sonuc();
                goto bas2;
            }
            if (solas >= 2)
            {
                timer1.Stop();
                if (!mesajGosterildi3)
                {
                    MessageBox.Show("SINIR DIŞINA ÇIKTINIZ.LÜTFEN KARELERDEN İLERLEYİN");
                    mesajGosterildi3 = true;
                }
            }
        }
        private void sagahareketet()
        {
            {
            bas3:
                if (sagas > 0 && sagas < 1)
                {
                    player1.Image = ımageList2.Images[2];
                    if (player1.Right + pictureBoxSpeed1 <= pictureBox17.Right)
                    {
                        player1.Left += pictureBoxSpeed1;
                        hak1--;
                        sagas--;
                    }
                    sonuc();
                    goto bas3;
                }
                if (sagas >= 1)
                {
                    timer1.Stop();
                    if (!mesajGosterildi4)
                    {
                        MessageBox.Show("SINIR DIŞINA ÇIKTINIZ.LÜTFEN KARELERDEN İLERLEYİN");
                        mesajGosterildi4 = true;
                    }
                }
            }
        }
        private void yuvarlakbutonClass12_Click(object sender, EventArgs e)
        {
            //bu butona basınca yukardakı fonksiyon kontrol edilmesi için değişken arttırılıyor ve ilk basma sonrası tüm butonlar aktif edilmiş oluyor .
            yukaris++;
            yuvarlakbutonClass11.Enabled = true;
            yuvarlakbutonClass13.Enabled = true;
            yuvarlakbutonClass14.Enabled = true;
        }
        private void yuvarlakbutonClass14_Click(object sender, EventArgs e)
        {
            asagis++;
        }
        private void yuvarlakbutonClass11_Click(object sender, EventArgs e)
        {
            solas++;
        }
        private void yuvarlakbutonClass13_Click(object sender, EventArgs e)
        {
            sagas++;
        }
        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1(); //form 2 den çıkış sonrası tekrar oyunun ilk sayfası gelmesi sağlanıyor
            form1.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // çıkış resmine basım sonrası aplikasyon kapanıyor
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sayac1++;
            if (progressBar1.Value <= 99 && hak1 > 0 && !player1.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                progressBar1.Value = progressBar1.Value + 1;                                              // duruma göre progressbarın dolumu sağlanıyor
            }
            else
            {
                timer1.Stop();
                if (progressBar1.Value == 100)
                {
                    yildiz1 = "Oyunu kaybettiniz";                   // progressbarın dolması yani sürenin bitmesi ile oyunda yanıldığına dair mesaj geliyor ve butonalr kapanıyor
                    MessageBox.Show(yildiz1, "ÜZGÜNÜZ");
                    butonlarikapa();
                }
            }
        }
        private void yuvarlakbutonClass15_Click_1(object sender, EventArgs e)
        {
            for (i = 0; i <= yukaris; i++)                   // döngüler sayesinde fonksiyonlar çağırılıyor ve çağırılan fonksiyonlardaki şartlar sağlanıyorsa cisim hareket ediyor.
            {
                yukarihareketet();
            }
            for (i = 0; i <= asagis; i++)
            {
                asagihareketet();
            }
            for (i = 0; i <= sagas; i++)
            {
                sagahareketet();

            }
            for (i = 0; i <= solas; i++)
            {
                solahareketet();
            }
        }
    }
}
