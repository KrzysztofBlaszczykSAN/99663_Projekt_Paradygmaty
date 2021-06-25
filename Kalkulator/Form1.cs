using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string l1, l2;
        char znak='?';
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            znak = '+';
        }

        private void r2_3_Click(object sender, EventArgs e)
        {
            wyswietl(9);
        }

        private void r1_2_Click(object sender, EventArgs e)
        {
            znak = '/';

        }

        private void r2_1_Click(object sender, EventArgs e)
        {
            wyswietl(7);
        }

        private void r2_2_Click(object sender, EventArgs e)
        {
            wyswietl(8);
        }

        private void r2_4_Click(object sender, EventArgs e)
        {
            znak = '*';

        }

        private void r3_1_Click(object sender, EventArgs e)
        {
            wyswietl(4);
        }

        private void r3_2_Click(object sender, EventArgs e)
        {
            wyswietl(5);
        }

        private void r3_3_Click(object sender, EventArgs e)
        {
            wyswietl(6);
        }

        private void r3_4_Click(object sender, EventArgs e)
        {
            znak = '-';

        }

        private void r4_1_Click(object sender, EventArgs e)
        {
            wyswietl(1);
        }

        private void r4_2_Click(object sender, EventArgs e)
        {
            wyswietl(2);
        }

        private void r4_3_Click(object sender, EventArgs e)
        {
            wyswietl(3);
        }

        private void r4_4_Click(object sender, EventArgs e)
        {
            znak = '+';
       
        }

        private void r5_1_Click(object sender, EventArgs e)
        {
            wyswietl(0);
        }

        private void r5_2_Click(object sender, EventArgs e)
        {
          
        }

        private void r5_3_Click(object sender, EventArgs e)
        {
            switch (znak)
            {
                case ('+'):
                    textBox1.Text = (int.Parse(l1) + (int.Parse(l2))).ToString();
                    break;
                case ('-'):
                    textBox1.Text = (int.Parse(l1) - (int.Parse(l2))).ToString();
                    break;
                case ('*'):
                    textBox1.Text = (int.Parse(l1) * (int.Parse(l2))).ToString();
                    break;
                case ('/'):
                    textBox1.Text = (int.Parse(l1) / (int.Parse(l2))).ToString();
                    break;
                    
            }
            l1 = "";
            l2 = "";
            znak = '?';
        }
        
        private void wyswietl(int get_value)
        {
            if (znak == '?')
            {
                l1 += get_value;
                textBox1.Text = l1;
            }
            else
            {
                l2 += get_value;
                textBox1.Text = l2;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void r1_1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
