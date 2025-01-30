using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public double AreaOfCircle(double radius)
        {
            return 3.1416 * radius * radius;
        }

        public double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public double AreaOfTriangle(double baseLength, double height, bool Triamgle)
        {
            if (Triamgle)
                return 0.5 * baseLength * height;
            else
            {
                return baseLength * height;
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(textBox1.Text);
            double width = Convert.ToDouble(textBox2.Text);
            double area = AreaOfRectangle(length, width);

            listBox1.Items.Add($"Rectangle Area: {area}");
            textBox6.Text = area.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox3.Text);
            double area = AreaOfCircle(radius);

            listBox1.Items.Add($"Circle Area: {area}");
            textBox6.Text = area.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double baselegnth = Convert.ToDouble(textBox4.Text);
            double height = Convert.ToDouble(textBox5.Text);
            double area = AreaOfTriangle(baselegnth, height, true);

            listBox1.Items.Add($"Triangle Area: {area}");
            textBox6.Text = area.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
