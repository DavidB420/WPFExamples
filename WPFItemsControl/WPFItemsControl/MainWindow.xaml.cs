using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFItemsControl
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public int _value = 0;

        public string[] NamesList;


        public string[] Names
        {

            get
            {
                return NamesList;
            }

            set
            {
                NamesList = value;
                OnPropertyChanged("Names");
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        }

        public void Add(string value)
        {
            string[] Names2 = new string[Names.Length+1];

            for (int i = 0; i < Names.Length; i++)
            {
                Names2[i] = Names[i];
            }

            Names2[Names.Length] = value;

            Names = Names2;
        }


        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            Names = new string[]{"Steve","Mike","Maya","David","Clara"};
            //testCollection = new ObservableCollection<Button> { new Button(), new Button(), new Button() };

        }

        public ObservableCollection<Button> testCollection { get; set; }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _value++;

            Add("New Name #" + _value);
        }
    }

}
