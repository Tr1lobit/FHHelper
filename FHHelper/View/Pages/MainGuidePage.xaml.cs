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
    /// Логика взаимодействия для MainGuidePage.xaml
    /// </summary>
    public partial class MainGuidePage : Page
    {
        public MainGuidePage()
        {
            InitializeComponent();
        }

        private void MapsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MapsPage());
        }

        private void OtherMechBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AnotherMechanicks());
        }

        private void CharactersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FractionsPage());
        }
    }
}
