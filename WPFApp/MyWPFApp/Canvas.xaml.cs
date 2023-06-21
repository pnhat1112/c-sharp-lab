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
using System.Windows.Shapes;

namespace MyWDPApp
{
    /// <summary>
    /// Interaction logic for Canvas.xaml
    /// </summary>
    public partial class Canvas : Window
    {
        public Canvas()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            string CarInfo = $"Car Name: {txtCarName.Text} \n" + $"Color: {txtColor.Text}\n Brand: {txtBrand.Text}";
            MessageBox.Show(CarInfo, "Car details");
            WrapPanel wrapPanel = new WrapPanel();
            wrapPanel.Show();
        }
    }
}
