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
    public partial class Form1 : Form
    {
        static int chislo = 0;
        static int time = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = time.ToString();
            if (time > 10)
            {
                Hide();
                timer1.Enabled = false;
                time = 0;
                chislo = 0;
                Form1 Начать_игру = new Form1();
                Начать_игру.ShowDialog();
                Close();
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            time = 0;
            chislo = 0;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((time < 10) && (chislo == 4))
            {
                timer1.Enabled = false;
                Hide();
                Form2 кнопка = new Form2();
                кнопка.ShowDialog();
                Close();
            }
            else chislo++;
        }
    }
}
