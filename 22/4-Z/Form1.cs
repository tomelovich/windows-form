using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8","9","10", "11", "12", "13", "14", "15","16", "17", "18", "19", "20", "21","22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox2.Items.AddRange(new string[] { "January", "February", "March","April","May", "June", "July", "August", "September", "October","November","December" });
            comboBox3.Items.AddRange(new string[] {"1990", "1991", "1992", "1993", "1994","1995" ,"1996", "1997", "1998", "1999", "2000","2001","2002","2003","2004","2005","2006","2007","2008","2009"});
            comboBox4.Items.AddRange(new string[] { "Гродно", "Минск", "Витебск", "Могилёв", "Гомель", "Брест"});
            comboBox5.Items.AddRange(new string[] { "МТС", "A1", "life:)" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sex = "", workExp = "", gWork = "", car = "", certificate = "",
            rightsA = "", rightsB = "", rightsC = "", rightsD = ""; 
            string day, month, year;
            string f = textBox1.Text;
            string n = textBox2.Text;
            string o = textBox3.Text;
            string city = comboBox4.Text;
            string mail = textBox4.Text;
            string op = comboBox5.Text;
            day = comboBox1.Text;
            month = comboBox2.Text;
            year = comboBox3.Text;
            string num = textBox5.Text;
            
            string min = numericUpDown1.Value.ToString();
            string max = numericUpDown2.Value.ToString();
            if (radioButton1.Checked)
            {
                sex = radioButton1.Text;
            }
            else
            {
                sex = radioButton2.Text;
            }
            if (radioButton3.Checked){workExp = radioButton3.Text;}
            else if (radioButton4.Checked){workExp = radioButton4.Text;}
            else if (radioButton5.Checked) { workExp = radioButton5.Text; }
            else if (radioButton6.Checked) { workExp = radioButton6.Text; }
            else if (radioButton7.Checked) { workExp = radioButton7.Text; }

            if (radioButton8.Checked) { gWork = radioButton8.Text; }
            else if (radioButton9.Checked) { gWork = radioButton9.Text; }
            else if (radioButton10.Checked) { gWork = radioButton10.Text; }
            else if (radioButton11.Checked) { gWork = radioButton11.Text; }
            if (checkBox1.Checked)
            {
                car = "Есть машина";
            }
            if (checkBox2.Checked)
            {
                certificate = "Есть водительское удостоверение";
            }
            if (checkBox3.Checked){ rightsA = "Есть права категории A";}
            if (checkBox4.Checked) { rightsB = "Есть права категории B"; }
            if (checkBox5.Checked) { rightsC = "Есть права категории C"; }
            if (checkBox6.Checked) { rightsD = "Есть права категории D"; }
            textBox6.Text = "ФИО : " + f + " " + n + " " + o +
            Environment.NewLine + "Пол: " + sex + Environment.NewLine + "Дата рождения: " +day + " " + month + " " + year + Environment.NewLine + "Место проживания: " +city +Environment.NewLine + "Почта: " + mail + "Телефон: (" + op + ")" +" "+
            num + Environment.NewLine + "Опыт работы: " + workExp + "; Объём ЗП: от " + min + " до " + max + Environment.NewLine + "График работы: " + gWork +Environment.NewLine + car + Environment.NewLine+ certificate +Environment.NewLine + rightsA +" "+ rightsB + " " + rightsC + " " + rightsD;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
