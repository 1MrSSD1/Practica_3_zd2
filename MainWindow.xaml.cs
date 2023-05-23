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

namespace Pr3_001
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
            int a = int.Parse(number1TextBox.Text);
            int b = int.Parse(number2TextBox.Text);
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            txtOtv1.Text = $"Большее число: {max}";
            txtOtv2.Text = $"Меньшее число: {min}";
        }
    }
}
