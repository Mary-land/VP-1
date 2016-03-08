using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВП_Лабораторная1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char[] obrtext = text.ToCharArray();
            Array.Reverse(obrtext); // метод поворота символов введённых данных в обратном порядке
            string finaltext = new string(obrtext); // строка с инициализацией символов из массива
            if (text == finaltext) // сравнение исходной строки и перевернутой строкой
            {
                MessageBox.Show(" \n\t Данная запись является палиндромом \n\t\t ");
            }
            if (text != finaltext)
            {
                MessageBox.Show(" \n\t Данная запись не является палиндромом \n\t\t ");
            }
        }
    }
}
