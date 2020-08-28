using SiADi.WPF.Commands;
using SiADi.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SiADi.WPF.State.Navigators
{
    public class Navigator : INavigator
    {
        public ViewModelBase CurrentViewModel { get; set; }

        public ICommand UpdateCurrenViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}