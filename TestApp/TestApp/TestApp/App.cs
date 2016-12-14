using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Helpers;
using Xamarin.Forms;

namespace TestApp
{
    public class App : Application
    {
        public App()
        {
            OnStart();
          
        }

        protected override void OnStart()
        {

            NavigationHelper.Root(new HomePage());

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
