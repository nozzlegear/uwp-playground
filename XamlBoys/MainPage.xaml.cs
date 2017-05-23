using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XamlBoys.Pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XamlBoys
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            MainFrame.Navigate(typeof(HomePage));

            SystemNavigationManager.GetForCurrentView().BackRequested += CurrentView_BackRequested;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            Menu.IsPaneOpen = !Menu.IsPaneOpen;
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(HomePage));
        }

        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(DetailsPage));
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(SettingsPage));
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Type target = null;
            object parameters = null;

            switch(button.Name)
            {
                case "HomeButton":
                    target = typeof(HomePage);
                    parameters = "Do it!";
                    break;

                case "DetailsButton":
                    target = typeof(DetailsPage);
                    parameters = "Have you ever heard the tragedy of Darth Plagueis the Wise?";
                    break;

                case "DataButton":
                    target = typeof(DataBindingPage);
                    break;

                case "UserControlButton":
                    target = typeof(UserControlPage);
                    break;

                case "SettingsButton":
                    target = typeof(SettingsPage);
                    parameters = "Are you threatening me, Master Jedi?";
                    break;
            }

            if (target == null || target == MainFrame.CurrentSourcePageType)
            {
                return;
            }

            MainFrame.Navigate(target, parameters);
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();

            if (MainFrame.CanGoBack)
            {
                currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        private void CurrentView_BackRequested(object sender, BackRequestedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
