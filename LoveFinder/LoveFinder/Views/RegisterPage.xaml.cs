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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void Register_Clicked(object sender, EventArgs e)
        {
            if(FirstName.Text == null || LastName.Text == null || Age.Text == null || Gender.SelectedItem == null || SexualOrientation.SelectedItem == null || Email.Text == null || Password.Text == null || PasswordCheck == null)
            {
                DisplayAlert("Alert", "You have to fill in all fields", "OK");
            }
            else if(Password.Text != PasswordCheck.Text)
            {
                DisplayAlert("Alert", "Password and Password check are not the same", "OK");
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}