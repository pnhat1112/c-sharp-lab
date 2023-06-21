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
    /// Interaction logic for GridPanel.xaml
    /// </summary>
    public partial class GridPanel : Window
    {
        public GridPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DockPanel dockPanel = new DockPanel();
            dockPanel.Show();
            this.Close();
        }
    }
}
