using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsExample.Core
{
    // Page 49
    public class StackLayoutVertical : ContentPage
    {
        // Pages 50 to 54.
        public StackLayoutVertical()
        {
            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {
                        Text = "Start is flush left",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "Start 2",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "Center",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "Center2",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "End1",
                        HorizontalOptions = LayoutOptions.End
                    },
                    new Label
                    {
                        Text = "End is flush right",
                        HorizontalOptions = LayoutOptions.End
                    }
                }
            };

            this.Content = stackLayout;
        }
    }
}
