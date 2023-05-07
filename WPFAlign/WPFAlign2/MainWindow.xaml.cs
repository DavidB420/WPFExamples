using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPFAlign2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            //this.SizeChanged += new SizeChangedEventHandler(WindowSizeChanged);
            

            browserWidget.Navigate("http://google.com");

            browserWidget.LoadCompleted += new LoadCompletedEventHandler(WebBrowserPageChanged);

            addressBar.KeyDown += new KeyEventHandler(AddressBarEnterPressed);
        }

        /*private void WindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            addressBar.Width = this.Width;
        }*/

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            browserWidget.GoBack();
        }

        private void forwardButton_Click(object sender, RoutedEventArgs e)
        {
            browserWidget.GoForward();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuItem2_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Web Browser v1.0");
        }

        private void WebBrowserPageChanged(object sender, NavigationEventArgs e)
        {
            addressBar.Text = browserWidget.Source.ToString();
        }

        private void AddressBarEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                browserWidget.Navigate(addressBar.Text);
        }
    }
}
