using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 162 to 167
    public class ListItemCell : ViewCell
    {
        public ListItemCell()
        {
            // Page 163
            Label titleLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 25,
                FontAttributes = Xamarin.Forms.FontAttributes.Bold,
                TextColor = Color.White
            };
            titleLabel.SetBinding( Label.TextProperty, "Title" );

            Label descLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 32,
                TextColor = Color.White
            };
            descLabel.SetBinding( Label.TextProperty, "Description" );

            StackLayout viewLayoutItem = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { titleLabel, descLabel }
            };

            // Page 164
            Label priceLabel = new Label
            {
                HorizontalOptions = LayoutOptions.End,
                FontSize = 25,
                TextColor = Color.Aqua
            };
            priceLabel.SetBinding( Label.TextProperty, "Price" );

            StackLayout viewLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness( 25, 10, 55, 15 ),
                Children = { viewLayoutItem, priceLabel }
            };

            View = viewLayout;
        }
    }

    // Page 162
    public class ListItem2
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string Price { get; set; }
    }
}
