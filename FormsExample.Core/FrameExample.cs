using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 83 to 84
    public class FrameExample : ContentPage
    {
        public FrameExample()
        {
            // Page 83
            this.Padding = 20;
            this.Content = new Frame
            {
                Content = new Label { Text = "Framed", FontSize = 40 },
                OutlineColor = Color.Red
            };
        }
    }
}
