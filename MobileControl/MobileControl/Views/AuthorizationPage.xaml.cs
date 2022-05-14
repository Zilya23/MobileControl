using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileControl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btn_auth_Clicked(object sender, EventArgs e)
        {
            if (entry_login.Text == "123" && entry_pass.Text == "123")
            {
                Navigation.PushAsync(new ListPage());
            }
            else
            {
                entry_login.Text = "Неверный логин";
                entry_pass.Text = "Неверный пароль";
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}