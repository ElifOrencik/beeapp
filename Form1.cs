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
                pictureBox2.Image = �mageList1.Images[i];     //Bu kodlar sayesinde m�zik resmine t�klay�nca �al���p �al��mamas�na g�re belirlenmi� resim gelir ve m�zik a��l�p kapat�l�r.
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = @"C:\Users\elifo\OneDrive\Masa�st�\beebotappfinal\bin\Debug\all-songs.wav"; ;
                ses.Stop();
                i--;
            }
            else
            {
                pictureBox2.Image = �mageList1.Images[i];
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = @"C:\Users\elifo\OneDrive\Masa�st�\beebotappfinal\bin\Debug\all-songs.wav";
                ses.Play();
                i++;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Bu k�s�mlarda seviyelerin kutular�na t�klad�kca o b�l�m a��l�r ve b�l�m hakk�nda bilgi verme amaciyla messajebox g�z�k�r.
            MessageBox.Show("BU SEV�YEDE 4 ADET HAMLE HAKKINIZ BULUNMAKTADIR.HAMLELER�N�Z VE S�REN�Z B�TMEDEN HEDEFE ULA�TI�INIZ AN OYUNU KAZANMI� OLURSUNUZ.M�Z�K TU�UNA BASARAK OYUN OYNARKEN OYUN M�Z���N� D�NLEYEB�L�RS�N�Z.�ARPI TU�UNA BASARAK BU EKRANA D�N�P OYUNUN D��ER B�L�MLER�N� OYNAYAB�L�RS�N�Z.B�L�MLER� SIRAYLA OYNARAK OYUNUN TADINI �IKARTIN. �Y� �ANSLAR", "B�LG�LEND�RME");
            Form2 form2 = new Form2(); 
            form2.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU SEV�YEDE 7 ADET HAMLE HAKKINIZ BULUNMAKTADIR.HAMLELER�N�Z VE S�REN�Z B�TMEDEN HEDEFE ULA�TI�INIZ AN OYUNU KAZANMI� OLURSUNUZ.M�Z�K TU�UNA BASARAK OYUN OYNARKEN OYUN M�Z���N� D�NLEYEB�L�RS�N�Z.�ARPI TU�UNA BASARAK BU EKRANA D�N�P OYUNUN D��ER B�L�MLER�N� OYNAYAB�L�RS�N�Z.B�L�MLER� SIRAYLA OYNARAK OYUNUN TADINI �IKARTIN.B�L�M ��ER�S�NDE ENGELLER�N �ST�NE �IKMANIZ �MKANSIZDIR.TA� YOLDAN HAMLELERLE �LERLEYEREK HEDEFE ULA�INIZ. �Y� �ANSLAR", "B�LG�LEND�RME");
            Form3 form3 = new Form3(); 
            form3.Show();
            this.Hide();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU SEV�YEDE 7 ADET HAMLE HAKKINIZ BULUNMAKTADIR.HAMLELER�N�Z VE S�REN�Z B�TMEDEN HEDEFE ULA�TI�INIZ AN OYUNU KAZANMI� OLURSUNUZ.M�Z�K TU�UNA BASARAK OYUN OYNARKEN OYUN M�Z���N� D�NLEYEB�L�RS�N�Z.�ARPI TU�UNA BASARAK BU EKRANA D�N�P OYUNUN D��ER B�L�MLER�N� OYNAYAB�L�RS�N�Z.B�L�MLER� SIRAYLA OYNARAK OYUNUN TADINI �IKARTIN.B�L�M ��ER�S�NDE K�T� ARIDAN UZAK DURUN.ONA DE�D���N�Z ZAMAN OYUNU KAYBEDERS�N�Z ���E��N �ST�NE TIKLAYARAK ARI VE ���E��N YER�N� DE���T�REREK ���E�E ULA�MAYI SA�LAYAB�L�RS�N�Z..TA� YOLDAN HAMLELERLE �LERLEYEREK HEDEFE ULA�INIZ. �Y� �ANSLAR", "B�LG�LEND�RME");
            Form4 form4 = new Form4(); 
            form4.Show();
            this.Hide();
        }
        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            //Soru i�saretine t�kland��� zaman oyunun her b�l�m�ne ait bilgi verilir.
            string bilgiler = "OYUN HAKKINDA B�LG�LER\n\n" +
             "1. b�l�m: Bu b�l�mde amac�m�z �i�e�e en k�sa s�rede, hamleleri bitirmeden ve s�n�rlar� ge�meden ula�makt�r. " +
             "S�n�rlar� ge�ti�iniz zaman uyar� gelir ve d��ar� ��kamazs�n�z. S�n�rlar� ge�meniz sonucu b�l�me tekrar ba�lamak zorundas�n�z. " +
             "�i�e�e ula�t���n�zda b�l�m� bitirmi� olursunuz. S�renin bitmesi, s�n�r� ge�meniz ve hamle hakk�n�z� bitirmeniz sonucu " +
             "b�l�m� tekrar oynamak �zere �arp�ya t�klayarak oyunun ana k�sm�na d�nerbilirsiniz.\n\n" +
             "2. b�l�m: Bu b�l�mde di�er iki b�l�m�n harici olarak tu�lara bas�ld��� an hareket edilir. " +
             "Kenarlarda bulunan engellerin �st�ne ��k�lamaz, ta� yol �st�nden ileri geri sa� ve sol hareket edilir.Yine ayn� �artlar do�rultusu oyunu kazan�r veya kaybedersiniz.\n\n" +
             "3. b�l�m: Bu b�l�mde ise bir k�t� karakterimiz var ve bu k�t� karaktere de�ince yan�yoruz. " +
             "K�t� ar�ya de�memek i�in �ncelikle �i�e�in �st�ne t�klayarak k�t� ar� ile �i�e�in yerini de�i�tirip ve �i�e�e olan ula��m� sa�layarak " +
             "k�sa s�rede bitirmemizi sa�l�yoruz.";
            MessageBox.Show(bilgiler, "OYUN HAKKINDA B�LG�LER");
        }
        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            //Formdan ��k�nca uygulaman�n kapanmas�n� sa�lar
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //oyundan ��k�� resmine t�klan�nca uygulaman�n kapanmas�n� sa�lar.
            Application.Exit();
        }
    }
}