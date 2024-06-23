using FHHelper.Model;
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

namespace FHHelper.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            Users user = App.GetContetxt().Users.FirstOrDefault(u=>NickTb.Text==u.NickName && PasswordPb.Password==u.Password);
            if (user != null)
            {
                NavigationService.Navigate(new StattSelectPage());
                App.enteredUser = user;
                MessageBox.Show("Вы вошли в систему!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Данные введены неверно, попробуйте еще раз!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Warning);
                NickTb.Text = string.Empty;
                PasswordPb.Password = string.Empty;
            }
        }

        private void NickTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if(NickTb.Text=="Введите ник")
            {
                NickTb.Text = string.Empty;
                NickTb.Foreground = new SolidColorBrush(Colors.Black);
            }    
            
        }

        private void NickTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if(NickTb.Text == string.Empty)
            {
                NickTb.Text = "Введите ник";
                NickTb.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void PasswordPb_GotFocus(object sender, RoutedEventArgs e)
        {
            if(PasswordText.Text=="Введите пароль")
            PasswordText.Text = string.Empty;
        }

        private void PasswordPb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == string.Empty)
            {
                PasswordText.Text = "Введите пароль";
            }
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
