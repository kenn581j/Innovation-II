using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Innovation_II
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;            
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_time.Content = DateTime.Now.ToLongTimeString();
            lb_date.Content = DateTime.Today.ToLongDateString();
        }

        private void Btn_Test_Click(object sender, RoutedEventArgs e)
        {
            TestWindow window = new TestWindow(this);
            window.Show();
        }

        private static void MathiasCheckIn()
        {

            Thread.Sleep(5000);
        }
    }
}
