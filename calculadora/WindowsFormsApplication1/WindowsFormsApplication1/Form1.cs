using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
       // bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "0";
        }

        private void button00_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "9";
        }

        private void button_virgula_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + ",";
        }

        private void digitou(object sender, EventArgs e)
        {
            Button digito = sender as Button;
            textBoxresultado.Text = digito.Text;
        }

        private void apagar(object sender, EventArgs e)
        {
            textBoxresultado.Text = "";
        }

        private void calculador(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBoxresultado.Text = (value + Double.Parse(textBoxresultado.Text)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "-":
                    textBoxresultado.Text = (value - Double.Parse(textBoxresultado.Text)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "*":
                    textBoxresultado.Text = (value * Double.Parse(textBoxresultado.Text)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "/":
                    textBoxresultado.Text = (value / Double.Parse(textBoxresultado.Text)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "√":
                    textBoxresultado.Text = (Math.Sqrt(value)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "^":
                    textBoxresultado.Text = (Math.Pow(value, Double.Parse(textBoxresultado.Text))).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "Resto da divisão":
                    textBoxresultado.Text = (value % Double.Parse(textBoxresultado.Text)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "%":
                    textBoxresultado.Text = (value/100 * Double.Parse(textBoxresultado.Text)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "SEN":
                    textBoxresultado.Text = (Math.Sin(value * Math.PI / 180)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "COS":
                    textBoxresultado.Text = (Math.Cos(value * Math.PI / 180)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                case "TAN":
                    textBoxresultado.Text = (Math.Tan(value * Math.PI / 180)).ToString();
                    value = Double.Parse(textBoxresultado.Text);
                    break;
                default:
                    break;
            }
        }

        private void click_operator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBoxresultado.Text);
            //operation_pressed = true;
            textBoxresultado.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
