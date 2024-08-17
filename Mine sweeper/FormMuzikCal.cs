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
    public partial class FormMuzikCal : Form
    {
        public FormMuzikCal()
        {
            InitializeComponent();
        }

        private void btnSarkiSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            //Müzik çaların çalabileceği dosyaları FileDialog sayesinde filtreledik.
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "Dosya Seç";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            //Seçilen dosyanın ismini TextBox içerisine aktardık.

            axWindowsMediaPlayer1.URL = textBox1.Text;
            //Form üzerinde ki media player'ın çalacağı parçayı TextBox'dan almasını sağladık.
        }
    }
}
