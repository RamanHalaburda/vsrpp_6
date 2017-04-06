using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsrpp_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
            1. На перегрузку операторов. Описать класс комплексных чисел.
            Реализовать операцию сложения, умножения, вычитания, проверку на
            равенство двух комплексных чисел. Переопределить метод ToString() для
            комплексного числа. Протестировать на простом примере.
        */

        private void button1_Click(object sender, EventArgs e)
        {
            Double aRe = 0, aIm = 0, bRe = 0, bIm = 0;

            if (Double.TryParse(textBox1.Text, out aRe)
                && Double.TryParse(textBox2.Text, out aIm)
                && Double.TryParse(textBox3.Text, out bRe)
                && Double.TryParse(textBox4.Text, out bIm))
            { 
                ComplexNumber A = new ComplexNumber(aRe, aIm);
                ComplexNumber B = new ComplexNumber(bRe, bIm);

                ComplexNumber sum = A + B;
                textBox5.Text = sum.ToString();

                ComplexNumber mult = A * B;
                textBox6.Text = mult.ToString();

                ComplexNumber sub = A - B;
                textBox7.Text = sub.ToString();

                Boolean isEqual = A == B;
                textBox8.Text = isEqual.ToString();
            }
            else
            {
                throw new FormatException("wrong format of input values!");
            }
        }
    }
}
