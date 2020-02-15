using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd1 = new Random(); //1. zar için rasgele değerler tanımlandı.
        Random rnd2 = new Random(); //2.zar için rasgele değerler tanımlandı.
        int skor1 = 0, skor2 = 0; //skor sayaçları
        int a=0, b=0;
        

        private void btnIlkZar_Click(object sender, EventArgs e)
        {
            int rasgele1 = rnd1.Next(1, 7); //zarların değer aralıkları
            lblZar1.Text = rasgele1.ToString();
            btnIlkZar.Enabled = false; //1. zar at'a basıldığında tekrar basılamaması için buton pasif yapıldı.
            btnIkinciZar.Enabled = true;
            btnSkor.Enabled = true;
            
        }

        private void btnSkor_Click(object sender, EventArgs e)
        {
            
                a = Convert.ToInt32(lblZar1.Text);
                b = Convert.ToInt32(lblZar2.Text);

                if (a > b)
                {
                    skor1++;
                    lblSkor1.Text = skor1.ToString();
                    MessageBox.Show("1.Oyuncu Kazandı.");

                }
                else if (b > a)
                {
                    skor2++;
                    lblSkor2.Text = skor2.ToString();
                    MessageBox.Show("2.Oyuncu Kazandı.");

                }

                else
                {
                    skor1++;
                    skor2++;
                    lblSkor1.Text = skor1.ToString();
                    lblSkor2.Text = skor2.ToString();
                    MessageBox.Show("Berabere!");
                
                }
                btnIlkZar.Enabled = true;
                btnIkinciZar.Enabled = false;
                btnYeniden.Enabled = true;
                btnSkor.Enabled = false; // sonuç butonuna tekrar basılamaması için buton pasif bırakldı.
                lblZar1.Text = null; //zarın değerleri sıfırlandı.
                lblZar2.Text = null;//zarın değerleri sıfırlandı.
            if(lblSkor1.Text== "10")
            {
                btnIkinciZar.Visible = false; //butona tekrar basılamaması için pasifleştirildi.
                btnIlkZar.Visible = false; //butona tekrar basılamaması için pasifleştirildi.
                btnSkor.Visible = false; //butona tekrar basılamaması için pasifleştirildi.
                MessageBox.Show("Tebrikler 1.Kullanıcı Oyunu Kazandı! Tekrar Oynamak İçin Yeniden Başlat Tuşuna basınız");
            }
            else if (lblSkor2.Text=="10")
            {
                btnIkinciZar.Visible = false; //butona tekrar basılamaması için pasifleştirildi.
                btnIlkZar.Visible = false; //butona tekrar basılamaması için pasifleştirildi.
                btnSkor.Visible = false; //butona tekrar basılamaması için pasifleştirildi.
                MessageBox.Show("Tebrikler 2.Kullanıcı Oyunu Kazandı! Tekrar Oynamak İçin Yeniden Başlat Tuşuna basınız");
            }
            else if (lblSkor2.Text=="10" && lblSkor1.Text == "10")
            {
                
                btnIkinciZar.Visible = false; //butona tekrar basılamaması için pasifleştirildi.
                btnIlkZar.Visible = false; //butona tekrar basılamaması için pasifleştirildi.
                btnSkor.Visible = false; //butona tekrar basılamaması için pasifleştirildi.
                MessageBox.Show("Berabere Kaldınız! Tekrar Oynamak İçin Yeniden Başlat Tuşuna basınız");
            }
            
            
        }
        
        private void btnYeniden_Click(object sender, EventArgs e)
        {
            skor1 = 0; //1.skoru sıfırladı.
            skor2 = 0; //2.skoru sıfırladı.
            lblSkor1.Text = skor1.ToString();
            lblSkor2.Text = skor2.ToString();
            lblZar1.Text = null; // Atılan 1. Zarı sıfırladı.
            lblZar2.Text = null; //Atılan 2. Zarı sıfırladı.
            Application.OpenForms[0].Show(); //Yeniden tuşuna basıldığında formu baştan çalıştırır.

            
        }
        
        private void btnIkinciZar_Click(object sender, EventArgs e)
        {
            int rasgele2 = rnd1.Next(1, 7); //Zar değer aralığı tanımlandı.
            lblZar2.Text = rasgele2.ToString();
            btnIkinciZar.Enabled = false;//İkinci butona tekrar basılamaması için pasifleştirildi.
            btnIlkZar.Enabled = true;
            btnSkor.Enabled = true;
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Zarları Sırasıyla Attıktan Sonra Sonuç Tuşuna Basınız.İyi Eğlenceler :)");
            btnIlkZar.Enabled = true; //Önce ilk kullanıcının başlayabilmesi için buton aktifleştirildi.
            btnIkinciZar.Enabled = false; // Önce İlk kullanıcının başlaması için buton pasif yapıldı.
            


        }
    }
}
