using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 64 to 70
    public class AbsoluteLayoutExample : ContentPage
    {
        public AbsoluteLayoutExample()
        {
            // Page 64
            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Page 65
            Label firstLabel = new Label
            {
                Text = "FirstLabel"
            };

            // Below, there are 2 alternatives of the same code.

            // Page 65 - alternative 1, single statement
            absoluteLayout.Children.Add(
                firstLabel,
                new Rectangle // all Rectangle parameters range from 0 to 1
                (
                    0, 0,                      // top left (x,y)
                    AbsoluteLayout.AutoSize,   // width
                    AbsoluteLayout.AutoSize    // height
                ),
                AbsoluteLayoutFlags.PositionProportional );

            // Page 65 - alternative 2, longhand
            // Commented because only one of the alternatives can be executing
            //absoluteLayout.Children.Add( firstLabel );
            //AbsoluteLayout.SetLayoutFlags( firstLabel,
            //    AbsoluteLayoutFlags.PositionProportional );
            //AbsoluteLayout.SetLayoutBounds( firstLabel,
            //    new Rectangle // all Rectangle parameters range from 0 to 1
            //    (
            //        0, 0,                      // top left (x,y)
            //        AbsoluteLayout.AutoSize,   // width
            //        AbsoluteLayout.AutoSize    // height
            //    )
            //);

            // Page 66
            Label secondLabel = new Label
            {
                Text = "SecondLabel"
            };

            absoluteLayout.Children.Add( secondLabel );
            AbsoluteLayout.SetLayoutFlags( secondLabel,
                AbsoluteLayoutFlags.PositionProportional );
            AbsoluteLayout.SetLayoutBounds( secondLabel,
                new Rectangle
                (
                    0, 1,
                    AbsoluteLayout.AutoSize,
                    AbsoluteLayout.AutoSize
                )
            );

            this.Content = absoluteLayout;

        }
    }
}
