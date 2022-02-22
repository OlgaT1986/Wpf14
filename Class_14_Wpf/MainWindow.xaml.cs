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

namespace Class_14_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            products = new List<Product>();

            products.Add(new Product()
            {
                ProductName = "Fish",
                Price = 800,
                ImageName = "Data/Fish.jpg",
                ProductType = ProductTypes.Food
            });

            products.Add(new Product()
            {
                ProductName = "Cheese",
                Price = 600,
                ImageName = "Data/Cheese.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Notebook Apple",
                Price = 200000,
                ImageName = "Data/Apple.jpg",
                ProductType = ProductTypes.Technic
            });
              lstBox.ItemsSource = products;
        }
    }
}