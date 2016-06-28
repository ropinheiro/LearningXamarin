using System.Collections.Generic;
using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 106 to 118
    public class Chapter4Controls : ContentPage
    {
        // Page 106
        Label eventValue;
        Label pageValue;

        public Chapter4Controls()
        {
            // Page 106
            eventValue = new Label();
            eventValue.Text = "Value in Handler";
            pageValue = new Label();
            pageValue.Text = "Value in Page";

            // Page 107
            Picker picker = new Picker
            {
                Title = "Option",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var options = new List<string> { "First", "Second", "Third", "Fourth" };
            foreach ( string optionName in options )
            {
                picker.Items.Add( optionName );
            }

            // Page 108
            picker.SelectedIndexChanged += ( sender, args ) =>
            {
                pageValue.Text = picker.Items[ picker.SelectedIndex ];
            };

            // Page 108
            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Page 109
            datePicker.DateSelected += ( object sender, DateChangedEventArgs e ) =>
            {
                eventValue.Text = e.NewDate.ToString();
                pageValue.Text = datePicker.Date.ToString();
            };

            // Page 110
            TimePicker timePicker = new TimePicker
            {
                Format = "T",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Page 111
            timePicker.PropertyChanged += ( sender, e ) =>
            {
                if ( e.PropertyName == TimePicker.TimeProperty.PropertyName )
                {
                    pageValue.Text = timePicker.Time.ToString();
                }
            };

            // Page 113
            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Alternative
            // Stepper stepper = new Stepper( 0, 10, 0, 1 );

            // Page 114
            stepper.ValueChanged += ( sender, e ) =>
            {
                eventValue.Text = string.Format( "Stepper value is {0:F1}", e.NewValue );
                pageValue.Text = stepper.Value.ToString();
            };

            // Page 114
            Slider slider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 50,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 300
            };

            // Alternative
            // Slider slider = new Slider( 0, 100, 50 );

            // Page 115
            slider.ValueChanged += ( sender, e ) =>
            {
                eventValue.Text = string.Format( "Slider value is {0:F1}", e.NewValue );
                pageValue.Text = slider.Value.ToString();
            };

            // Page 115
            Switch switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            switcher.Toggled += ( sender, e ) =>
            {
                eventValue.Text = string.Format( "Switch is now {0}", e.Value );
                pageValue.Text = switcher.IsToggled.ToString();
            };

            // Page 118
            this.Padding = new Thickness( 10,
                Device.OnPlatform( 20, 0, 0 ), 10, 15 );

            this.Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    eventValue,
                    pageValue,
                    picker,
                    datePicker,
                    timePicker,
                    stepper,
                    slider,
                    switcher
                }
            };
        }
    }
}
