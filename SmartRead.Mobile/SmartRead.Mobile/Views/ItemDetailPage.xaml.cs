﻿using SmartRead.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SmartRead.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}