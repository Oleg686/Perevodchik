using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Perevodchik
{
    internal class Third_page : ContentPage
    {

        Entry field = new Entry();
        Label Metr = new Label();
        Label Can = new Label();
        Button BTN = new Button();
        protected override void OnAppearing()
        {
            StackLayout Layout = new StackLayout();
            Label label = new Label();
            label.Text = "Перевод из сантиметров и метров в милиметры";
            label.TextColor = Color.Red;
            label.FontSize = 20;
            label.FontAttributes = FontAttributes.Bold;
            field.Placeholder = "Введите сантиметры";
            BTN.Text = "Рассчитать";
            BTN.Clicked += BTN_Clicked;
            Layout.Children.Add(label);
            Layout.Children.Add(field);
            Layout.Children.Add(Metr);
            Layout.Children.Add(Can);
            Layout.Children.Add(BTN);
            Content = Layout;
        }
        private void BTN_Clicked(object sender, EventArgs e)
        {
            Can.Text = "Сантеметров: " + Convert.ToString((Convert.ToDouble(field.Text) * 10));
            Metr.Text ="Метров: " + Convert.ToString((Convert.ToDouble(field.Text) * 1000));
        }
    }
}
