using System.Windows;

namespace MegaApp
{
    /// <summary>
    /// Interaction logic for NotImplementedWindow.xaml
    /// </summary>
    public partial class NotImplementedWindow : Window
    {
        public NotImplementedWindow()
        {
            InitializeComponent();
        }

        // Logic to close the popup
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}