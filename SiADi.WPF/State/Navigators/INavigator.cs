using SiADi.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SiADi.WPF.State.Navigators
{
    public interface INavigator
    {
        public enum ViewType
        {
            General,
            Principal,
            lol
        }
        public ViewModelBase CurrentViewModel { get; set; }
        public ICommand UpdateCurrenViewModelCommand { get; }
    }
}
