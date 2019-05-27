using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Observable.xaml
    /// </summary>
    public partial class Observable : Window
    {
        ObservableCollection<Product> products { get; set; }
        //List<Product> products { get; set; }

        public Observable()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>()
            //products = new List<Product>()
            {
                new Product(){title="C#"},
                new Product(){title="ASP"},
                new Product(){title="MVC"}
            };
            lstProducts.ItemsSource = products;
            lstProducts.DisplayMemberPath = "title";

            //~~~~~~~~~~~~~~~~~~~~~~~~~New Product Code~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            newProduct = new NewProduct();
            newProduct.Price = 20000;
            newProduct.Title = "C#";
            Grid1.DataContext = newProduct;//Binding the data 
        }

        NewProduct newProduct;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product(){ title="C++"};
            products.Add(p);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            newProduct.Price = 500000;
            newProduct.Title = "ASP.NET";
        }
    }
}
