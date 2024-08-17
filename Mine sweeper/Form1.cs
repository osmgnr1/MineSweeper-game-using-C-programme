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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i] is FormBeginner)
                {
                    this.MdiChildren[i].BringToFront(); // Şu an varsa yakaladım ve öne getirdim.
                    return; //İşimi gördüğüm için metodun bu bölümünden sonrasının çalışmasına gerek yok.
                }
            }

            FormBeginner beginner = new FormBeginner();
            beginner.MdiParent = this;
            beginner.Show();
        }

        private void intermadiateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i] is FormIntermadiate)
                {
                    this.MdiChildren[i].BringToFront(); // Şu an varsa yakaladım ve öne getirdim.
                    return; //İşimi gördüğüm için metodun bu bölümünden sonrasının çalışmasına gerek yok.
                }
            }

            FormIntermadiate intermadiate = new FormIntermadiate();
            intermadiate.MdiParent = this;
            intermadiate.Show();
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i] is FormExpert)
                {
                    this.MdiChildren[i].BringToFront(); // Şu an varsa yakaladım ve öne getirdim.
                    return; //İşimi gördüğüm için metodun bu bölümünden sonrasının çalışmasına gerek yok.
                }
            }
            
            FormExpert expert = new FormExpert();
            expert.MdiParent = this;
            expert.Show();
        }

        private void müzikÇalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMuzikCal muzikCal = new FormMuzikCal();
            muzikCal.MdiParent = this;
            muzikCal.Show();
        }
    }
}
