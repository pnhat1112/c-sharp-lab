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

namespace MyWDPApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnToPage01_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Page1();
        }

        private void btnToPage02_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Page2();
        }


        private void DemoCanvas_Click(object sender, RoutedEventArgs e)
        {
            Canvas canvas = new Canvas();
            canvas.Show();

            ManageCategoriesApp manageCategoriesApp = new ManageCategoriesApp();
            manageCategoriesApp.Show();
            this.Close();
        }
    }
}
