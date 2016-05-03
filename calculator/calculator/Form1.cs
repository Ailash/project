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
            ICalculator calc = CalculatorFactory.CreateCalculator(((Button) sender).Text);
            double result = calc.Calculate(first, second);
            label1.Text = result.ToString();
        }

        private void SingleCalculator(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            ISingleCalculator calc = SingleCalculatorFactory.CreateCalculator(((Button)sender).Text);
            double result = calc.Calculate(first);
            label1.Text = result.ToString();
        }
       
    }
}
