using System.Collections.Generic;
using Xamarin.Forms;

namespace FormsExample.Core
{
    // Page 164
    public class ListViewCustom : ContentPage
    {
        public ListViewCustom()
        {
            ListView listView = new ListView();
            listView.ItemsSource = new ListItem2[]
                {
                    new ListItem2 { Title="First", Description="1st item", Price = "$100.00" },
                    new ListItem2 { Title="Second", Description="2nd item", Price = "$200.00" },
                    new ListItem2 { Title="Third", Description="3rd item", Price = "$300.00" }
                };
            listView.RowHeight = 80;
            listView.BackgroundColor = Color.Black;
            listView.ItemTemplate = new DataTemplate( typeof( ListItemCell ) );
            Content = listView;

            // Page 159 (reused)
            listView.ItemTapped += async ( sender, e ) =>
            {
                ListItem item = (ListItem)e.Item;
                await DisplayAlert( "Tapped", item.Title.ToString() + " was tapped.", "OK" );
                ( (ListView)sender ).SelectedItem = null;
            };

            listView.ItemSelected += async ( sender, e ) =>
            {
                if ( e.SelectedItem == null ) return;
                ListItem item = (ListItem)e.SelectedItem;
                await DisplayAlert( "Selected", item.Title.ToString() + " was selected.", "OK" );
                ( (ListView)sender ).SelectedItem = null;
            };
        }
    }
}
