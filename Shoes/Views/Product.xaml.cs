using System.Linq;
using System.Windows;
using Shoes.Classes;
using Shoes.DataBase;
using Shoes.Views;

namespace Shoes.Views
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        private ShoessEntities _db = new ShoessEntities();

        public Product()
        {
            InitializeComponent();
            LoadProducts();
        }
        public Product(User user)
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductList.ItemsSource = _db.Product.ToList();
        }

        private void LogOutButtonClick(object sender, RoutedEventArgs e)
        {
            Current.CurrentUser = null;
            new Autorization().Show();
            Close();
        }
    }
}
