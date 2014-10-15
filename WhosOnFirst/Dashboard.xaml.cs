using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WhosOnFirst
{
    public partial class Dashboard : PhoneApplicationPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Add_Person_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml?goto=0", UriKind.Relative));
        }


        private void MyProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml?goto=2", UriKind.Relative));
        }



        private void Teams_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml?goto=1", UriKind.Relative));
            
        }
    }
}