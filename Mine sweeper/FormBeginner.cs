using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class FormBeginner : Form
    {
        Button[] btnBeginner1;
        public Button[] btnBeginner11;
        Random rastgele10mayin = new Random();
        int[] mayin10dizi = new int[10];
        int xKoor;
        int yKoor;

        public FormBeginner()
        {
            InitializeComponent();
                        
        }

        private void tBasla_Tick(object sender, EventArgs e)
        {
            sayi = sayi + 1;
            lblZaman.Text = sayi.ToString();
            bitirmeSuresi = sayi.ToString();
        }
        public int sayi;
        public string bitirmeSuresi;
        private void FormBeginner_Load(object sender, EventArgs e)
        {
            lblZaman.Text = sayi.ToString();
            tBasla.Start();
            tBasla.Interval = 1000;

            this.BackColor = Color.Turquoise;
            btnBeginner11 = BeginnerMayinButtonsYarat(btnBeginner1);
            
            //Array.Sort(mayin10dizi);
            //foreach (var item in mayin10dizi)
            //{
            //    listBox1.Items.Add(item);
            //}
            
        }

        #region BEGINNER BUTTON YARAT
        Button[] BeginnerMayinButtonsYarat(Button[] btnBeginner)
        {
            Random r = new Random();
            int randomSayi;
            int sayac = 0;

            while (sayac < mayin10dizi.Length)
            {
                randomSayi = r.Next(0, 81); //0 ile 81 arasında rastgele sayı üretiliyor

                if (Array.IndexOf(mayin10dizi, randomSayi) == -1)  //dizinin içinde aynı sayı yoksa
                {
                    mayin10dizi[sayac] = randomSayi;  //üretilen rastgele sayiyi dizinin sayac kaç ise o elemanına ata
                    sayac++; //sayacı bir artır
                }
            }
            xKoor = 200;
            yKoor = 100;
            btnBeginner = new Button[81];
            btnBeginner[0] = new Button();
            Size boyut = new Size(35, 35);
            btnBeginner[0].Size = boyut;
            btnBeginner[0].BackColor = Color.DarkGray;
            btnBeginner[0].Text += 0;
            btnBeginner[0].ForeColor = Color.DarkGray;
            btnBeginner[0].Location = new Point(xKoor, yKoor);
            this.Controls.Add(btnBeginner[0]);

            for (int i = 1; i < 81; i++)
            {
                xKoor += 34;
                btnBeginner[i] = new Button();
                btnBeginner[i].Size = boyut;
                btnBeginner[i].BackColor = Color.DarkGray;
                btnBeginner[i].Text += i;

                if (i % 9 == 0)
                {
                    xKoor = 200;
                    yKoor += 34;
                    btnBeginner[i].Location = new Point(xKoor, yKoor);
                    this.Controls.Add(btnBeginner[i]);

                }
                else
                {
                    btnBeginner[i].Location = new Point(xKoor, yKoor);
                    this.Controls.Add(btnBeginner[i]);
                }
                int k = 0;
                bool atandiMi = true;

                while (atandiMi && k < 10)
                {
                    if (mayin10dizi[k] == i)
                    {
                        btnBeginner[i].Click += new EventHandler(Mayinli);
                        btnBeginner[i].Text = "mayin";
                        btnBeginner[i].ForeColor = Color.DarkGray;
                        atandiMi = false;
                    }
                    k++;
                }

                if (btnBeginner[i].Text == "mayin")
                {
                    continue;
                }
                else
                {
                    btnBeginner[i].Click += new EventHandler(Mayinsiz);
                }

                btnBeginner[i].ForeColor = Color.DarkGray;
                btnBeginner[i].FlatAppearance.BorderColor = Color.Black;
            }

            int m = 0;
            bool atandiMi1 = true;
            while (atandiMi1 && m < 10)
            {
                if (mayin10dizi[m] == 0)
                {
                    btnBeginner[0].Click += new EventHandler(Mayinli);
                    btnBeginner[0].Text = "mayin";
                    btnBeginner[0].ForeColor = Color.DarkGray;
                    atandiMi1 = false;
                }
                m++;
            }

            if (btnBeginner[0].Text != "mayin")
            {
                btnBeginner[0].Click += new EventHandler(Mayinsiz);
            }

            return btnBeginner;
        } 
        #endregion

        #region MAYINLI VE MAYINSIZ EVENT
        void Mayinli(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Image = pbMayin2.Image;
            x.BackColor = Color.Red;
            Size boyutImage = new Size(35, 35);
            x.Text = "";
            x.Enabled = false;
            for (int i = 0; i < mayin10dizi.Length; i++)
            {
                btnBeginner11[mayin10dizi[i]].Image = pbMayin2.Image;
                btnBeginner11[mayin10dizi[i]].Text = "";
                btnBeginner11[mayin10dizi[i]].Enabled=false;
            }

            tBasla.Stop();

            for (int i = 0; i < btnBeginner11.Length; i++)// eventler kaldırılıyor.
            {
                btnBeginner11[i].MouseClick -= Mayinsiz;
            }
            MessageBox.Show("Kaybettiniz.");
        }


        int acilanMayinSayisi;
        void Mayinsiz(object sender, EventArgs e)
        {
            Button y = sender as Button;
            acilanMayinSayisi++;
            int i;
            i = Convert.ToInt32(y.Text);
            int sayac = 0;

            
            if (i == 0) // Sol üst köşe
            {
                if (btnBeginner11[i + 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 10].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 9].Text == "mayin") { sayac++; }
            }
            else if (i == 8) // Sağ üst köşe
            {
                if (btnBeginner11[i - 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 9].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 8].Text == "mayin") { sayac++; }
            }
            else if (i == 80) // Sağ alt köşe
            {
                if (btnBeginner11[i - 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 9].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 10].Text == "mayin") { sayac++; }
            }
            else if (i == 72) // Sol alt köşe
            {
                if (btnBeginner11[i + 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 9].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 8].Text == "mayin") { sayac++; }
            }
            else if (i % 9 == 0)// Kare sol taraf
            {
                if (btnBeginner11[i - 9].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 8].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 10].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 9].Text == "mayin") { sayac++; }
            }
            else if (i > 0 && i < 8)// Kare üst taraf
            {
                if (btnBeginner11[i - 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 8].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 9].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 10].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 1].Text == "mayin") { sayac++; }
            }
            else if ((i + 1) % 9 == 0 && i > 8)// Kare sağ taraf
            {
                if (btnBeginner11[i - 9].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 10].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 8].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 9].Text == "mayin") { sayac++; }
            }
            else if (i > 72 && i < 80)// Kare alt taraf
            {
                if (btnBeginner11[i - 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 10].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 9].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 8].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 1].Text == "mayin") { sayac++; }
            }
            else // Kare iç taraflar
            {
                if (btnBeginner11[i - 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 10].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 9].Text == "mayin") { sayac++; }
                if (btnBeginner11[i - 8].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 1].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 10].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 9].Text == "mayin") { sayac++; }
                if (btnBeginner11[i + 8].Text == "mayin") { sayac++; }

                //if (sayac==0) { for(int a = 8; a < 11; a++) { btnBeginner11[i - a].Enabled = false; btnBeginner11[i - a].BackColor=Color.Brown; btnBeginner11[i - a].Text=""; btnBeginner11[i + a].Enabled = false; btnBeginner11[i + a].BackColor = Color.Brown; btnBeginner11[i + a].Text = ""; } btnBeginner11[i].Enabled = false; btnBeginner11[i].BackColor = Color.Brown; btnBeginner11[i].Text = ""; btnBeginner11[i - 1].Enabled = false; btnBeginner11[i - 1].BackColor=Color.Brown; btnBeginner11[i - 1].Text = ""; btnBeginner11[i + 1].Enabled = false; btnBeginner11[i + 1].BackColor = Color.Brown; btnBeginner11[i + 1].Text = ""; }
                
            }

            y.Text = sayac.ToString();
            y.BackColor = Color.Brown;
            y.Font = new Font("Microsoft Sans Serif", 10);
            y.ForeColor = Color.Black;
            y.Enabled = false;

            if (acilanMayinSayisi == 71)
            {
                for (int m = 0; m < mayin10dizi.Length; m++)
                {
                    btnBeginner11[mayin10dizi[m]].Image = pbMayin2.Image;
                    btnBeginner11[mayin10dizi[m]].Text = "";
                    btnBeginner11[mayin10dizi[m]].Enabled = false;
                }
                tBasla.Stop();
                MessageBox.Show("Tebrikler. Kazandınız.\nBitirme Süreniz: " + bitirmeSuresi);
            }
            return;
        }

        #endregion
    }
}
