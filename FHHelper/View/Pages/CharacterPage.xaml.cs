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
    /// Логика взаимодействия для CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page
    {
        public CharacterPage()
        {
            InitializeComponent();
        }

        private void MovelistBtn_Click(object sender, RoutedEventArgs e)
        {
            FightTbl.TextDecorations = TextDecorations.Underline;
            HistoryBtnTbl.TextDecorations = null;
            HistoryTbl.Opacity = 0;
            MovelistTbl.Opacity = 100;
        }

        private void CharacterHistoryBtn_Click(object sender, RoutedEventArgs e)
        {
            HistoryBtnTbl.TextDecorations = TextDecorations.Underline;
            FightTbl.TextDecorations = null;
            MovelistTbl.Opacity = 0;
            HistoryTbl.Opacity = 100;
        }
    }
}
