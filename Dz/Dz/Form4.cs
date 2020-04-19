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
    public partial class Form4 : Form
    {
        static int time = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox2.Checked) && (radioButton2.Checked))
            {
                Hide();
                timer1.Enabled = false;
                time = 0;
                Form5 Готово = new Form5();
                Готово.ShowDialog();
                Close();
            }
            else
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
