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
            try
            {
                string text = textBox1.Text;
                if (String.IsNullOrEmpty(text))
                {
                    throw new FormatException();
                }
                char[] obrtext = text.ToCharArray();
                Array.Reverse(obrtext);
                string finaltext = new string(obrtext);
                if (text == finaltext)
                {
                    MessageBox.Show(" \n\t Данная запись является палиндромом \n\t\t ");
                }
                if (text != finaltext)
                {
                    MessageBox.Show(" \n\t Данная запись не является палиндромом \n\t\t ");
                }
            }
            catch
            {
                MessageBox.Show(" \n\t Неверно введен текст! \n\t\t ");
            }
        }
    }
}
