using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double Result = 0;
        String Operation = "";
        bool operationStatus = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || (operationStatus)) { textBox_Result.Clear(); }

            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains(".")) { textBox_Result.Text = textBox_Result.Text + button.Text; }
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }

            operationStatus = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            if (Result != 0)
            {
                button15.PerformClick();
                Button button = (Button)sender;
                Operation = button.Text;
                operationStatus = true;
            }
            else
            {
                Button button = (Button)sender;
                Operation = button.Text;
                Result = Double.Parse(textBox_Result.Text);
                operationStatus = true;
            }
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            Result = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    textBox_Result.Text = (Result + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (Result - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (Result * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (Result / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            Result = Double.Parse(textBox_Result.Text);
            
        }
    }
}
