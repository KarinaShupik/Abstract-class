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

namespace Abstract_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Створити абстрактний базовий клас Pair з віртуальними арифметичними
        операціями. Створити похідні класи Fazzynumber (нечіткі числа) і Complex
        (комплексні числа). Реалізувати базові операції над цими числами.
         */
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnFzNumAddClick(object sender, RoutedEventArgs e)
        {
            //конвертація рядка у число
            double num1;
            double.TryParse(fzNum1Box.Text, out num1);
            double tolerance1;
            double.TryParse(fzNum2Box.Text, out tolerance1); 

            double num2;
            double.TryParse(fzNum1Box.Text, out num2);
            double tolerance2;
            double.TryParse(fzNum2Box.Text, out tolerance2);

            var fz1 = new FuzzyNumber(num1, tolerance1);
            var fz2 = new FuzzyNumber(num2, tolerance2);

            var result = fz1.Add(fz2);

            fzNumResultLabel.Content = result.ToString();
        }

        private void OnFzNumSubtractClick(object sender, RoutedEventArgs e)
        {
            double num1;
            double.TryParse(fzNum1Box.Text, out num1);
            double tolerance1;
            double.TryParse(fzNum2Box.Text, out tolerance1);

            double num2;
            double.TryParse(fzNum1Box.Text, out num2);
            double tolerance2;
            double.TryParse(fzNum2Box.Text, out tolerance2);

            var fz1 = new FuzzyNumber(num1, tolerance1);
            var fz2 = new FuzzyNumber(num2, tolerance2);

            var result = fz1.Subtract(fz2);

            fzNumResultLabel.Content = result.ToString();
        }

        private void OnFzNumMultiplyClick(object sender, RoutedEventArgs e)
        {
            double num1;
            double.TryParse(fzNum1Box.Text, out num1);
            double tolerance1;
            double.TryParse(fzNum2Box.Text, out tolerance1);

            double num2;
            double.TryParse(fzNum1Box.Text, out num2);
            double tolerance2;
            double.TryParse(fzNum2Box.Text, out tolerance2);

            var fz1 = new FuzzyNumber(num1, tolerance1);
            var fz2 = new FuzzyNumber(num2, tolerance2);

            var result = fz1.Multiply(fz2);

            fzNumResultLabel.Content = result.ToString();
        }

        private void OnFzNumDivideClick(object sender, RoutedEventArgs e)
        {
            double num1;
            double.TryParse(fzNum1Box.Text, out num1);
            double tolerance1;
            double.TryParse(fzNum2Box.Text, out tolerance1);

            double num2;
            double.TryParse(fzNum1Box.Text, out num2);
            double tolerance2;
            double.TryParse(fzNum2Box.Text, out tolerance2);

            var fz1 = new FuzzyNumber(num1, tolerance1);
            var fz2 = new FuzzyNumber(num2, tolerance2);

            var result = fz1.Divide(fz2);

            fzNumResultLabel.Content = result.ToString();
        }

        private void OnComplexNumAddClick(object sender, RoutedEventArgs e)
        {
            double real1;
            double.TryParse(complexNum1RealBox.Text, out real1);
            double imaginary1;
            double.TryParse(complexNum1ImaginaryBox.Text, out imaginary1);

            double real2;
            double.TryParse(complexNum2RealBox.Text, out real2);
            double imaginary2;
            double.TryParse(complexNum2ImaginaryBox.Text, out imaginary2);

            var complex1 = new Complex(real1, imaginary1);
            var complex2 = new Complex(real2, imaginary2);

            var result = complex1.Add(complex2);

            complexNumResultLabel.Content = result.ToString();
        }

        private void OnComplexNumSubtractClick(object sender, RoutedEventArgs e)
        {
            double real1;
            double.TryParse(complexNum1RealBox.Text, out real1);
            double imaginary1;
            double.TryParse(complexNum1ImaginaryBox.Text, out imaginary1);

            double real2;
            double.TryParse(complexNum2RealBox.Text, out real2);
            double imaginary2;
            double.TryParse(complexNum2ImaginaryBox.Text, out imaginary2);

            var complex1 = new Complex(real1, imaginary1);
            var complex2 = new Complex(real2, imaginary2);

            var result = complex1.Subtract(complex2);

            complexNumResultLabel.Content = result.ToString();
        }

        private void OnComplexNumMultiplyClick(object sender, RoutedEventArgs e)
        {
            double real1;
            double.TryParse(complexNum1RealBox.Text, out real1);
            double imaginary1;
            double.TryParse(complexNum1ImaginaryBox.Text, out imaginary1);
            double real2;
            double.TryParse(complexNum2RealBox.Text, out real2);
            double imaginary2;
            double.TryParse(complexNum2ImaginaryBox.Text, out imaginary2);

            var complex1 = new Complex(real1, imaginary1);
            var complex2 = new Complex(real2, imaginary2);

            var result = complex1.Multiply(complex2);

            complexNumResultLabel.Content = result.ToString();
        }

        private void OnComplexNumDivideClick(object sender, RoutedEventArgs e)
        {
            double real1;
            double.TryParse(complexNum1RealBox.Text, out real1);
            double imaginary1;
            double.TryParse(complexNum1ImaginaryBox.Text, out imaginary1);

            double real2;
            double.TryParse(complexNum2RealBox.Text, out real2);
            double imaginary2;
            double.TryParse(complexNum2ImaginaryBox.Text, out imaginary2);

            var complex1 = new Complex(real1, imaginary1);
            var complex2 = new Complex(real2, imaginary2);

            var result = complex1.Divide(complex2);

            complexNumResultLabel.Content = result.ToString();
        }
    }
}
