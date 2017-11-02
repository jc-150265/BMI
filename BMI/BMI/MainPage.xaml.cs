using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("身長", Height.Text, "OK");
            //DisplayAlert("体重", Weight.Text, "OK");
            //this.hoge.Text = int.Parse("this.Weight") / (((int)this.Height / 100) ^ 2);

            double h = double.Parse(Height.Text);
            double w = double.Parse(Weight.Text);
            if(h >= 3)
            {
                h /= 100;
            }
            double bmi = w / h / h;

            //DisplayAlert("BMI", bmi.ToString(), "OK");

            string x = bmi.ToString();
            hoge.Text = x;

            /*
            if (bmi < 18.5)
            {
                DisplayAlert("BMI","BMI値は"+ bmi.ToString()+"でやせ型です", "OK");
            }else if(bmi < 25){
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で普通体重です", "OK");
            }
            else if (bmi < 30)
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で肥満(1度)です", "OK");
            }
            else if (bmi < 35)
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で肥満(2度)です", "OK");
            }
            else if (bmi < 40)
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で肥満(3度)です", "OK");
            }
            else
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で肥満(4度)です", "OK");
            }
            */
            if (bmi < 18.5)
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "でやせ型です", "OK");
            }
            else if (bmi < 25)
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で普通体重です", "OK");
            }
            else if (bmi < 30)
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で肥満(1度)です", "OK");
            }
            else if (bmi < 35)
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で肥満(2度)です", "OK");
            }
            else if (bmi < 40)
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で肥満(3度)です", "OK");
            }
            else
            {
                DisplayAlert("BMI", "BMI値は" + bmi.ToString() + "で肥満(4度)です", "OK");
            }

        }
    }
}
