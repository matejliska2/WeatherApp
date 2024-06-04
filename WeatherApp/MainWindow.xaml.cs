using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Windows.Threading;

namespace WeatherApp
{

    
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        // API key
        private readonly string apiKey = "465b213001cd4373a3c170538240406";
        private string cityName;

        // Making a real time clock
        private DateTime _now;
        public DateTime Now
        {
            get { return _now; }
            set
            {
                _now = value;
                OnPropertyChanged(nameof(Now));
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += (sender, args) =>
            {
                Now = DateTime.Now;
            };
            timer.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
        // Search box funtcion
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
        // Power off button
        private void PowerOffBtn_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
        // Button for searching citties
        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}