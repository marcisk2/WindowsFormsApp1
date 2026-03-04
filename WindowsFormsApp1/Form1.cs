using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int a,b = 0;
        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello world";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            b += 1;
            textBox1.Text = b.ToString();

            textBox2.Left -= 10;
            a += 10;
            textBox2.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            int s = a + b;
            label1.Text = "sum=" + s.ToString();
            double av = s / 2.0;
            label2.Text = "av=" + av.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(textBox5.Text);
            double x2 = double.Parse(textBox6.Text);
            double y1 = double.Parse(textBox7.Text);
            double y2 = double.Parse(textBox8.Text);
            double x = 0;
            double y = 0;
            double z = 0;
            if (x2 > x1)
            {
                x = x2 - x1;
            }
            else { x = x1 - x2; }

            if (y2 > y1)
            {
                y = y2 - y1;
            }
            else { y = y1 - y2; }
            z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            label9.Text = "Attālums starp punktiem=" + z.ToString("F2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox9.Text);
            double b = double.Parse(textBox10.Text);
            double S;
            S = a * b;
            label12.Text = "S=" + S.ToString("F2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double r  = double.Parse(textBox11.Text);
            double S;
            S = Math.PI * r * r;
            label14.Text = "S=" + S.ToString("F2");
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox15.Text);
            double S;
            S = Math.PI * r * r;
            label20.Text = "S=" + S.ToString("F2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox14.Text);
            double b = double.Parse(textBox13.Text);
            double S;
            S = a * b;
            label17.Text = "S=" + S.ToString("F2");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            if (comboBox1.Text == "Taisnstūris")
                groupBox1.Show();
            else if (comboBox1.Text == "Aplis")
                groupBox2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (Control c in Form1.ActiveForm.Controls)
                c.Left += 20;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            foreach (Control c in Form1.ActiveForm.Controls)
                c.Left -= 20;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            b += 1;
            textBox1.Text = b.ToString();

            textBox2.Left += 10;
            a -= 10;
            textBox2.Text = a.ToString();
        }
    }
}
