using System.Configuration;
using System.Data;
using System.Windows;

namespace MegaApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static void OpenNotImpWin(Window win)
        {
            try
            {
                // Initialize the window
                NotImplementedWindow popup = new NotImplementedWindow();
                // Set the owner to the current window so it stays centered and 
                // behaves like a child of the main application
                popup.Owner = win;
                // ShowDialog blocks interaction with the main window until the popup is closed
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                // If there is a hidden error (like a missing resource), this will tell you.
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

}
