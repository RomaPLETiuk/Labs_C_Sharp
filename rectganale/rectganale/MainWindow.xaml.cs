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

namespace rectganale
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

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Отримати прямокутник, на який було натиснуто
            var rectangle = (Rectangle)sender;

            if (e.ChangedButton == MouseButton.Right)
            {
                rectangle.Width *= 1.2;
                rectangle.Height *= 1.2;
            }
            else if (e.ChangedButton == MouseButton.Left)
            {
                rectangle.Width -= 10;
                rectangle.Height -= 10;
            }
        }
    }
}
