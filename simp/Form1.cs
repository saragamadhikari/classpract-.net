//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace simp
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void label5_Click(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            int num1 = int.Parse(textBox1.Text);
//            int num2 = int.Parse(textBox2.Text);

//            int result=num1+num2;
//            textBox3.Text =result.ToString();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            int num1 = int.Parse(textBox1.Text);
//            int num2 = int.Parse(textBox2.Text);

//            int result = num1 - num2;
//            textBox3.Text = result.ToString();
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            int num1 = int.Parse(textBox1.Text);
//            int num2 = int.Parse(textBox2.Text);

//            int result = num1 * num2;
//            textBox3.Text = result.ToString();
//        }

//        private void button4_Click(object sender, EventArgs e)
//        {
//            int num1 = int.Parse(textBox1.Text);
//            int num2 = int.Parse(textBox2.Text);

//            int result = num1 / num2;
//            textBox3.Text = result.ToString();



//        }

//        private void textBox3_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void button5_Click(object sender, EventArgs e)
//        {
//            textBox1.Clear();
//            textBox2.Clear();
//            textBox3.Clear();

//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            // Allow control keys like backspace
//            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
//            {
//                e.Handled = true; // Ignore the input
//            }
//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {
//            // Allow control keys like backspace
//            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
//            {
//                e.Handled = true; // Ignore the input
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 + num2;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 - num2;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 * num2;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);

                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                float result = num1 / num2;
                textBox3.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys like backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Same numeric validation for textBox2
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
