using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Cube

namespace _15_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            double A, V, S;
            A = Double.Parse(textBox2.Text);
            Cube C = new Cube(A);
            S = C.CalculateSurfaceArea();
            V = C.CalculateVolume();
            label1.Text = "Площа поверхні \nкуба = " + S.ToString();
            label3.Text = "Об'єм куба \n= " + V.ToString();

            /*V = Math.Pow(A, 3);
            S = 4 * Math.Pow(A, 2);
            label1.Text = "Площа поверхні \nкуба = " + S.ToString();
            label3.Text = "Об'єм куба \n= " + V.ToString();*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fzavd fz = new Fzavd();
            fz.Show();
        }

        private void завдвнняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fzavd fz = new Fzavd();
            fz.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void частинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSpart fz = new FSpart();
            fz.Show();
        }
    }
}
