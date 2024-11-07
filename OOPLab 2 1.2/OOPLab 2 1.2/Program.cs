using System;
using System.Windows;
using System.Windows.Controls;

namespace QuadraticEquationSolver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            // Clear previous results
            resultTextBlock.Text = string.Empty;

            // Get the input values
            if (!double.TryParse(aTextBox.Text, out double a))
            {
                resultTextBlock.Text = "Помилка: некоректне значення для a.";
                return;
            }

            if (!double.TryParse(bTextBox.Text, out double b))
            {
                resultTextBlock.Text = "Помилка: некоректне значення для b.";
                return;
            }

            if (!double.TryParse(cTextBox.Text, out double c))
            {
                resultTextBlock.Text = "Помилка: некоректне значення для c.";
                return;
            }

            // Calculate the discriminant
            double discriminant = b * b - 4 * a * c;
            resultTextBlock.Text += $"Дискримінант: {discriminant:F3}\n";

            // Check the discriminant and calculate roots
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                resultTextBlock.Text += $"Корені рівняння: x1 = {x1:F3}, x2 = {x2:F3}";
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                resultTextBlock.Text += $"Єдиний корінь рівняння: x = {x:F3}";
            }
            else
            {
                resultTextBlock.Text += "Коренів немає (дискримінант від'ємний).";
            }
        }
    }
}
