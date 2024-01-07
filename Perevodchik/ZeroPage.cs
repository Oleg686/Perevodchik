using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Perevodchik
{
    internal class ZeroPage : ContentPage
    {
        protected override void OnAppearing()
        {
            StackLayout stackLayout = new StackLayout();
            Button first_page = new Button
            {
                Text = "Км/ч",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            first_page.Clicked += First_page_Clicked;

            Button Second_Page = new Button
            {
                Text = "Дюймы",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Second_Page.Clicked += Second_Page_Clicked;
            Button Third_Page = new Button
            {
                Text = "Сантиметры и метры",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Third_Page.Clicked += Third_Page_Clicked;
            Button fourth_page = new Button
            {
                Text = "Ярды",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            fourth_page.Clicked += Fourth_page_Clicked; ;

            Button fith_Page = new Button
            {
                Text = "Фунты",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            fith_Page.Clicked += Fith_Page_Clicked; ;
            Button sixth_Page = new Button
            {
                Text = "Фаренгейты",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            sixth_Page.Clicked += Sixth_Page_Clicked;
            stackLayout.Children.Add(first_page);
            stackLayout.Children.Add(Second_Page);
            stackLayout.Children.Add(Third_Page);
            stackLayout.Children.Add(fourth_page);
            stackLayout.Children.Add(fith_Page);
            stackLayout.Children.Add(sixth_Page);
            Content = stackLayout;
        }

        private async void Sixth_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Sixth_page()));
        }

        private async void Fith_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Fith_page()));
        }

        private async void Fourth_page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Fouth_page()));
        }

        private async void Third_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Third_page()));
        }

        private async void Second_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Second_page()));
        }

        private async void First_page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new First_page()));
        }
    }
}
