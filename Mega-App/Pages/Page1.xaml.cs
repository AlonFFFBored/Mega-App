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
using MegaApp.Controls;

namespace MegaApp.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            Loaded += Banner_Loaded;
        }

        private void Banner_Loaded(object sender, RoutedEventArgs e)
        {
            LoadView(new HeroBanner());
        }

        private void LoadView(UserControl uc)
        {
            MainContent.Content = uc;
        }
    }
}
