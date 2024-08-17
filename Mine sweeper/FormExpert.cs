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
    public partial class FormExpert : Form
    {
        Button[] btnExpert;
        Button[] btnExpert1;
        public Button[] btnExpert11;
        int[] mayin99dizi = new int[99];
        int xKoor;
        int yKoor;

        public FormExpert()
        {
            InitializeComponent();
        }
        public int sayi = 0; public string bitirmeSuresi;

        private void tBasla_Tick(object sender, EventArgs e)
        {
            sayi = sayi + 1;
            lblZaman.Text = sayi.ToString();
        }

        private void FormExpert_Load(object sender, EventArgs e)
        {
            lblZaman.Text = sayi.ToString();
            tBasla.Start();
            tBasla.Interval = 1000;
            this.BackColor = Color.Turquoise;
            btnExpert11 = ExpertMayinButtonsYarat(btnExpert1);

            //Array.Sort(mayin40dizi);
            //foreach (var item in mayin40dizi)
            //{

            //    listBox1.Items.Add(item);
            //}
        }

        #region EXPERT BUTTON YARAT
        Button[] ExpertMayinButtonsYarat(Button[] btnExpert)
        {
            Random r = new Random();
            int randomSayi;
            int sayac = 0;
            while (sayac < mayin99dizi.Length)
            {
                randomSayi = r.Next(0, 479); //0 ile 81 arasında rastgele sayı üretiliyor

                if (Array.IndexOf(mayin99dizi, randomSayi) == -1)  //dizinin içinde aynı sayı yoksa
                {
                    mayin99dizi[sayac] = randomSayi;  //üretilen rastgele sayiyi dizinin sayac kaç ise o elemanına ata
                    sayac++; //sayacı bir artır
                }
            }
            xKoor = 50;
            yKoor = 50;
            btnExpert = new Button[480];
            btnExpert[0] = new Button();
            Size boyut = new Size(35, 35);
            btnExpert[0].Size = boyut;
            btnExpert[0].BackColor = Color.DarkGray;
            btnExpert[0].Text += 0;
            btnExpert[0].ForeColor = Color.DarkGray;
            btnExpert[0].Location = new Point(xKoor, yKoor);
            this.Controls.Add(btnExpert[0]);

            for (int i = 1; i < 480; i++)
            {
                xKoor += 34;
                btnExpert[i] = new Button();
                btnExpert[i].Size = boyut;
                btnExpert[i].BackColor = Color.DarkGray;
                btnExpert[i].Text += i;

                if (i % 30 == 0)
                {
                    xKoor = 50;
                    yKoor += 34;
                    btnExpert[i].Location = new Point(xKoor, yKoor);
                    this.Controls.Add(btnExpert[i]);
                }
                else
                {
                    btnExpert[i].Location = new Point(xKoor, yKoor);
                    this.Controls.Add(btnExpert[i]);
                }
                int k = 0;
                bool atandiMi = true;
                while (atandiMi && k < 99)
                {
                    if (mayin99dizi[k] == i)
                    {
                        btnExpert[i].Click += new EventHandler(Mayinli);
                        btnExpert[i].Text = "mayin";
                        btnExpert[i].ForeColor = Color.DarkGray;
                        atandiMi = false;
                    }
                    k++;
                }
                if (btnExpert[i].Text == "mayin")
                {
                    continue;
                }
                else
                {
                    btnExpert[i].Click += new EventHandler(Mayinsiz);
                }
                btnExpert[i].ForeColor = Color.DarkGray;
                btnExpert[i].FlatAppearance.BorderColor = Color.Black;
            }
            int m = 0;
            bool atandiMi1 = true;
            while (atandiMi1 && m < 99)
            {
                if (mayin99dizi[m] == 0)
                {
                    btnExpert[0].Click += new EventHandler(Mayinli);
                    btnExpert[0].Text = "mayin";
                    btnExpert[0].ForeColor = Color.DarkGray;
                    atandiMi1 = false;
                }
                m++;
            }
            if (btnExpert[0].Text != "mayin")
            {
                btnExpert[0].Click += new EventHandler(Mayinsiz);
            }
            return btnExpert;
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
            for (int i = 0; i < mayin99dizi.Length; i++)
            {
                btnExpert11[mayin99dizi[i]].Image = pbMayin2.Image;
                btnExpert11[mayin99dizi[i]].Text = "";
                btnExpert11[mayin99dizi[i]].Enabled = false;
            }

            tBasla.Stop();
            for (int i = 0; i < btnExpert11.Length; i++)// eventler kaldırılıyor.
            {
                btnExpert11[i].Click -= Mayinsiz;
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
                if (btnExpert11[i + 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 30].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 31].Text == "mayin") { sayac++; }
            }
            else if (i == 29) // Sağ üst köşe
            {
                if (btnExpert11[i - 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 29].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 30].Text == "mayin") { sayac++; }
            }
            else if (i == 479) // Sağ alt köşe
            {
                if (btnExpert11[i - 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 31].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 30].Text == "mayin") { sayac++; }
            }
            else if (i == 450) // Sol alt köşe
            {
                if (btnExpert11[i + 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 29].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 30].Text == "mayin") { sayac++; }
            }
            else if (i % 30 == 0)// Kare sol taraf
            {
                if (btnExpert11[i - 30].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 29].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 31].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 30].Text == "mayin") { sayac++; }
            }
            else if (i > 0 && i < 29)// Kare üst taraf
            {
                if (btnExpert11[i - 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 29].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 30].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 31].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 1].Text == "mayin") { sayac++; }
            }
            else if ((i + 1) % 30 == 0 && i > 29)// Kare sağ taraf
            {
                if (btnExpert11[i - 30].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 31].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 29].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 30].Text == "mayin") { sayac++; }
            }
            else if (i > 450 && i < 479)// Kare alt taraf
            {
                if (btnExpert11[i - 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 31].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 30].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 29].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 1].Text == "mayin") { sayac++; }
            }
            else // Kare iç taraflar
            {
                if (btnExpert11[i - 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 31].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 30].Text == "mayin") { sayac++; }
                if (btnExpert11[i - 29].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 1].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 31].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 30].Text == "mayin") { sayac++; }
                if (btnExpert11[i + 29].Text == "mayin") { sayac++; }
            }
            y.Text = sayac.ToString(); y.BackColor = Color.LightBlue; y.Font = new Font("Microsoft Sans Serif", 10);
            y.ForeColor = Color.Black; y.Enabled = false;

            if (acilanMayinSayisi == 381)
            {
                for (int m = 0; m < mayin99dizi.Length; m++)
                {
                    btnExpert11[mayin99dizi[m]].Image = pbMayin2.Image;
                    btnExpert11[mayin99dizi[m]].Text = "";
                    btnExpert11[mayin99dizi[m]].Enabled = false;
                }
                tBasla.Stop();
                MessageBox.Show("Tebrikler. Kazandınız.\nBitirme Süreniz: " + bitirmeSuresi);
            }
            return;
        } 
        #endregion

    }
}
