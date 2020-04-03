﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Covid19Radar.ViewModels
{
    public class DescriptionPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public DescriptionPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "App Description";
        }

        public Command OnClickNext => (new Command(() =>
        {
            _navigationService.NavigateAsync("SmsVerificationPage");
        }));


    }
}
