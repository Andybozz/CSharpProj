using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using System.Collections;


namespace TestApp.Helpers
{
    public class NavigationHelper
    {
        static Page MainPage {
            get { return Application.Current.MainPage; }
            set { Application.Current.MainPage = value; }
        }

        public static object Parameter { get; set; }
        public static bool DisableNavigation { get; set; }


        static INavigation Navigator {
            get { return MainPage.Navigation; }
        }


        public static void Navigate(Type type)
        {
            Navigate(type, null);
        }
        public static void Navigate(Type type, object info)
        {
            Parameter = info;

            var p = Activator.CreateInstance(type) as Page;
            Navigate(p);
        }


        public static void Root(Page page)
        {
            MainPage = page;
        }


        public static void Navigate(Page page)
        {
            Navigate(null, page);
        }
        public static void Navigate(NavigationPage root, Page page)
        {
            var r = page;
          


            var nav = Navigator;
            if (root != null)
                nav = root.Navigation;


            //var c = 0;
            //while (c < 10 && nav.NavigationStack.Count > 1 && nav.NavigationStack.Contains(page))
            //{
            //    nav.PopAsync();
            //    c++;
            //}


            if (DisableNavigation)
                Root(page);
            else
            {
                if (page.Parent != null)
                    nav.PopToRootAsync(false);

                if (page.Parent == null)
                    nav.PushAsync(page, false);
            }
        }




        public static void Back()
        {
            foreach (var item in Navigator.NavigationStack)
            {
              
            }
            Navigator.PopAsync();
        }




        public static void Alert(string title,string text)
        {
            MainPage.DisplayAlert(title, text, "OK");
        }
    }

}
