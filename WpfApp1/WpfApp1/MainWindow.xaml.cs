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

namespace WpfApp1
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значения сторон и угла
            double side1 = double.Parse(Side1TextBox.Text);
            double side2 = double.Parse(Side2TextBox.Text);
            double angle = double.Parse(AngleTextBox.Text);

            // Вычисляем площадь треугольника через синус угла и две прилежащие стороны
            double area = (side1 * side2 * Math.Sin(angle * Math.PI / 180)) / 2;

            // Выводим результат
            ResultLabel.Content = $"Площадь треугольника: {area}";
        }
    }
}