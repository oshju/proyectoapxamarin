using System;
using System.Collections.Generic;
using proyectouno.ViewModels;
using proyectouno.Views;
using Xamarin.Forms;

namespace proyectouno
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
