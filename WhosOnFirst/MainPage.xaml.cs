using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace WhosOnFirst
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }

            string strItemIndex;
            if (NavigationContext.QueryString.TryGetValue("goto", out strItemIndex))
            {
                MainPagePivot.SelectedIndex = Convert.ToInt32(strItemIndex);
            }

            //string fName;
            //if (NavigationContext.QueryString.TryGetValue("firstName", out fName))
            //{
                
            //}

            //string lName;
            //if (NavigationContext.QueryString.TryGetValue("lastName", out lName))
            //{

            //}

            IDictionary<string, string> parameters = this.NavigationContext.QueryString;
            if (parameters.ContainsKey("firstName"))
            {
                string firstName = parameters["firstName"];
                FullNameText.Text += firstName;
                FullNameText.Text += " ";

            }
            if (parameters.ContainsKey("lastName"))
            {
                string lastName = parameters["lastName"];
                FullNameText.Text += lastName;

            }
            
        
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/XLG.xaml", UriKind.Relative));
            ResultsStack.Visibility = System.Windows.Visibility.Visible;
        }

        private void Expand_Me_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MisspellingsStack.Visibility = System.Windows.Visibility.Visible;
            Expand_Me.Visibility = System.Windows.Visibility.Collapsed;
            Collapse_Me.Visibility = System.Windows.Visibility.Visible;
        }

        private void Collapse_Me_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MisspellingsStack.Visibility = System.Windows.Visibility.Collapsed;
            Collapse_Me.Visibility = System.Windows.Visibility.Collapsed;
            Expand_Me.Visibility = System.Windows.Visibility.Visible;
        }

        private void Expand_Me2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            SkillsStack.Visibility = System.Windows.Visibility.Visible;
            Expand_Me2.Visibility = System.Windows.Visibility.Collapsed;
            Collapse_Me2.Visibility = System.Windows.Visibility.Visible;
        }

        private void Collapse_Me2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            SkillsStack.Visibility = System.Windows.Visibility.Collapsed;
            Collapse_Me2.Visibility = System.Windows.Visibility.Collapsed;
            Expand_Me2.Visibility = System.Windows.Visibility.Visible;
        }

        private void Expand_Me3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ProjectsStack.Visibility = System.Windows.Visibility.Visible;
            Expand_Me3.Visibility = System.Windows.Visibility.Collapsed;
            Collapse_Me3.Visibility = System.Windows.Visibility.Visible;
        }

        private void Collapse_Me3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ProjectsStack.Visibility = System.Windows.Visibility.Collapsed;
            Collapse_Me3.Visibility = System.Windows.Visibility.Collapsed;
            Expand_Me3.Visibility = System.Windows.Visibility.Visible;
        }

        private void Expand_Me4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            JobsStack.Visibility = System.Windows.Visibility.Visible;
            Expand_Me4.Visibility = System.Windows.Visibility.Collapsed;
            Collapse_Me4.Visibility = System.Windows.Visibility.Visible;

        }

        private void Collapse_Me4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            JobsStack.Visibility = System.Windows.Visibility.Collapsed;
            Collapse_Me4.Visibility = System.Windows.Visibility.Collapsed;
            Expand_Me4.Visibility = System.Windows.Visibility.Visible;
        }

        private void Submit2_Click(object sender, RoutedEventArgs e)
        {

        }




        private void XL_Global_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            XL_Global.Background = new SolidColorBrush(Color.FromArgb(255, 100, 100, 100));

            NavigationService.Navigate(new Uri("/XLG.xaml", UriKind.Relative));
            XL_Global.Background = new SolidColorBrush(Color.FromArgb(0, 100, 100, 100));
        }

        private void SearchFirst_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchFirst.Text = "";
        }

        private void SearchLast_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchLast.Text = "";
        }

        private void Expand_Me5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Expand_Me5.Visibility = System.Windows.Visibility.Collapsed;
            Collapse_Me5.Visibility = System.Windows.Visibility.Visible;
            ResultsStack.Visibility = System.Windows.Visibility.Visible;
        }

        private void Collapse_Me5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Collapse_Me5.Visibility = System.Windows.Visibility.Collapsed;
            Expand_Me5.Visibility = System.Windows.Visibility.Visible;
            ResultsStack.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Expand_Me6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            Expand_Me6.Visibility = System.Windows.Visibility.Collapsed; 
            Collapse_Me6.Visibility = System.Windows.Visibility.Visible;
            SearchStack.Visibility = System.Windows.Visibility.Visible;
        }

        private void Collapse_Me6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Collapse_Me6.Visibility = System.Windows.Visibility.Collapsed;
            Expand_Me6.Visibility = System.Windows.Visibility.Visible;
            SearchStack.Visibility = System.Windows.Visibility.Collapsed;
        }


        private void ViewPerson_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml?goto=1&firstName=Scott&lastName=Friedman", UriKind.Relative));
        }

        private void GroupProjSubmit_Click(object sender, RoutedEventArgs e)
        {

            ListPickerItem selectedItem = (ListPickerItem)GroupByList.SelectedItem;
            string content = (string)selectedItem.Content;

            if (content == "Team Role")
            {
                GroupByTeamRole.Visibility = System.Windows.Visibility.Visible;
                GroupByRegion.Visibility = System.Windows.Visibility.Collapsed;
            }

            if (content == "Region")
            {
                GroupByRegion.Visibility = System.Windows.Visibility.Visible;
                GroupByTeamRole.Visibility = System.Windows.Visibility.Collapsed;
            }
        }







        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}