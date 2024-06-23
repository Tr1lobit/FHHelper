using FHHelper.View.Pages;
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

namespace FHHelper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrm.Navigate(new StattSelectPage());
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            if (App.enteredUser == null)
            {
                MainFrm.Navigate(new LogInPage());
            }
            else
            {
                MainFrm.Navigate(new ProfilePage());
            }


        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainFrm.GoBack();
            }
            catch 
            {
                this.Close();
            }


        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            App.enteredUser = null;
        }
    }
}
