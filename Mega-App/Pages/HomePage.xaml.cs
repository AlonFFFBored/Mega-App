using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MegaApp.Pages
{
    public partial class HomePage : Page
    {
        DispatcherTimer timer = new DispatcherTimer();

        public HomePage()
        {
            InitializeComponent();

            // Setup Auto-Slide timer
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += (s, e) => Next_Click(null, null);
            timer.Start();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (ImageSlider.SelectedIndex < ImageSlider.Items.Count - 1)
                ImageSlider.SelectedIndex++;
            else
                ImageSlider.SelectedIndex = 0; // Loop back to start

            ScrollToSelected();
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (ImageSlider.SelectedIndex > 0)
                ImageSlider.SelectedIndex--;
            else
                ImageSlider.SelectedIndex = ImageSlider.Items.Count - 1; // Loop to end

            ScrollToSelected();
        }

        private void ScrollToSelected()
        {
            if (ImageSlider.SelectedItem != null)
            {
                ImageSlider.ScrollIntoView(ImageSlider.SelectedItem);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
    }
}