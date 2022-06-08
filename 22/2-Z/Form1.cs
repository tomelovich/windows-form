using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox
            double x = Convert.ToDouble(textBox1.Text);
           
            double b = Convert.ToDouble(textBox3.Text);
            // Ввод исходных данных в окно результатов
            textBox4.Text = "Результаты работы программы " +
            Environment.NewLine;
            textBox4.Text += "При X = " + textBox1.Text +
            Environment.NewLine;
            
            textBox4.Text += "При B = " + textBox3.Text +
            Environment.NewLine;

            // Вычисление выражения
            double u;
            if ((x * b > 1) && (x * b < 10))
                u = Math.Pow(Math.E, Math.Pow(x, 2));
            else
            if ((x * b > 12) && (x * b < 40))
                u = Math.Sqrt(Math.Abs(Math.Pow(x, 2) + 4 * b));
            else
                u = b * Math.Pow(Math.Pow(x, 2), 2);

            // Вывод результата
            textBox4.Text += "U = " + u.ToString() +
            Environment.NewLine;
        }
    }
}
