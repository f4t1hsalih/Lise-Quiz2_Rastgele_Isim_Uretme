using System;
using System.Windows.Forms;

namespace Quiz2_Rastgele_Isim_Uretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b, c, s;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i < 8; i++)
            {
                a = rnd.Next(0, 2);
                textBox1.Text += a;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s = 0;
            textBox2.Clear();
            textBox3.Clear();

            for (int i = 0; i < 8; i++)
            {
                b = rnd.Next(0, 2);
                c = rnd.Next(0, 2);
                textBox2.Text += b;
                textBox3.Text += c;
                if (b == c) s++;
            }
            if (s < 4) label1.Text = "İkiz İsimleri Yanlış Tekrar Dene";
            else if (s >= 4) label1.Text = "İkiz İsimleri Kullanılabilir";
        }
    }
}
