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
    /// Логика взаимодействия для AnotherMechanicks.xaml
    /// </summary>
    public partial class AnotherMechanicks : Page
    {
        public AnotherMechanicks()
        {
            InitializeComponent();
            MechanicsLv.ItemsSource = App.GetContetxt().OtherMechanics.ToList();
        }

        private void MechanicsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MechanicTextTb.DataContext = App.GetContetxt().OtherMechanics.Where(o=>MechanicsLv.SelectedIndex+1 == o.Id).ToList();
        }
    }
}
