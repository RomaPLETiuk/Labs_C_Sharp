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

namespace SimpleProg
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
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string pr, name, pb, data;
            name = tex1.Text;
            pr = tex3.Text;
            pb = tex4.Text;
            //string[] array = pb.Split(' ');

            data = " Ім'я:   " + name + "\n Кількість букв в 3 слові: "+ pb.Length +  "\n"+" Виконав Плетюк Роман ІТ НУБІП";
            tex2.Text = data;
            
            
        }

    }
}
