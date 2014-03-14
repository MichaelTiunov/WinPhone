using System;
using System.Windows;
using System.Windows.Media;
using Microsoft.Phone.Controls;

namespace HelloWorld
{
    public partial class MainPage : PhoneApplicationPage
    {
        private SolidColorBrush globeBrush;

        private Color[] colors = { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Purple };

        private int colorIndex = 0;

        public MainPage()
        {
            InitializeComponent();
            globeBrush = (SolidColorBrush)ContentPanel.Resources["GlobeBrush"];
        }

        private void Canvas_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            colorIndex++;
            if (colorIndex >= colors.Length)
            {
                colorIndex = 0;
            }
            globeBrush.Color = colors[colorIndex];
        }

        private void Canvas_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            globeBrush.Color = (Color)Application.Current.Resources["PhoneAccentColor"];
        }

        private void NameInput_OnActionIconTapped(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/GreetingPage.xaml",UriKind.Relative));
        }
    }
}