using System;
using System.Windows;

namespace QuadraticSolver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (!double.TryParse(TextBoxX.Text, out double x))
            {
                ResultTextBlock.Text = "Помилка: некоректне значення для x.";
                return;
            }

            if (!double.TryParse(TextBoxY.Text, out double y))
            {
                ResultTextBlock.Text = "Помилка: некоректне значення для y.";
                return;
            }

            if (!double.TryParse(TextBoxZ.Text, out double z))
            {
                ResultTextBlock.Text = "Помилка: некоректне значення для z.";
                return;
            }

            
            double s = (x * x) + (y * y) + (z * z);

           
            ResultTextBlock.Text = $"Результат: s = {s:F3}";
        }
    }
}
