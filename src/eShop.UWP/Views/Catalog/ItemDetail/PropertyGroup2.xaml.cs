﻿using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using eShop.UWP.ViewModels;

namespace eShop.UWP.Views
{
    public sealed partial class PropertyGroup2 : UserControl
    {
        public PropertyGroup2()
        {
            this.InitializeComponent();
        }

        public ItemDetailViewModel ViewModel { get; set; }
    }
}
