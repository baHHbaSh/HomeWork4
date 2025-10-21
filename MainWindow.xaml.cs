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

namespace HomeWork4
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
        static private int Cake(byte n)
        {
            switch (n)
            {
                case 0:
                    MessageBox.Show("Я съел торт :)"); return 0;
                default:
                    return n % 2 == 0 ? n / 2 : n;
            }
        }
        static private bool Chess(byte x, byte y)
        {
            if (x > 8 || y > 8 || x == 0 || y == 0)
                MessageBox.Show("Недопустимая позиция");
            return (x + y) % 2 == 0;
        }
        static private int Pool(int k, int l, int m, int n)
        {
            return Math.Min(Math.Min(k, l), Math.Min(m, n));
        }
        static private bool Brick(int a, int b, int c, int d, int e)
        {
            if (
                    a < d && b < e || a < e && b < d ||
                    b < d && c < e || b < e && c < d ||
                    a < d && c < e || a < e && c < d
                )
                return true;
            return false;
        }
        static private string Bochki(int n)
        {
            switch (n % 10)
            {
                case 1: return $"{n} bochka";
                case 2:
                case 3:
                case 4: return $"{n} bochki";
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0: return $"{n} bochek";
            }
            return ""; // От ошибок
        }

        private void Z1R_Click(object sender, RoutedEventArgs e)
        {
            Z1R.Content = $"Нужно нарезать торт  {Cake(byte.Parse(Z1A.Text))} раз";
        }

        private void Z2R_Click(object sender, RoutedEventArgs e)
        {
            var n = Chess(byte.Parse(Z2X.Text), byte.Parse(Z2Y.Text)) ? "чёрная" : "белая";
            Z2R.Content = $"Клетка { n }";
        }

        private void Z3R_Click(object sender, RoutedEventArgs e)
        {
            Z3R.Content = $"Близжайший бортик {Pool(int.Parse(Z3K.Text), int.Parse(Z3L.Text), int.Parse(Z3M.Text), int.Parse(Z3N.Text))}";
        }

        private void Z4R_Click(object sender, RoutedEventArgs e)
        {
            Z4R.Content = Brick(int.Parse(Z4A.Text), int.Parse(Z4B.Text), int.Parse(Z4C.Text), int.Parse(Z4D.Text), int.Parse(Z4E.Text))?"Кирич в дырке":"Кирпич не поместился";
        }

        private void Z5R_Click(object sender, RoutedEventArgs e)
        {
            Z5R.Content = Bochki(int.Parse(Z5A.Text));
        }
    }
}
