using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Xamarin.Forms;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Perevodchik
{

    internal class EuroPage: ContentPage
    {
        Entry field = new Entry();
        Button BTN = new Button();
        Label res = new Label();
        protected override void OnAppearing()
        {
            StackLayout Layout = new StackLayout();
            Label label = new Label();
            label.Text = "Перевод Евро в рубли";
            label.TextColor = Color.Red;
            label.FontSize = 20;
            label.FontAttributes = FontAttributes.Bold;
            field.Placeholder = "Введите евро";
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
            //res.Text = GlobalVariables.eur;
            //double result = double.Parse(res.Text.Replace(',', '.'));
            //res.Text = "Евро: " + Convert.ToString(Math.Round(Convert.ToDouble(field.Text) * result,2));
        }
    }
}
