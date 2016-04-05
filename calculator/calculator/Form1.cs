using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculator(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button)sender).Text)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;
                default:
                    throw new Exception("неизвестная ошибка");
            }
            label1.Text = result.ToString();
        }

       
    }
}
