using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cipher
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class CaesarCipher
        {
            
            const string alfabet = "АБВГДЕЄЖЗИЙКЇЛМНОПРСТУФХЦЧШЩЬЮЯ";

            private string CodeEncode(string text, int k)
            {
                
                var fullAlfabet = alfabet + alfabet.ToLower();
                var letterQty = fullAlfabet.Length;
                var retVal = "";
                for (int i = 0; i < text.Length; i++)
                {
                    var c = text[i];
                    var index = fullAlfabet.IndexOf(c);
                    if (index < 0)
                    {
                       
                        retVal += c.ToString();
                    }
                    else
                    {
                        var codeIndex = (letterQty + index + k) % letterQty;
                        retVal += fullAlfabet[codeIndex];
                    }
                }

                return retVal;
            }

           
            public string Encrypt(string plainMessage, int key)
                => CodeEncode(plainMessage, key);

            
            public string Decrypt(string encryptedMessage, int key)
                => CodeEncode(encryptedMessage, -key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cipher = new CaesarCipher();
            var message = text1.Text;
            var secretKey = Convert.ToInt32(text2.Text);
            
            var encryptedText = cipher.Encrypt(message, secretKey);
            text3.Text = encryptedText;
           // text4.Text = cipher.Decrypt(encryptedText, secretKey);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var cipher = new CaesarCipher();
            var message = text1_1.Text;
            var secretKey = Convert.ToInt32(text2_2.Text);

            var encryptedText = cipher.Decrypt(message, secretKey);
            text3_3.Text = encryptedText;
            // text4.Text = cipher.Decrypt(encryptedText, secretKey);

        }



    }
}
