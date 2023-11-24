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
using static System.Math;

namespace _4
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(NumberV.Text, out int r))
            {
                MessageBox.Show("Введите A");
            }
            if (!int.TryParse(NumberB.Text, out int t))
            {
                MessageBox.Show("Введите B");
            }
            if (!int.TryParse(NumberN.Text, out int y))
            {
                MessageBox.Show("Введите C");
            }
            int z;
            double x;
            z = (r / y) * (t / y);
            x = r * t - z * Sqrt(y);
            Resul.Text += $"Количество размещённых квадратов: {z}" + "\n";
            Resul.Text += $"Незанятая часть прямоугольника: {x}" + "\n";
        }
    }
}
