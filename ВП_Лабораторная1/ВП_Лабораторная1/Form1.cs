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
    public partial class Form1 : Form
    {
        Form2 F2;
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void оПрограммеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" \n\t Elizabeth Omelnitskaya, Maria Bakanova  \n\t This is a program that looks for palindromes \n\t\t (c) 2015 \t\t ", "Аuthors: ");
        }

        private void проверкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F2 = new Form2();
            F2.Show();
        }
    }
}
