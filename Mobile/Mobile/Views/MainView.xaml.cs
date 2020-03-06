using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainView : ContentPage
    {
        public const string FEATURE_ENTRY = "FEATURE_ENTRY";
        public const string FEATURE_EDITOR = "FEATURE_EDITOR";
        public const string FEATURE_FENETRES = "FEATURE_FENETRES";
        public const string FEATURE_IMAGE = "FEATURE_IMAGE";
        public const string FEATURE_LABEL = "FEATURE_LABEL";
        public const string FEATURE_STACKLAYOUT = "FEATURE_STACKLAYOUT";
        public const string FEATURE_GRILLE = "FEATURE_GRILLE";
        public const string FEATURE_LISTE = "FEATURE_LISTE";
        public const string FEATURE_GESTIONIMAGE = "FEATURE_GESTIONIMAGE";
        public const string FEATURE_MULTIPAGE = "FEATURE_MULTIPAGE";

        public MainView()
        {
            InitializeComponent();
        }

        private void Feature_Clicked(object sender, EventArgs e)
        {
            string featureType = ((Button)sender).BindingContext as string;

            switch (featureType)
            {
                case FEATURE_ENTRY:
                    break;
                case FEATURE_EDITOR:
                    break;
                case FEATURE_FENETRES:
                    break;
                case FEATURE_IMAGE:
                    break;
                case FEATURE_LABEL:
                    break;
                case FEATURE_STACKLAYOUT:
                    break;
                case FEATURE_GRILLE:
                    break;
                case FEATURE_LISTE:
                    break;
                case FEATURE_GESTIONIMAGE:
                    break;
                case FEATURE_MULTIPAGE:
                    break;
                default: break;
            }
        }
    }
}
