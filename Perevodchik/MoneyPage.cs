using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Perevodchik
{
    internal class MoneyPage: ContentPage
    {
        Label dol = new Label();
        Label euro = new Label();
        protected override void OnAppearing()
        {
            dol.TextColor = Color.Black;
            dol.FontSize = 25;
            euro.TextColor = Color.Black;
            euro.FontSize = 25;
            //dol.Text = $"Евро: {GlobalVariables.eur}";
            //euro.Text = $"Доллар: {GlobalVariables.dollar}";
            StackLayout layout = new StackLayout();
            Button first_page = new Button
            {
                Text = "Перевод из долларов в рубли",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            first_page.Clicked += First_page_Clicked;

            Button Second_Page = new Button
            {
                Text = "Перевод из евро в рубли",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Second_Page.Clicked += Second_Page_Clicked;
            layout.Children.Add(dol);
            layout.Children.Add(euro);
            layout.Children.Add(first_page);
            layout.Children.Add(Second_Page);
            Content = layout;
        }
        private async void Second_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new EuroPage()));
        }

        private async void First_page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new DollarPage()));
        }
    }
}
