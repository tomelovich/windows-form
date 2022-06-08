using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение X
            textBox1.Text = "0,1722";
            // Начальное значение Y
            textBox2.Text = "6,33";
            // Начальное значение Z
            textBox3.Text = "0,000325";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox4.Text += Environment.NewLine +
            "X = " + x.ToString();
            // Считывание значения Y
            double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно
            textBox4.Text += Environment.NewLine +
            "Y = " + y.ToString();
            // Считывание значения Z
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно
            textBox4.Text += Environment.NewLine +
            "Z = " + z.ToString();
            // Вычисляем арифметическое выражение
            double a = 5* Math.Atan(x);
            double b = 0.25 * Math.Acos(x);
            double c = (x + 3 * Math.Abs(x - y) + Math.Pow(x, 2)) / (Math.Abs(x - y) * z + Math.Pow(x, 2));
            double u = a - b * c;
            // Выводим результат в окно
            textBox4.Text += Environment.NewLine +
            "Результат U = " + u.ToString();
        }
    }
}
