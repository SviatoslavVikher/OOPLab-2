using System;
using System.Globalization;
using System.Windows;
using System.Windows.Input;

namespace Lab2_Form
{
    public partial class MainWindow : Window
    {
        double xValue, yValue, zValue;

        public MainWindow()
        {
            InitializeComponent();
            // Встановлюємо культуру для правильного відображення чисел
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            // Пояснення для користувача
            xBox.Text = "Для запису дробового числа користуйтесь '.'";
        }

        // Обробка події для перевірки вводу в поля
        private void Box_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Перевірка, чи введено лише цифри, точку або мінус
            if (!char.IsDigit(e.Text, 0) && e.Text != "." && e.Text != "-")
            {
                e.Handled = true;
                MessageBox.Show("Вводьте лише числові значення та використовуйте '.' для дробових чисел.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Обробка натискання кнопки
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool error = false;

            // Перевірка на коректність введених значень
            if (!double.TryParse(xBox.Text, out xValue)) error = true;
            if (!double.TryParse(yBox.Text, out yValue)) error = true;
            if (!double.TryParse(zBox.Text, out zValue)) error = true;

            // Якщо хоча б одне значення некоректне, вивести помилку
            if (error)
            {
                MessageBox.Show("Некоректні дані, повторіть ввід.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Виконати обчислення
            double result = Math.Sin(Math.Pow(yValue, -Math.Sqrt(Math.Abs(xValue)))) * (zValue - (xValue / yValue)) + Math.Sin(Math.Cos(zValue));

            // Вивести результат в поле
            resultBox.Text = result.ToString("F4");
        }
    }
}
