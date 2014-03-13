using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

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
            var message = string.Format("Hello {0}",HelloMessage.Text);
            Clipboard.SetText(message);
        }
    }
}