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
    public partial class EntryView : ContentPage
    {
        public EntryView()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;

        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;

        }
    }
}