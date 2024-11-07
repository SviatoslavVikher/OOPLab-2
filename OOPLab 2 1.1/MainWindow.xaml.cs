using System;
using System.Windows;

namespace QuadraticSolver
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

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
                // Отримуємо значення для x, y, z
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

                // Обчислюємо результат для рівняння x^2 + y^2 + z^2
                double result = x * x + y * y + z * z;

                // Виводимо результат
                ResultTextBlock.Text = $"Результат: x^2 + y^2 + z^2 = {result:F3}";
            }
        }
    }
