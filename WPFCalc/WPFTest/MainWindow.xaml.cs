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

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        double answer = 0;
        int prevOper = -1;

        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void ButtonNum_Click(object sender, RoutedEventArgs e)
        {
            if (equBox.Text.Equals("0"))
                equBox.Text = "";

            Button btn = (Button)sender;
            equBox.Text = equBox.Text + btn.Content.ToString();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            equBox.Text = "0";
            answer = 0;
        }
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            answer = answer + double.Parse(equBox.Text);
            equBox.Text = "0";
            prevOper = 0;
        }
        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlus_Click(sender, e);
            prevOper = 1;
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlus_Click(sender, e);
            prevOper = 2;
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlus_Click(sender, e);
            prevOper = 3;
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
           switch (prevOper)
           {
                case 0:
                    answer = answer + double.Parse(equBox.Text);
                    break;
                case 1:
                    answer = answer - double.Parse(equBox.Text);
                    break;
                case 2:
                    answer = answer * double.Parse(equBox.Text);
                    break;
                case 3:
                    answer = answer / double.Parse(equBox.Text);
                    break;
            }

            equBox.Text = answer.ToString();
        }
    }
}
