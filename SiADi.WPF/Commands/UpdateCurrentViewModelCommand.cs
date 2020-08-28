using SiADi.WPF.State.Navigators;
using SiADi.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using static SiADi.WPF.State.Navigators.INavigator;

namespace SiADi.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch(viewType)
                {
                    case ViewType.General:
                        _navigator.CurrentViewModel = new GeneralViewModel();
                        break;
                    case ViewType.Principal:
                        _navigator.CurrentViewModel = new PrincipalViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
