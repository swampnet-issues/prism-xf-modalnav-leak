using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestModalNav.ViewModels
{
    public class ChildThreeViewModel : BindableBase, IDialogAware
    {
        public ChildThreeViewModel()
        {
        }

        private DelegateCommand _goBackCommand;
        public DelegateCommand GoBackCommand => _goBackCommand ?? (_goBackCommand = new DelegateCommand(GoBack));
        private void GoBack()
        {
            RequestClose(null);
        }


        // IDialogAware
        public event Action<IDialogParameters> RequestClose;
        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}
