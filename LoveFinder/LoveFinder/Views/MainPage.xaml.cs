using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LoveFinder.Views;

namespace LoveFinder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            if (Email.Text == null || Password.Text == null)
            {
                DisplayAlert("Alert", "You have to fill in all fields", "OK");
            }
        }
        private void Register_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
