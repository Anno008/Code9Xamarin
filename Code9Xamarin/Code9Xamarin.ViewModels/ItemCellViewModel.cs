﻿using Code9Xamarin.Core.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Code9Xamarin.ViewModels
{
    public class ItemCellViewModel : INotifyPropertyChanged
    {
        private readonly INavigationService _navigationService;

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ItemCellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
