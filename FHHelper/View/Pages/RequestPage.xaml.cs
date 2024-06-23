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
    /// Логика взаимодействия для RequestPage.xaml
    /// </summary>
    public partial class RequestPage : Page
    {
        Users trainer;
        public RequestPage()
        {
            InitializeComponent();
        }

        public RequestPage(Users selectedTrainer)
        {
            InitializeComponent();
            DataContext = selectedTrainer;
            trainer = selectedTrainer;
        }

        private void RequestBtn_Click(object sender, RoutedEventArgs e)
        {
            Requests requests = new Requests()
            {
                User_id = App.enteredUser.Id,
                Coach_id = trainer.Id,
                RequestText = RequestTb.Text,
                IsOpen = true,
                IsAccepted = false
            };
            App.GetContetxt().Requests.Add(requests);
            App.GetContetxt().SaveChanges();
            MessageBox.Show("Заявка отпрвлена!");
            NavigationService.Navigate(new StattSelectPage());
        }
    }
}
