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
    /// Логика взаимодействия для StattSelectPage.xaml
    /// </summary>
    public partial class StattSelectPage : Page
    {
        public StattSelectPage()
        {
            InitializeComponent();
        }

        private void LibraryBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainGuidePage());
        }

        private void TrainingBtn_Click(object sender, RoutedEventArgs e)
        {
            if(App.enteredUser==null)
            {
                NavigationService.Navigate(new LogInPage());
            }
            else
            {
                NavigationService.Navigate(new TrainersListPage());
            }
            
        }
    }
}
