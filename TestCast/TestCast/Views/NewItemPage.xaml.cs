using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestCast.Models;
using TestCast.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCast.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}