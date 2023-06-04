using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quantity
{
    public partial class MainPage : ContentPage
    {
        private int _qty = 0;
        public MainPage()
        {
            InitializeComponent();
            LBLQty.Text = _qty.ToString();
        }

        private void SumButtom(object sender, EventArgs e)
        {
            _qty++;
            LBLQty.Text = _qty.ToString();
        }

        private async void SubButtom(object sender, EventArgs e)
        {
            _qty--;

            if (_qty < 0)
            {
                _qty++;
                await DisplayAlert("Alert", "Number less the 0", "OK");
            }

            LBLQty.Text = _qty.ToString();
        }
    }
}
