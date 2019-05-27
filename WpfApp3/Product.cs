using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Product
    {
        string _title;
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
    }

    public class NewProduct : INotifyPropertyChanged
    {
        string title;
        int price;

        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                  PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            
        }
        
    }
    public class ProductStore
    {
        public static ObservableCollection<NewProduct> ProductList { get; set; }
        static ProductStore()
        {
            ProductList = new ObservableCollection<NewProduct>()
            {
                new NewProduct(){Price=100,Title="MVC"},
                new NewProduct(){Price=200,Title="C#"},
                new NewProduct(){Price=300,Title="ASP"}
            };
        }
    }
}
