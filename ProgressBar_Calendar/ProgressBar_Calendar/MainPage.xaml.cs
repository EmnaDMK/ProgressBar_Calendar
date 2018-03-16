using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProgressBar_Calendar
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            //MainProgressBar.Progress = 0.8;
        }

        private void MainSlider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            Mainlabel.Text = MainSlider.Value.ToString();


            //if (MainSlider.Value.Equals(MainSlider.Maximum))
            //{

              
            //}
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await MainProgressBar.ProgressTo(1, 2000, Easing.Linear);
        //}
        private void SwitchToggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            Switchlabel.Text = isToggled.ToString();
            //if (isToggled.ToString().Equals(true))
            //{
            //   MainSlider.Value = 100;
            //}
        }


        //private void DatePikker(object sender, DateChangedEventArgs e)
        //{

        //    Datelabel.Text = e.NewDate.ToString();



        //}

        
    }
}

