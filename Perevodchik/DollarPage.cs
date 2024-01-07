using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Perevodchik
{
    internal class DollarPage: ContentPage
    {
        Entry field = new Entry();
        Button BTN = new Button();
        Label res = new Label();
        protected override void OnAppearing()
        {
            StackLayout Layout = new StackLayout();
            Label label = new Label();
            label.Text = "Перевод долларов в рубли";
            label.TextColor = Color.Red;
            label.FontSize = 20;
            label.FontAttributes = FontAttributes.Bold;
            field.Placeholder = "Введите доллары";
            BTN.Text = "Рассчитать";
            BTN.Clicked += BTN_Clicked;
            Layout.Children.Add(label);
            Layout.Children.Add(field);
            Layout.Children.Add(res);
            Layout.Children.Add(BTN);
            Content = Layout;
        }

        private void BTN_Clicked(object sender, EventArgs e)
        {
            //WebClient client = new WebClient();
            //var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            //XDocument xdoc = XDocument.Parse(xml);
            //var el = xdoc.Element("ValCurs").Elements("Valute");
            //string dollar = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
            res.Text = GlobalVariables.dollar;
            double result = double.Parse(res.Text.Replace(',', '.'));
            res.Text = "Долларов: " + Convert.ToString(Math.Round(Convert.ToDouble(field.Text) * result, 2));
        }
    }
}
