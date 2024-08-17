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
    public partial class FormIntermadiate : Form
    {
        Button[] btnIntermadiate;
        Button[] btnIntermadiate1;
        public Button[] btnIntermadiate11;
        int[] mayin40dizi = new int[40];
        int xKoor;
        int yKoor;
        public FormIntermadiate()
        {
            InitializeComponent();
        }
        public int sayi;
        public string bitirmeSuresi;

        private void tBasla_Tick(object sender, EventArgs e)
        {
            sayi = sayi + 1;
            lblZaman.Text = sayi.ToString();
            bitirmeSuresi = sayi.ToString();

        }
        private void FormIntermadiate_Load(object sender, EventArgs e)
        {
            lblZaman.Text = sayi.ToString();
            tBasla.Start();
            tBasla.Interval = 1000;
            this.BackColor = Color.Turquoise;
            btnIntermadiate11 = IntermadiateMayinButtonsYarat(btnIntermadiate1);

            //Array.Sort(mayin40dizi);
            //foreach (var item in mayin40dizi)
            //{
                
            //    listBox1.Items.Add(item);
            //}

        }

        #region INTERMADIATE BUTTON YARAT
        Button[] IntermadiateMayinButtonsYarat(Button[] btnIntermadiate)
        {
            Random r = new Random();
            int randomSayi;
            int sayac = 0;

            while (sayac < mayin40dizi.Length)
            {
                randomSayi = r.Next(0, 255); //0 ile 81 arasında rastgele sayı üretiliyor

                if (Array.IndexOf(mayin40dizi, randomSayi) == -1)  //dizinin içinde aynı sayı yoksa
                {
                    mayin40dizi[sayac] = randomSayi;  //üretilen rastgele sayiyi dizinin sayac kaç ise o elemanına ata
                    sayac++; //sayacı bir artır
                }
            }
            xKoor = 50;
            yKoor = 50;
            btnIntermadiate = new Button[256];
            btnIntermadiate[0] = new Button();
            Size boyut = new Size(35, 35);
            btnIntermadiate[0].Size = boyut;
            btnIntermadiate[0].BackColor = Color.DarkGray;
            btnIntermadiate[0].Text += 0;
            btnIntermadiate[0].ForeColor = Color.DarkGray;
            btnIntermadiate[0].Location = new Point(xKoor, yKoor);
            this.Controls.Add(btnIntermadiate[0]);

            for (int i = 1; i < 256; i++)
            {
                xKoor += 34;
                btnIntermadiate[i] = new Button();
                btnIntermadiate[i].Size = boyut;
                btnIntermadiate[i].BackColor = Color.DarkGray;
                btnIntermadiate[i].Text += i;

                if (i % 16 == 0)
                {
                    xKoor = 50;
                    yKoor += 34;
                    btnIntermadiate[i].Location = new Point(xKoor, yKoor);
                    this.Controls.Add(btnIntermadiate[i]);
                }
                else
                {
                    btnIntermadiate[i].Location = new Point(xKoor, yKoor);
                    this.Controls.Add(btnIntermadiate[i]);
                }
                int k = 0;
                bool atandiMi = true;
                while (atandiMi && k < 40)
                {
                    if (mayin40dizi[k] == i)
                    {
                        btnIntermadiate[i].Click += new EventHandler(Mayinli);
                        btnIntermadiate[i].Text = "mayin";
                        btnIntermadiate[i].ForeColor = Color.DarkGray;
                        atandiMi = false;
                    }
                    k++;
                }
                if (btnIntermadiate[i].Text == "mayin")
                {
                    continue;
                }
                else
                {
                    btnIntermadiate[i].Click += new EventHandler(Mayinsiz);
                }
                btnIntermadiate[i].ForeColor = Color.DarkGray;
                btnIntermadiate[i].FlatAppearance.BorderColor = Color.Black;
            }
            int m = 0;
            bool atandiMi1 = true;
            while (atandiMi1 && m < 40)
            {
                if (mayin40dizi[m] == 0)
                {
                    btnIntermadiate[0].Click += new EventHandler(Mayinli);
                    btnIntermadiate[0].Text = "mayin";
                    btnIntermadiate[0].ForeColor = Color.DarkGray;
                    atandiMi1 = false;
                }
                m++;
            }
            if (btnIntermadiate[0].Text != "mayin")
            {
                btnIntermadiate[0].Click += new EventHandler(Mayinsiz);
            }
            return btnIntermadiate;
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
            for (int i = 0; i < mayin40dizi.Length; i++)
            {
                btnIntermadiate11[mayin40dizi[i]].Image = pbMayin2.Image;
                btnIntermadiate11[mayin40dizi[i]].Text = "";
                btnIntermadiate11[mayin40dizi[i]].Enabled = false;
            }

            tBasla.Stop();
            for (int i = 0; i < btnIntermadiate11.Length; i++)// eventler kaldırılıyor.
            {
                btnIntermadiate11[i].Click -= Mayinsiz;
            }

            MessageBox.Show("Kaybettiniz.");
        }

        int acilanMayinSayisi;
        void Mayinsiz(object sender, EventArgs e)
        {
            acilanMayinSayisi++;
            int sayac = 0;
            int i;
            Button y = sender as Button;
            i = Convert.ToInt32(y.Text);

            if (i == 0) // Sol üst köşe
            {
                if (btnIntermadiate11[i + 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 17].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 16].Text == "mayin") { sayac++; }
            }
            else if (i == 15) // Sağ üst köşe
            {
                if (btnIntermadiate11[i - 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 16].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 15].Text == "mayin") { sayac++; }
            }
            else if (i == 255) // Sağ alt köşe
            {
                if (btnIntermadiate11[i - 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 17].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 16].Text == "mayin") { sayac++; }
            }
            else if (i == 240) // Sol alt köşe
            {
                if (btnIntermadiate11[i + 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 15].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 16].Text == "mayin") { sayac++; }
            }
            else if (i % 16 == 0)// Kare sol taraf
            {
                if (btnIntermadiate11[i - 16].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 15].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 17].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 16].Text == "mayin") { sayac++; }
            }
            else if (i > 0 && i < 15)// Kare üst taraf
            {
                if (btnIntermadiate11[i - 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 15].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 16].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 17].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 1].Text == "mayin") { sayac++; }
            }
            else if ((i + 1) % 16 == 0 && i > 15)// Kare sağ taraf
            {
                if (btnIntermadiate11[i - 16].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 17].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 15].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 16].Text == "mayin") { sayac++; }
            }
            else if (i > 240 && i < 255)// Kare alt taraf
            {
                if (btnIntermadiate11[i - 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 17].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 16].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 15].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 1].Text == "mayin") { sayac++; }
            }
            else // Kare iç taraflar
            {
                if (btnIntermadiate11[i - 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 17].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 16].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i - 15].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 1].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 17].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 16].Text == "mayin") { sayac++; }
                if (btnIntermadiate11[i + 15].Text == "mayin") { sayac++; }
            }
            y.Text = sayac.ToString();
            y.BackColor = Color.LightBlue;
            y.Font = new Font("Microsoft Sans Serif", 10);
            y.ForeColor = Color.Black;
            y.Enabled = false;

            if (acilanMayinSayisi == 216)
            {
                for (int m = 0; m < mayin40dizi.Length; m++)
                {
                    btnIntermadiate11[mayin40dizi[m]].Image = pbMayin2.Image;
                    btnIntermadiate11[mayin40dizi[m]].Text = "";
                    btnIntermadiate11[mayin40dizi[m]].Enabled = false;
                }
                tBasla.Stop();
                MessageBox.Show("Tebrikler. Kazandınız.\nBitirme Süreniz: " + bitirmeSuresi);
            }

            return;
        } 
        #endregion

    }
}
