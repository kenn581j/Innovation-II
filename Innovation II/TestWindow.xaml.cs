using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Innovation_II
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        private MainWindow MainWindow { get; set; }
        public TestWindow()
        {
            InitializeComponent();
        }
        public TestWindow(MainWindow mainCall)
        {
            MainWindow = mainCall;
            InitializeComponent();
        }

        private void Btn_MathiasCheckIn_Click(object sender, RoutedEventArgs e)
        {

            MainWindow.lb_one.Content = "Godmorgen Matihas";
            MainWindow.lb_two.Content = "uni ID";
            MainWindow.lb_three.Content = "Mødt kl. 08:11";
            MainWindow.lb_four.Content = "Fri kl. 14:00";            

            var image = new Image();
            var fullFilePath = @"http://www.americanlayout.com/wp/wp-content/uploads/2012/08/C-To-Go-300x300.png";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            image.Source = bitmap;

            MainWindow.wrapPanel_ProfilePic.Children.Add(image);
           

        }

        private void Btn_KatrineCheckIn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.lb_one.Content = "Godmorgen Katrine";
            MainWindow.lb_two.Content = "uni ID";
            MainWindow.lb_three.Content = "Mødt kl. 07:58";
            MainWindow.lb_four.Content = "Fri kl. 14:00";

            var image = new Image();
            var fullFilePath = @"http://www.americanlayout.com/wp/wp-content/uploads/2012/08/C-To-Go-300x300.png";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            image.Source = bitmap;

            MainWindow.wrapPanel_ProfilePic.Children.Add(image);
        }

        private void Btn_MathiasCheckOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.lb_one.Content = "Tak for i dag Mathias";
            MainWindow.lb_two.Content = "uni ID";
            MainWindow.lb_three.Content = "Gået kl. 11:36";
            MainWindow.lb_four.Content = "2 timers fravær for i dag";

            var image = new Image();
            var fullFilePath = @"http://www.americanlayout.com/wp/wp-content/uploads/2012/08/C-To-Go-300x300.png";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            image.Source = bitmap;

            MainWindow.wrapPanel_ProfilePic.Children.Add(image);
        }

        private void Btn_KatrineCheckOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.lb_one.Content = "Tak for i dag Katrine";
            MainWindow.lb_two.Content = "uni ID";
            MainWindow.lb_three.Content = "Gået kl. 14:07";
            MainWindow.lb_four.Content = "Ingen fravær for i dag";

            var image = new Image();
            var fullFilePath = @"http://www.americanlayout.com/wp/wp-content/uploads/2012/08/C-To-Go-300x300.png";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            image.Source = bitmap;

            MainWindow.wrapPanel_ProfilePic.Children.Add(image);
        }

    }
}
