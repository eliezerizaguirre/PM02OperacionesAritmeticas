using System;
using Xamarin.Forms;

namespace PMO2OperacionesBasicas
{
    public partial class MainPage : ContentPage
    {
        Funciones obj = new Funciones();
       
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsumar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);
            int suma;
            //txtresult.Text = int.Parse(obj.suma((double)num1, (double)num2)).ToString();
            txtresult.Text = (double.Parse(txtnum2.Text) + int.Parse(txtnum1.Text)).ToString();
            await Navigation.PushAsync(new SecondPage());
        }

        private async void btnrestar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);
            //obj.resta((double)num1, (double)num2);
            txtresult.Text = (double.Parse(txtnum2.Text) - int.Parse(txtnum1.Text)).ToString();
            await Navigation.PushAsync(new SecondPage());
        }

        private async void btnmultiplicar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);
            //obj.multiplicacion((double)num1, (double)num2);
            txtresult.Text = (double.Parse(txtnum2.Text) * int.Parse(txtnum1.Text)).ToString();
            await Navigation.PushAsync(new SecondPage());
        }

        private async void btndividir_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);
            //obj.division((double)num1, (double)num2);
            txtresult.Text = (double.Parse(txtnum2.Text) / int.Parse(txtnum1.Text)).ToString();
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
