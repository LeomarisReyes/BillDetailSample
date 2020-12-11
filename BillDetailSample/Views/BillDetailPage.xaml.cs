using System;
using System.Collections.Generic;
using BillDetailSample.ViewModels;
using Xamarin.Forms;

namespace BillDetailSample.Views
{
    public partial class BillDetailPage : ContentPage
    {
        public BillDetailPage()
        {
            InitializeComponent();
            BindingContext = new BillDetailViewModel();
        }
    }
}
