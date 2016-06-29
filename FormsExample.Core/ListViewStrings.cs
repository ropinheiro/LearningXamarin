using System.Collections.Generic;
using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 154 to 157
    public class ListViewStrings : ContentPage
    {
        public ListViewStrings()
        {
            // Page 154
            ListView listView = new ListView();
            List<string> items = new List<string>() { "First", "Second", "Third" };
            listView.ItemsSource = items;

            // Page 155
            listView.ItemTapped += async ( sender, e ) =>
            {
                await DisplayAlert( "Tapped", e.Item.ToString() + " was tapped.", "OK" );
                ( (ListView)sender ).SelectedItem = null;           // Page 156
            };

            listView.ItemSelected += async ( sender, e ) =>
            {
                if ( e.SelectedItem == null ) return;          // Page 156
                await DisplayAlert( "Selected", e.SelectedItem.ToString() + " was selected.", "OK" );
                ( (ListView)sender ).SelectedItem = null;           // Page 156
            };

            // Page 155
            this.Padding = new Thickness( 0, Device.OnPlatform( 20, 0, 0 ), 0, 0 );

            this.Content = listView;
        }
    }
}
