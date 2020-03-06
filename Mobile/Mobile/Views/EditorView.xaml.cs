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
    public partial class EditorView : ContentPage
    {
        public EditorView()
        {
            InitializeComponent();
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;

        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            string text = ((Editor)sender).Text;
        }
    }
}