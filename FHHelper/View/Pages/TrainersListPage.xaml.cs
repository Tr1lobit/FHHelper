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
    /// Логика взаимодействия для TrainersListPage.xaml
    /// </summary>
    public partial class TrainersListPage : Page
    {
        public TrainersListPage()
        {
            InitializeComponent();
            TrainersLv.ItemsSource = App.GetContetxt().Users.Where(u => u.Roles.Id == 2).ToList();
            CharacterCmb.ItemsSource = App.GetContetxt().Characters.ToList();
        }

        private void CharacterCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TrainersLv.ItemsSource = App.GetContetxt().Users.Where(u => CharacterCmb.SelectedIndex + 1 == u.Characters.Id && u.Roles.Id == 2).ToList();
        }

        private void TrainerTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TrainerTb.Text != "Введите ник")
            {
                TrainersLv.ItemsSource = App.GetContetxt().Users.Where(u => u.NickName.Contains(TrainerTb.Text) && u.Roles.Id == 2).ToList();
            }
        }

        private void TrainerTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TrainerTb.Text == "Введите ник")
            {
                TrainerTb.Text = string.Empty;
            }
        }

        private void TrainerTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TrainerTb.Text == string.Empty)
            {
                TrainerTb.Text = "Введите ник";
            }
        }

        private void TrainersLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new RequestPage(TrainersLv.SelectedItem as Users));
        }
    }
}
