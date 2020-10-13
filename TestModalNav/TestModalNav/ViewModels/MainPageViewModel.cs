using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestModalNav.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IDialogService _dialogService;

        public MainPageViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService)
        {
            _dialogService = dialogService;

            Title = "Main Page";
        }


        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand(Navigate));
        private async void Navigate()
        {
            await NavigationService.NavigateAsync("ChildOnePage");
        }


        private DelegateCommand _navigateModalCommand;
        public DelegateCommand NavigateModalCommand => _navigateModalCommand ?? (_navigateModalCommand = new DelegateCommand(NavigateModal));
        private async void NavigateModal()
        {
            await NavigationService.NavigateAsync("ChildTwoPage", useModalNavigation: true);
        }


        private DelegateCommand _navigateDialogCommand;
        public DelegateCommand NavigateDialogCommand => _navigateDialogCommand ?? (_navigateDialogCommand = new DelegateCommand(NavigateDialog));
        private void NavigateDialog()
        {
            _dialogService.ShowDialog("ChildThreePage");
        }
    }
}
