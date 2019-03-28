using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDevam.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int artişOrani = rnd.Next(1,20);
            pBDurum.Step = artişOrani;
            pBDurum.PerformStep();

            int suAnkiDeger = pBDurum.Value;

            if (suAnkiDeger <= 20)
            {
                lblDurum.Text = "Program yüklemeye hazırlanıyor...";
            }
            else if (suAnkiDeger > 20 && suAnkiDeger <= 45)
            {
                lblDurum.Text = "Güvenlik modülü yükleniyor...";
            }
            else if (suAnkiDeger > 45 && suAnkiDeger <= 70)
            {
                lblDurum.Text = "Veritabanı modülü yükleniyor...";
            }
            else if (suAnkiDeger > 70 && suAnkiDeger <= 95)
            {
                lblDurum.Text = "Bellek optimizasyonu yapılıyor...";
            }
            else if (suAnkiDeger > 95 && suAnkiDeger < 100)
            {
                lblDurum.Text = "Yükleme tamamlanıyor...";
            }
            else {
                
                timer1.Stop();
                lblDurum.Text = "Yükleme başarı ile tamamlandı!";
                btnDevam.Enabled = true;
            }

        }
    }
}
