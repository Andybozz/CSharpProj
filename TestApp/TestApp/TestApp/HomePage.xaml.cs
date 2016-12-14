using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }


        protected async void controlButton_Clicked(object s, object e)
        {
            //TODO: sistemare qui che riparta dall'inizio bene, al momento non torna
            var res = await DisplayAlert("Are You Sure?","Do you want to know who you are?", "Confirm", "Undo");
            if (res)
            {


                await DisplayAlert("You Ask Me", "You are a fucking genius", "I Knew", "Thanks");

            }



        }
    }
}
