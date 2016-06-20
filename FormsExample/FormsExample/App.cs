using FormsExample.Core;
using Xamarin.Forms;

namespace FormsExample
{
    public class App : Application
    {
        // Page 22-25
        public App()
        {
            // Page 26
            // MainPage = new ContentPageExample();

            // Page 49
            // MainPage = new StackLayoutVertical();

            MainPage = new RelativeLayoutExample();
        
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};
        }

        // Page 23
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        // Page 23
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        // Page 23
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
