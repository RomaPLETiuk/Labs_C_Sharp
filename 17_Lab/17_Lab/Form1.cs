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
using System.Xml.Serialization;

namespace _17_Lab
{
    public partial class Form1 : Form
    {
        XmlSerializer formater;
        FileStream fs;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);

            button1.Click += button1_Click;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);            
            }
            pictureBox1.Image = bmp;
        }
 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int radius = int.Parse(textBox1.Text);
            if (radius < 1)
            {
                radius = 100;
            }
          
            int centerX = ClientRectangle.Width / 3;
            int centerY = ClientRectangle.Height / 3; 
            
            RegPentagon rP = new RegPentagon(radius);
            Point[] points = rP.GetPoints(centerX, centerY);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawPolygon(Pens.Red, points);
            }
            pictureBox1.Image = bmp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(textBox1.Text);

            RegPentagon rP = new RegPentagon(radius);
            formater = new XmlSerializer(typeof(RegPentagon));
            fs = new FileStream("pentagon.xml", FileMode.OpenOrCreate);
            formater.Serialize(fs, rP);
            fs.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegPentagon rP;
            if (File.Exists("pentagon.xml"))
            {
                fs = new FileStream("pentagon.xml", FileMode.Open);
                formater = new XmlSerializer(typeof(RegPentagon));
                rP = (RegPentagon)formater.Deserialize(fs);
                fs.Close();
                //var p = rP.radius;
                textBox1.Text = Convert.ToString(rP.radius);


                int centerX = ClientRectangle.Width / 3;
                int centerY = ClientRectangle.Height / 3;

                
                Point[] points = rP.GetPoints(centerX, centerY);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawPolygon(Pens.Red, points);
                }
                pictureBox1.Image = bmp;

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this.Close();
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = bmp;
        }
    }
}
