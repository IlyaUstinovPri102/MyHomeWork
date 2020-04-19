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
    public partial class Form3 : Form
    {
        static string napisano;
        static int time = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            napisano = Convert.ToString(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (napisano == "Трава")
            {
                timer1.Enabled = false;
                time = 0;
                Hide();
                Form4 Ввести = new Form4();
                Ввести.ShowDialog();
                Close();
            }
            else
            {
                timer1.Enabled = false;
                time = 0;
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

        private void Form3_Load(object sender, EventArgs e)
        {
            time = 0;
            timer1.Enabled = true;
        }
    }
}
