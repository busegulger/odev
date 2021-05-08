using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = MatematikselIslemler.matematikselIslemler.Toplama("3", 4);
            MessageBox.Show(sonuc.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = MatematikselIslemler.Islemler.Cikarma("12", "15");
            MessageBox.Show(sonuc.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sonuc = Carpimlar.CarpimlarClass.Carpma();
            MessageBox.Show(sonuc.ToString());
        }

        private void button4_Click_1 (object sender, EventArgs e)
        {
            double sonuc = Bolme("100", 2, 2, "2", 2);
            MessageBox.Show(sonuc.ToString());
        }

        private double Bolme(string a, int b, double c, string d, int e)
        {
            double s1 = Convert.ToDouble(a);
            double s2 = Convert.ToDouble(b);
            double s3 = Convert.ToDouble(c);
            double s4 = Convert.ToDouble(d);
            double s5 = Convert.ToDouble(e);

            double sonuc = s1 / s2 / s3 / s4 / s5;

            return sonuc;


        }

        
    }
}