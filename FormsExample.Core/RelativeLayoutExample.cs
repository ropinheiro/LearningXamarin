using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 55 to 64
    public class RelativeLayoutExample : ContentPage
    {
        public RelativeLayoutExample()
        {
            RelativeLayout relativeLayout = new RelativeLayout();

            // Pages 55 and 56
            Label upperLeft = new Label
            {
                Text = "Upper Left",
                FontSize = 20
            };

            relativeLayout.Children.Add( upperLeft,
                Constraint.Constant( 0 ),
                Constraint.Constant( 0 ) );

            // Pages 56 and 57
            Label constantLabel = new Label
            {
                Text = "Constants are Absolute",
                FontSize = 20
            };

            relativeLayout.Children.Add( constantLabel,
                Constraint.Constant( 100 ),
                Constraint.Constant( 100 ),
                Constraint.Constant( 50 ),
                Constraint.Constant( 200 ) );

            // Pages 57 and 58
            Label halfwayDown = new Label
            {
                Text = "Halfway down and across",
                FontSize = 15
            };

            relativeLayout.Children.Add( halfwayDown,
                Constraint.RelativeToParent( ( parent ) =>
                 {
                     return parent.Width / 2;
                 } ),
                Constraint.RelativeToParent( ( parent ) =>
                {
                    return parent.Height / 2;
                } )
            );

            // Pages 59 and 60
            BoxView boxView = new BoxView
            {
                Color = Color.Accent,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            relativeLayout.Children.Add( boxView,
                Constraint.Constant( 0 ),
                Constraint.RelativeToParent( ( parent ) =>
                 {
                     return parent.Height / 2;
                 } ),
                Constraint.RelativeToParent( ( parent ) =>
                {
                    return parent.Width / 2;
                } ),
                Constraint.RelativeToParent( ( parent ) =>
                {
                    return parent.Height / 2;
                } )
            );

            // Pages 60 and 61
            Label below = new Label
            {
                Text = "Below Upper Left",
                FontSize = 15
            };

            relativeLayout.Children.Add( below,
                Constraint.Constant( 0 ),
                Constraint.RelativeToView( upperLeft, ( parent, sibling ) =>
                 {
                     return sibling.Y + sibling.Height;
                 } )
            );

            this.Content = relativeLayout;
        }
    }
}
