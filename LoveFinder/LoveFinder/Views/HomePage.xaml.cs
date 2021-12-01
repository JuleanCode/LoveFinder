using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoveFinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            //get all users of the app so the player can swipe
            InitializeComponent();
        }
        private void Like_Clicked(object sender, EventArgs e)
        {
            //send the data to the db
        }
        private void dislike_Clicked(object sender, EventArgs e)
        {
            //send the data to the db
        }
    }
}