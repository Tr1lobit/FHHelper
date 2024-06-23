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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        int Role = 1;
        public RegistrationPage()
        {
            InitializeComponent();
            
        }

        private void NickTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NickTb.Text == "Введите ник")
            {
                NickTb.Text = string.Empty;
                NickTb.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void NickTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NickTb.Text == string.Empty)
            {
                NickTb.Text = "Введите ник";
                NickTb.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void NickUbisoft_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NickUbisoft.Text == "Ник UbisoftConnect")
            {
                NickUbisoft.Text = string.Empty;
                NickUbisoft.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void NickUbisoft_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NickUbisoft.Text == string.Empty)
            {
                NickUbisoft.Text = "Ник UbisoftConnect";
                NickUbisoft.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void NewPasswordPb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NewPasswordPb.Password == string.Empty)
            {
                NewPasswordText.Text = string.Empty;
                NewPasswordPb.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void NewPasswordPb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NewPasswordPb.Password == string.Empty)
            {
                NewPasswordText.Text = "Введите пароль";
                NewPasswordPb.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void RepeatPasswordPb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RepeatPasswordPb.Password == string.Empty)
            {
                RepeatPasswordText.Text = string.Empty;
                RepeatPasswordPb.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void RepeatPasswordPb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (RepeatPasswordPb.Password == string.Empty)
            {
                RepeatPasswordText.Text = "Повторите пароль";
                RepeatPasswordPb.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users()
            {
                NickName = NickTb.Text,
                UplayNick = NickUbisoft.Text,
                Password = RepeatPasswordPb.Password,
                Role_id = Role
            };
            App.GetContetxt().Users.Add(users);
            App.GetContetxt().SaveChanges();
            NavigationService.GoBack();
            MessageBox.Show("Вы успешно зарегистрировались");
        }

        private void TrainerBtn_Click(object sender, RoutedEventArgs e)
        {
            TrainerTbl.TextDecorations = TextDecorations.Underline;
            UserTbl.TextDecorations = null;
            Role = 2;
        }

        private void UserBtn_Click(object sender, RoutedEventArgs e)
        {
            UserTbl.TextDecorations = TextDecorations.Underline;
            TrainerTbl.TextDecorations = null;
            Role = 1;
        }
    }
}
