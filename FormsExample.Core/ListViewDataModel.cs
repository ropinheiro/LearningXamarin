using System.Collections.Generic;
using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 157 to 162
    public class ListViewDataModel : ContentPage
    {
        public ListViewDataModel()
        {
            // Page 157
            ListView listView = new ListView();
            listView.ItemsSource = new ListItem[]
                {
                    new ListItem { Title="First", Description="1st item" },
                    new ListItem { Title="Second", Description="2nd item" },
                    new ListItem { Title="Third", Description="3rd item" }
                };

            // Page 160
            ListView listView2 = new ListView();
            listView2.ItemsSource = new ListItem[]
            {
                    new ListItem { Source="first.png", Title="First", Description="1st item" },
                    new ListItem { Source="second.png", Title="Second", Description="2nd item" },
                    new ListItem { Source="third.png", Title="Third", Description="3rd item" }
            };

            // Page 158
            listView.ItemTemplate = new DataTemplate( typeof( TextCell ) );
            listView.ItemTemplate.SetBinding( TextCell.TextProperty, "Title" );
            listView.ItemTemplate.SetBinding( TextCell.DetailProperty, "Description" );
            listView.ItemTemplate.SetValue( TextCell.TextProperty, Color.Red );
            listView.ItemTemplate.SetValue( TextCell.DetailColorProperty, Color.Blue );

            // Page 161
            listView2.ItemTemplate = new DataTemplate( typeof( ImageCell ) );
            listView2.ItemTemplate.SetBinding( ImageCell.ImageSourceProperty, "Source" );
            // Note: in the 2 lines below, book says to use ImageCell, but VS
            //       suggests simplification to TextCell (and I followed it).
            listView2.ItemTemplate.SetBinding( TextCell.TextProperty, "Title" );
            listView2.ItemTemplate.SetBinding( TextCell.DetailProperty, "Description" );
            listView2.ItemTemplate.SetValue( TextCell.TextProperty, Color.Red );
            listView2.ItemTemplate.SetValue( TextCell.DetailColorProperty, Color.Blue );

            // Page 159
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

            this.Padding = new Thickness( 0, Device.OnPlatform( 20, 0, 0 ), 0, 0 );
            this.Content = listView;
        }
    }

    // Page 157
    public class ListItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        // Page 160
        public string Source { get; set; }
    }
}
