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
    /// Логика взаимодействия для FractionsPage.xaml
    /// </summary>
    public partial class FractionsPage : Page
    {
        public FractionsPage()
        {
            InitializeComponent();
        }

        private void KnightsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VikingBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SamuraiBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WuLinBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OutlandersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FractionsCharacterPage());
        }
    }
}
