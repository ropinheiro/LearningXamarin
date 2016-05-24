using System;
using System.Threading.Tasks; // Page 38.
using Xamarin.Forms;

namespace FormsExample.Core
{
    // Page 26
    public class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            // Page 28
            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    labelLarge,
                    labelSmall,
                    button,
                    entry,
                    entry2,
                    boxView,
                    image,
                    image2
                },
                HeightRequest = 1500,
            };
            // Replaced by code in Page 40
            // Content = stackLayout;

            // Page 39
            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                // Page 40: Scrolls by default vertically. To scroll
                //          horizontally, use the line below.
                // Orientation = ScrollOrientation.Horizontal,
                Content = stackLayout
            };
            // Page #40
            Content = scrollView;

            // Page 29
            BackgroundColor = Color.Black;

            // Page 40
            Padding = new Thickness( 10, Device.OnPlatform( 20, 0, 0 ), 10, 5 );

            #region Tap Gestures

            // Page 38
            // There is an alternative by using new Command().
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += ( s, e ) =>
            {
                if ( image.Opacity >= .1 )
                    image.Opacity -= .1;
                else
                    image.Opacity = 0;
            };
            image.GestureRecognizers.Add( tapGestureRecognizer );

            var tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += async ( sender, e ) =>
            {
                image2.Opacity = .5;
                await Task.Delay( 200 );
                image2.Opacity = 1;
            };
            image2.GestureRecognizers.Add( tapGestureRecognizer2 );

            #endregion

            // Page 32
            button.Clicked += OnButtonClicked;
        }

        #region Page Views

        // Page 27
        Label labelLarge = new Label
        {
            Text = "Label",
            // FontSize = 40,
            FontSize = Device.GetNamedSize( NamedSize.Large, typeof( Button ) ),
            // See more on HorizontalOptions and VerticalOptions in page 33.
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.White,
            // For platform-specific nuances when using Fonts, see pages 29-30.
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

        // Pages 31-32
        Button button = new Button
        {
            Text = "Make It so",
            FontSize = Device.GetNamedSize( NamedSize.Large, typeof( Button ) ),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Fill,
        };

        // Page 34
        Entry entry = new Entry
        {
            Placeholder = "Username",
            VerticalOptions = LayoutOptions.Center,
            Keyboard = Keyboard.Text
        };

        // Page 34
        Entry entry2 = new Entry
        {
            Placeholder = "Password",
            VerticalOptions = LayoutOptions.Center,
            Keyboard = Keyboard.Text,
            IsPassword = true
        };

        // Page 35
        BoxView boxView = new BoxView
        {
            Color = Color.Silver,
            WidthRequest = 150,
            HeightRequest = 150,
            HorizontalOptions = LayoutOptions.StartAndExpand,
            VerticalOptions = LayoutOptions.Fill
        };

        // Page 36
        Image image = new Image
        {
            // Warning: see page 37 for important nuances when using Local
            // images. Image location and build property differs by platform.
            Source = "http://www.together.pt/images/logotipo.jpg",
            // See page 37 for details on Aspect values.
            Aspect = Aspect.AspectFit,
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Fill
        };

        // Page 36
        Image image2 = new Image
        {
            // Warning: see page 37 for important nuances when using Local
            // images. Image location and build property differs by platform.
            Source = "http://www.together.pt/images/logotipo.jpg",
            // See page 37 for details on Aspect values.
            Aspect = Aspect.AspectFit,
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Fill
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
