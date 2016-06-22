using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 81 to 83
    public class ContentViewExample : ContentPage
    {
        public ContentViewExample()
        {
            // Page 81
            ContentView contentView = new ContentView
            {
                BackgroundColor = Color.Teal,
                Padding = new Thickness( 40 ),
                HorizontalOptions = LayoutOptions.Fill,
                Content = new Label
                {
                    Text = "a view, such as a label, a layout or a layout of layouts",
                    FontSize = 20,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.White,
                    // Page 82
                    VerticalOptions = LayoutOptions.StartAndExpand
                }
            };

            // Page 83
            this.Padding = new Thickness( 10, Device.OnPlatform( 20, 0, 0 ), 10, 5 );

            this.Content = new StackLayout
            {
                Children =
                {
                    contentView
                }
            };
        }
    }
}
