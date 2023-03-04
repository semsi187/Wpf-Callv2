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

namespace Wpf_Callv2
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        int first = 0;
        int second = 0;
        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Results.Text += btn.Content.ToString();
            second = Int32.Parse(Results.ToString());
        }

        private void Dvide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Results.Text);
            op = '/'; 
            Results.Clear();
        }

        private void MultiButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Results.Text);
            op = '*';
            Results.Clear();
        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Results.Text);
            op = '-';
            Results.Clear();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Results.Text);
            op = '+';
            Results.Clear();
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            second= Int32.Parse(Results.Text);
            int results = 0;

            if (op == '+')
            {
                results = first + second;
            }
            else if (op == '-')
            {
                results = second - first;
            }
            else if (op == '*')
            {
                results = second - first;
            }
            else if (op == '/')
            {
                results = second - first;
            }
            if (Results.Text == "0")
            {
                Results.Clear();
            }
            Results.Text = results.ToString();
        }
    }
}
