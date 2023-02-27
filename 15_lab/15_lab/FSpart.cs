using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _15_lab
{
    public partial class FSpart : Form
    {
        public FSpart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            String pr, name;
            String a = " ";
            int m = 0;
            int n = text.Length;
            // шукаємо позицію пропуску
            for (int i = 0; i < n; i++)
            {
                if (text.Substring(i, 1) == a) m = i;
            }
            // Вирізаємо слова у реченні
            pr = text.Substring(0, m);
            name = text.Substring(m + 1, n - (m + 1));
            label2.Text = name +" " +pr+ "\nДовжина слів: "+ (n-1);


            SaveFileDialog open = new SaveFileDialog();
        
            open.ShowDialog();

            string path = open.FileName;

            try
            {
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(text);                  
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
