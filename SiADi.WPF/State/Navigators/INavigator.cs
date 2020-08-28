using SiADi.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SiADi.WPF.State.Navigators
{
    public enum ViewType
        {
            General,
            Principal,
            lol
        }
    public interface INavigator
    {
        
        public ViewModelBase CurrentViewModel { get; set; }
        public ICommand UpdateCurrentViewModelCommand { get; }
    }
}
