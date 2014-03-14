using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace HelloWorld
{
    public partial class GreetingPage : PhoneApplicationPage
    {
        public GreetingPage()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_OnClick(object sender, EventArgs e)
        {
            NavigationService.GoBack();
            var message = string.Format("Hello {0}",HelloMessage.Text);
            Clipboard.SetText(message);
        }
    }
}