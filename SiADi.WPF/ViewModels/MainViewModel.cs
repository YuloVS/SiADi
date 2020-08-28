using SiADi.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
