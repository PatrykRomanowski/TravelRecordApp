using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

     

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEntry = string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEntry = string.IsNullOrEmpty(passwordEntry.Text);

            if (isEmailEntry || isPasswordEntry)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
