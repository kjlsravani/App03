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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Tunneling.xaml
    /// </summary>
    public partial class Tunneling : Window
    {
        public Tunneling()
        {
            InitializeComponent();
        }

        private void Window_PreviewMouseDown(object sender,MouseButtonEventArgs e)
        {
            lst.Items.Add("Original Source: " + e.OriginalSource.GetType().ToString());
            lst.Items.Add("\nSource: " + e.Source.GetType().ToString());
            lst.Items.Add("\nSender: " + sender.GetType().ToString());
            lst.Items.Add("----------------------------------------------------------");

            if (Chk.IsChecked.Value) e.Handled = true;
        }
    }
}
