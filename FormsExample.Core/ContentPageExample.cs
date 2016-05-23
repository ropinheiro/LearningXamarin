using System;
using Xamarin.Forms;

namespace FormsExample.Core
{
    public class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            // Assign handlers
            this.button.Clicked += OnButtonClicked;

            // Setup layout
            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    labelLarge,
                    labelSmall,
                    button,
                    entry,
                    entry2
                },
                HeightRequest = 1500,
            };
            this.Content = stackLayout;
            this.BackgroundColor = Color.Black;
        }

        #region Page Controls

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

        Button button = new Button
        {
            Text = "Make It so",
            FontSize = Device.GetNamedSize( NamedSize.Large, typeof( Button ) ),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Fill,
        };

        Entry entry = new Entry
        {
            Placeholder = "Username",
            VerticalOptions = LayoutOptions.Center,
            Keyboard = Keyboard.Text
        };

        Entry entry2 = new Entry
        {
            Placeholder = "Password",
            VerticalOptions = LayoutOptions.Center,
            Keyboard = Keyboard.Text,
            IsPassword = true
        };

        #endregion

        #region Event Handlers

        void OnButtonClicked( object sender, EventArgs e )
        {
            button.Text = "It is so!";
        }

        #endregion

    }
}
