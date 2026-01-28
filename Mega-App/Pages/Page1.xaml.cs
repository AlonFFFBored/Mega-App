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
using Client_support;
using Model;

namespace Mega_App.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async Task DoFunc()
        {
            ApiService api = new ApiService();
            int? data = await api.AddMember(
                new Membership()
                {
                    Id = ,
                }
            );
            string s = "";
            s = data.ToString();
            Output.Text = s;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoFunc();
        }
    }
}
