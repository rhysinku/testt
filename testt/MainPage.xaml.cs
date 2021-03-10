using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Button_Clicked(object sender, EventArgs e)
        {

            

            if (string.IsNullOrWhiteSpace(Heights.Text) || string.IsNullOrWhiteSpace(Weights.Text))
            {
                DisplayAlert("No Data", "Please Insert Data", "OK");
            }
            else
            {
                double h = double.Parse(Heights.Text);
                double w = double.Parse(Weights.Text);
                double bmistring = 0;
                //bmistring = Math.Round(w / (h * h) * 10000);

                bmistring = (w / h / h) * 10000;
                //Total.Text = bmistring + "";
                Total.Text = bmistring.ToString("f2");

                if (bmistring < 18.5)
                {
                    BMI.Text = "UnderWeight";
                }
                else if (bmistring < 24.9)
                {
                    BMI.Text = "Normal Weight";
                }
                else if (bmistring < 29.9)
                {
                    BMI.Text = "Over Weight";
                }
                else
                    BMI.Text = "Obese";
            }
        }
    }
}

