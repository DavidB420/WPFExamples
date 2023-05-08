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

namespace WPFBindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public int _x = 0;

        public string _value { get; set; }


        public string TestString
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
                OnPropertyChanged("TestString");
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;

            this.DataContext = this;

            TestString = "Hello";

        }

        public void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            TestString = "Hello again";
        }
    }
}
