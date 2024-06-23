using FHHelper.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FHHelper
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static FHHelperDBEntities _context;

        public static FHHelperDBEntities GetContetxt()
        {
            if (_context == null)
            {
                _context = new FHHelperDBEntities();
            }
            return _context;
        }

        public static Users enteredUser;
    }
}
