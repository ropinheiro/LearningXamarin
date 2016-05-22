using Xamarin.Forms;

namespace FormsExample.Core
{
    public class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            Label labelLarge = new Label
            {
                Text = "Label",
                // FontSize = 40,
                FontSize = Device.GetNamedSize( NamedSize.Large, typeof( Button ) ),
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.White,
                FontFamily = "Courier",
                FontAttributes = FontAttributes.Bold
            };

            Label labelSmall = new Label
            {
                Text = "This control is great for\n"
                     + "displaying one or more\n"
                     + "lines of text.",
                // FontSize = 20,
                FontSize = Device.GetNamedSize( NamedSize.Medium, typeof( Button ) ),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Italic
            };

            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    labelLarge,
                    labelSmall
                },
                HeightRequest = 1500,
            };

            this.Content = stackLayout;
            this.BackgroundColor = Color.Black;
        }
    }
}
