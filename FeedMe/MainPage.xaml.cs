using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Microsoft.Phone.Controls;

namespace FeedMe
{
    public partial class MainPage : PhoneApplicationPage
    {
        //String data;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //var dataSource = new Data();
            
            //try
            //{
            //    Task<string> readData = dataSource.ReadData("data.txt");
            //    this.data = readData.Result;
            //}
            //catch (Exception)
            //{
            //    Debug.WriteLine("Something went wrong");
            //}

            var pets = new List<Pet>
            {
                new Pet("Jim", "Dog", new DateTime(2012, 5, 7), 1450, new DateTime(2012, 5, 7, 12, 25, 00),
                    new DateTime(2012, 5, 7, 13, 20, 00),0),
                new Pet("Benny", "Cat", new DateTime(2012, 5, 7), 1450, new DateTime(2012, 5, 7, 12, 25, 00),
                    new DateTime(2012, 5, 7, 13, 20, 00),1),
                new Pet("Flower", "Plant", new DateTime(2012, 5, 7), 1450, new DateTime(2012, 5, 7, 12, 25, 00),
                    new DateTime(2012, 5, 7, 13, 20, 00),2)
            };
            LongList.ItemsSource = pets;
            System.Diagnostics.Debug.WriteLine(pets.Find(x => x.Name.Contains("Jim")));
            

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void HyperlinkButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddPet.xaml", UriKind.Relative));

        }

        private void LongList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(LongList.SelectedItem.ToString());
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
