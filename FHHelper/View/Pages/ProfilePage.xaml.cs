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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        
        public ProfilePage()
        {
            InitializeComponent();

            RequestLv.ItemsSource = App.GetContetxt().Requests.Where(r => r.Coach_id == App.enteredUser.Id).ToList();

            MainCharacterCmb.ItemsSource = App.GetContetxt().Characters.ToList();

            NickTb.Text = "Ник: " + App.enteredUser.NickName;
            UplayNickTb.Text = "Никнейм в Uplay: " + App.enteredUser.UplayNick;
            if (App.enteredUser.Raiting != null)
            {
                RaitingTb.Text = "Рейтинг: " + Convert.ToString(App.enteredUser.Raiting);
            }
            else
            {
                RaitingTb.Text = "Рейтинг: не определен";
            }

            RoleTb.Text = "Роль: " + Convert.ToString(App.enteredUser.Roles.Role);

            if (App.enteredUser.MainCharacter != null)
            {
                MainCharacterCmb.SelectedIndex = App.enteredUser.Characters.Id - 1;
            }

        }

        private void MainCharacterCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.enteredUser.MainCharacter = MainCharacterCmb.SelectedIndex+1;
            App.GetContetxt().SaveChanges();
        }
    }
}
