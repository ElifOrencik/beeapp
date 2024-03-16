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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace beebotappfinal
{
    public partial class Form3 : Form
    {
        private int pictureBoxSpeed = 100;
        private int hak = 7;
        private int puan = 0;
        private int sayac = 0;
        private int i = 0;
        private string yildiz;
        private void butonlarikapa()
        {
            yuvarlakbutonClass12.Enabled = false;
            yuvarlakbutonClass11.Enabled = false;
            yuvarlakbutonClass14.Enabled = false;
            yuvarlakbutonClass13.Enabled = false;
        }
        private void butonlarinbasdurumu()
        {
            yuvarlakbutonClass14.Enabled = false;
            yuvarlakbutonClass13.Enabled = false;
            yuvarlakbutonClass12.Enabled = false;
            yuvarlakbutonClass11.Enabled = true;
        }
        private void butonlar()
        {
            if (player1.Bounds.IntersectsWith(player1.Bounds))                           //butonlar fonksiyonu içinde amaçladığımız şey her kare üstündeki durumlara göre kontrol edilmesi sağlandı.
            {                                                                             //yani mesela player picturebox4 üstündeyse sadece sağa ve sola gidebilsin diyerek şart koyduk her kare için faarklı şartlar koyduk ve istese de çıkamamasını sağladık
                yuvarlakbutonClass14.Enabled = false;
                yuvarlakbutonClass13.Enabled = false;
                yuvarlakbutonClass12.Enabled = false;
                yuvarlakbutonClass11.Enabled = true;
            }
            if (player1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                yuvarlakbutonClass14.Enabled = false;
                yuvarlakbutonClass13.Enabled = true;
                yuvarlakbutonClass12.Enabled = false;
                yuvarlakbutonClass11.Enabled = true;
            }
            if (player1.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                yuvarlakbutonClass11.Enabled = false;
                yuvarlakbutonClass12.Enabled = false;
                yuvarlakbutonClass14.Enabled = true;
                yuvarlakbutonClass13.Enabled = true;
            }
            if (player1.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                yuvarlakbutonClass12.Enabled = true;
                yuvarlakbutonClass11.Enabled = false;
                yuvarlakbutonClass14.Enabled = true;
                yuvarlakbutonClass13.Enabled = false;
            }
            if (player1.Bounds.IntersectsWith(pictureBox33.Bounds))
            {
                yuvarlakbutonClass12.Enabled = true;
                yuvarlakbutonClass11.Enabled = false;
                yuvarlakbutonClass14.Enabled = true;
                yuvarlakbutonClass13.Enabled = false;
            }
            if (player1.Bounds.IntersectsWith(pictureBox19.Bounds))
            {
                yuvarlakbutonClass11.Enabled = true;
                yuvarlakbutonClass12.Enabled = true;
                yuvarlakbutonClass14.Enabled = false;
                yuvarlakbutonClass13.Enabled = false;
            }
        }
        private void sonuc()
        {
            if (player1.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                if (hak > 0)
                {
                    puan = 2;
                }
                if (progressBar1.Value <= 25)
                {
                    puan += 4;
                }
                else if (progressBar1.Value <= 50)
                {
                    puan += 3;
                }
                else if (progressBar1.Value <= 75)
                {
                    puan += 2;
                }
                else if (progressBar1.Value < 100)
                {
                    puan += 1;
                }
                if (puan == 6)
                {
                    yildiz = "3 yıldız ile bu bölümü sonlandırdınız.";
                }
                else if (puan == 5)
                {
                    yildiz = "2 yıldız ile bu bölümü sonlandırdınız.";
                }
                else if (puan == 4)
                {
                    yildiz = "1 yıldız ile bu bölümü sonlandırdınız.";
                }
                else
                {
                    yildiz = "0 yıldız ile bu bölümü sonlandırdınız.";
                }
                MessageBox.Show(yildiz, "TEBRİKLER");
                butonlarikapa();
                timer1.Stop();
            }
            if (hak <= 0)
            {
                yildiz = "Oyunu kaybettiniz.Tüm haklarınız bitti";
                MessageBox.Show(yildiz, "ÜZGÜNÜZ");
                butonlarikapa();
                timer1.Stop();
            }
        }
        public Form3()
        {
            InitializeComponent();
            butonlarinbasdurumu();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                pictureBox2.Image = ımageList1.Images[i];
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
        private void yuvarlakbutonClass11_Click_1(object sender, EventArgs e)
        {
            player1.Image = ımageList2.Images[0];
            //yukardaki şartları belirlerken bir sonraki adımı düşünerek şart belirledik böylece ona göre hareket etmesini önceden belirlemiş olduk o şarta göre de hareket sağlandı.
            player1.Left -= pictureBoxSpeed;                 //hak azaltıldı ve sonuc yazdırıldı
            butonlar();
            hak--;
            sonuc();
        }
        private void yuvarlakbutonClass12_Click_1(object sender, EventArgs e)
        {
            player1.Image = ımageList2.Images[1];
            player1.Top -= pictureBoxSpeed;
            butonlar();
            hak--;
            sonuc();
        }
        private void yuvarlakbutonClass13_Click_1(object sender, EventArgs e)
        {
            player1.Image = ımageList2.Images[2];
            player1.Left += pictureBoxSpeed;
            butonlar();
            hak--;
            sonuc();
        }
        private void yuvarlakbutonClass14_Click_1(object sender, EventArgs e)
        {
            player1.Image = ımageList2.Images[3];
            player1.Top += pictureBoxSpeed;
            butonlar();
            hak--;
            sonuc();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (progressBar1.Value <= 99 && hak > 0 && !player1.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                timer1.Stop();
                if (progressBar1.Value == 100)
                {
                    yildiz = "Oyunu kaybettiniz";
                    MessageBox.Show(yildiz, "ÜZGÜNÜZ");
                    butonlarikapa();
                }
            }
        }
    }
}
