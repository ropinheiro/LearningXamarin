using System.Collections.Generic;
using Xamarin.Forms;

namespace FormsExample.Core
{
    // Pages 106 to ...
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

            this.Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    eventValue,
                    pageValue,
                    picker,
                    datePicker,
                    timePicker
                }
            };
        }
    }
}
