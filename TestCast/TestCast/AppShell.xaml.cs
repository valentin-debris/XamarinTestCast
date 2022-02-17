using System;
using System.Collections.Generic;
using TestCast.ViewModels;
using TestCast.Views;
using Xamarin.Forms;

namespace TestCast
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
