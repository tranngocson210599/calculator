using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
   // int val1, val2;
   // char sign;
    public partial class Calculator : Form
    {

        double val1, val2;
        string sign, text_screen;
        
        public Calculator()
        {
            InitializeComponent();
        }
        //Del
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            text_screen = "";
           val1 = 0;
            val2 = 0;
            sign = " ";
        }

        //-
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = double.Parse(textBox1.Text);
            }
            catch
            {
                // MessageBox.Show("Error", "Error");
            }
            textBox1.Text += button10.Text;
            text_screen = "";
            sign = "-";
        }
        // /
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = double.Parse(textBox1.Text);
            }
            catch
            {
                // MessageBox.Show("Error", "Error");
            }
            textBox1.Text += button18.Text;
            text_screen = "";
            sign = "/";
        }
        //X
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = double.Parse(textBox1.Text);
            }
            catch
            {
                // MessageBox.Show("Error", "Error");
            }
            textBox1.Text += button14.Text;
            text_screen = "";
            sign = "x";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += button16.Text;
            text_screen += button16.Text;

        }
        // <=
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if(string.Compare(textBox1.Text,"",true)!=0)
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
           // text_screen = text_screen.Remove(text_screen.Length - 1);
        }
        //7
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
            text_screen += button3.Text;
        }
        //8
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
            text_screen += button4.Text;
        }
        //9
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
            text_screen += button5.Text;
        }

        // +
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = double.Parse(textBox1.Text);
            }
             catch
            {
               // MessageBox.Show("Error", "Error");
            }
            textBox1.Text += button6.Text;
            text_screen = "";
            sign = "+";
        }
        //4
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
            text_screen += button7.Text;
        }
        //5
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
            text_screen += button8.Text;
        }
        //6
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            text_screen += button9.Text;
        }
        //1
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
            text_screen += button11.Text;
        }
        //2
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
            text_screen += button12.Text;
        }
        //3
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
            text_screen += button13.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
            text_screen += button15.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // textBox1.Text += button17.Text;
            // text_screen += button17.Text;
            try
            {
                val2 = double.Parse(text_screen);
            }
            catch
            {

            }
            if(string.Compare(sign,"-",true)==0)
            {
                textBox2.Text = (val1 - val2).ToString();
            }
            if (string.Compare(sign, "+", true) == 0)
            {
                textBox2.Text = (val1 + val2).ToString();
            }
            if (string.Compare(sign, "/", true) == 0)
            {
                textBox2.Text = (val1 / val2).ToString();
            }
            if (string.Compare(sign, "x", true) == 0)
            {
                textBox2.Text = (val1 * val2).ToString();
            }
        }
    }
}
