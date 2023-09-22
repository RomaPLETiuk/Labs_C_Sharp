using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace Yes_No
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        

       



        private void Yes_Clik_L_Mouse(object sender, MouseButtonEventArgs e)
        {
            // ваш код обработки щелчка мыши
            W_2 w_2 = new W_2();
            w_2.ShowDialog();
        }
        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Random random = new Random();
            double maxWidth = canvas.ActualWidth - rectangle.Width;
            double maxHeight = canvas.ActualHeight - rectangle.Height;

            double newLeft = random.NextDouble() * maxWidth;
            double newTop = random.NextDouble() * maxHeight;

            Canvas.SetLeft(rectangle, newLeft);
            Canvas.SetTop(rectangle, newTop);
            Canvas.SetLeft(label, newLeft + 50);
            Canvas.SetTop(label, newTop + 10);
            // Отримати випадкові координати для нового положення
            //double x = random.Next(0, (int)(ActualWidth - rectangle.Width));
            //double y = random.Next(0, (int)(ActualHeight - rectangle.Height));

            //// Змінити положення прямокутника та тексту
            //Canvas.SetLeft(rectangle, x);
            //Canvas.SetTop(rectangle, y);
            //Canvas.SetLeft(label, x+50);
            //Canvas.SetTop(label, y+10);
        }

    }
}
