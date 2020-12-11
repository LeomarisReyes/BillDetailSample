using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BillDetailSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.BillDetailPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
