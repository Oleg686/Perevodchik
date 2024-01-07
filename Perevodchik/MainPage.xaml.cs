using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Perevodchik
{
    public static class GlobalVariables
    {
        public static WebClient client = new WebClient();
        public static var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
        public static XDocument xdoc = XDocument.Parse(xml);
        public static var el = xdoc.Element("ValCurs").Elements("Valute");
        public static string dollar = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
        public static string eur = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
    }
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            Title = "Начальная страница";
            Button first_page = new Button
            {
                Text = "Перевод валюты",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            first_page.Clicked += First_page_Clicked;

            Button Second_Page = new Button
            {
                Text = "Перевод в систему СИ",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Second_Page.Clicked += Second_Page_Clicked;
            Content = new StackLayout { Children = { first_page, Second_Page} };
        }

        private async void Second_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ZeroPage()));
        }

        private async void First_page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MoneyPage()));
        }
    }
}
