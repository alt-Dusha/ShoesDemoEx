using Shoes.Classes;
using Shoes.DataBase;
using System.Linq;
using System.Windows;

namespace Shoes.Views
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        private Message _m = new Message();


        public Autorization()
        {
            InitializeComponent();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            
            string login = UsName_tb.Text.Trim();
            string password = UsPass_tb.Password.Trim();
            try {
                var user = ConnectClass._db.User.Where(u => u.login == login && u.password == password).FirstOrDefault();
                if (user != null)
                {
                    Current.CurrentUser = user;
                    new Product(user).Show();
                    Close();
                }
                else
                {
                    _m.Error("Введён неправильный логин или пароль");
                }
            } catch { _m.Error("Ошибка подключения к БД"); }
        }

        private void GuestButtonClick(object sender, RoutedEventArgs e)
        {
            new Product().Show();
            Close();
        }
    }
}
