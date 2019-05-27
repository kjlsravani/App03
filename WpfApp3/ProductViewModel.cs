using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApp3
{
    class ProductViewModel
    {
        public ObservableCollection<NewProduct> Products { get; set; }
        public string StoreImage { get; set; }
        public List<string> ProductStores { get; set; }
        public ProductViewModel()
        {
            Products = ProductStore.ProductList;
            ProductStores = new List<string>() { "Delhi", "Noida" };
            StoreImage = "Image.jpg";
        }
    }
}
