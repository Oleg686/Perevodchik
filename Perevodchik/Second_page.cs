using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Perevodchik
{
    internal class Second_page: ContentPage
    {

        Entry field = new Entry();
        Button BTN = new Button();
        protected override void OnAppearing()
        {
            StackLayout Layout = new StackLayout();
            Label label = new Label();
            label.Text = "Перевод из дюймов в милиметры";
            label.TextColor = Color.Red;
            label.FontSize = 20;
            label.FontAttributes = FontAttributes.Bold;
            field.Placeholder = "Дюймы";
            BTN.Text = "Рассчитать";
            BTN.Clicked += BTN_Clicked; ;
            Layout.Children.Add(label);
            Layout.Children.Add(field);
            Layout.Children.Add(BTN);
            Content = Layout;
        }
        private void BTN_Clicked(object sender, EventArgs e)
        {
            double duim = Convert.ToDouble(field.Text);
            double mult = 1;
            double n = duim, k = 0, i = 0;
            for (; n > 10; i++)
            {
                k = n % 10;
                n /= 10;
            }
            k = n;
            for (int j = 0; j <= i; j++)
            {
                mult *= 10;
            }

            BTN.Text = Convert.ToString(Math.Round((duim * 25.4) / mult,1));
        }
    }
}
