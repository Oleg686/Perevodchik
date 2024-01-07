using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Perevodchik
{
    internal class Sixth_page : ContentPage
    {
        Entry field = new Entry();
        Button BTN = new Button();
        protected override void OnAppearing()
        {
            StackLayout Layout = new StackLayout();
            Label label = new Label();
            label.Text = "Перевод из Фаренгейта в Цельсия";
            label.TextColor = Color.Red;
            label.FontSize = 20;
            label.FontAttributes = FontAttributes.Bold;
            field.Placeholder = "Введите Фаренгейты";
            BTN.Text = "Рассчитать";
            BTN.Clicked += BTN_Clicked;
            Layout.Children.Add(label);
            Layout.Children.Add(field);
            Layout.Children.Add(BTN);
            Content = Layout;
        }
        private void BTN_Clicked(object sender, EventArgs e)
        {
            BTN.Text = Convert.ToString((Convert.ToDouble(field.Text) - 32) * (5.0/9.0));
        }
    }
}
