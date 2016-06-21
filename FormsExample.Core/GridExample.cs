using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 71 to 80
    public class GridExample : ContentPage
    {
        public GridExample()
        {
            // Page 71
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    // Pages 72, 74
                    new RowDefinition { Height = new GridLength( 200, GridUnitType.Absolute ) },
                    // Page 75
                    new RowDefinition { Height = new GridLength( 1, GridUnitType.Star ) },
                    new RowDefinition { Height = GridLength.Auto }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    // Page 72, 77
                    new ColumnDefinition { Width = new GridLength( 1, GridUnitType.Star ) },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                // Page 79
                RowSpacing = 20,
                ColumnSpacing = 20
            };

            // Page 71
            grid.Children.Add
            (
                new Label
                {
                    Text = "I'm at 0,0",
                    FontSize = 30
                },
                0, 0 // index column, index row
            );

            // Page 72
            grid.Children.Add
            (
                new Label
                {
                    Text = "Me? 1,1",
                    FontSize = 30,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.Black,
                    BackgroundColor = Color.Lime
                },
                // Page 77 - merge cells
                1, 3, 1, 2
            );

            grid.Children.Add
            (
                new Label
                {
                    Text = "2,2 here",
                    FontSize = 25,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.White,
                    BackgroundColor = Color.Red
                },
                // Page 78 - merge cells
                2, 3, 2, 4
            );

            grid.Children.Add
            (
                new Label
                {
                    Text = "I'm at 0,2",
                    FontSize = 30,
                    FontAttributes = FontAttributes.Bold,
                },
                0, 3
            );


            this.Content = grid;

        }
    }
}
