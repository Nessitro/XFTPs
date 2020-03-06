using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertView : ContentPage
    {
        public AlertView()
        {
            InitializeComponent();
        }

        private async void DisplayAlert_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert.", "OK");
        }

        private async void DisplayAlertQuestion_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Save?", "Would you like to save your data ? ", "Yes", "No");
            Console.WriteLine("Save data: " + response);
        }

        private async void DisplayActionSheet_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
            Console.WriteLine("Action: " + action);
        }
    }
}