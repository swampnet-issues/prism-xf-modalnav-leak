using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestModalNav.ViewModels
{
    public class ChildTwoPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public ChildTwoPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        private DelegateCommand _goBackCommand;
        public DelegateCommand GoBackCommand => _goBackCommand ?? (_goBackCommand = new DelegateCommand(GoBack));
        private async void GoBack()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
