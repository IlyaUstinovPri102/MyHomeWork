using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz
{
    public partial class Form2 : Form
    {
        static int otvet = 64;
        static int time = 0;
        static int napisano;
        static string text = "";
        static string text1;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            time = 0;
            timer1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            text1 = Convert.ToString(textBox1.Text);
            if (text1 == text)
            {
                timer1.Enabled = false;
                Hide();
                Form1 Начать_игру = new Form1();
                Начать_игру.ShowDialog();
                Close();
            }
            napisano = Convert.ToInt32(textBox1.Text);
            if(napisano == otvet)
            {
                timer1.Enabled = false;
                Hide();
                Form3 Ввести = new Form3();
                Ввести.ShowDialog();
                Close();
            }
            else
            {
                timer1.Enabled = false;
                Hide();
                Form1 Начать_игру = new Form1();
                Начать_игру.ShowDialog();
                Close();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label2.Text = time.ToString();
            if (time > 10)
            {
                Hide();
                timer1.Enabled = false;
                time = 0;
                Form1 Начать_игру = new Form1();
                Начать_игру.ShowDialog();
                Close();
            }
        }
    }
}
