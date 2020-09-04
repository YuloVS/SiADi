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
                    case ViewType.AreasBorrar:
                        _navigator.CurrentViewModel = new AreasBorrarViewModel();
                        break;
                    case ViewType.AreasCrear:
                        _navigator.CurrentViewModel = new AreasCrearViewModel();
                        break;
                    case ViewType.AreasEditar:
                        _navigator.CurrentViewModel = new AreasEditarViewModel();
                        break;
                    case ViewType.AsistenciasBorrar:
                        _navigator.CurrentViewModel = new AsistenciasBorrarViewModel();
                        break;
                    case ViewType.AsistenciasEditar:
                        _navigator.CurrentViewModel = new AsistenciasEditarViewModel();
                        break;
                    case ViewType.AsistenciasInformeGeneral:
                        _navigator.CurrentViewModel = new AsistenciasInformeGeneralViewModel();
                        break;
                    case ViewType.AsistenciasInformeIndividual:
                        _navigator.CurrentViewModel = new AsistenciasInformeIndividualViewModel();
                        break;
                    case ViewType.AsistenciasPrincipal:
                        _navigator.CurrentViewModel = new AsistenciasPrincipalViewModel();
                        break;
                    case ViewType.AsistenciasRegistrar:
                        _navigator.CurrentViewModel = new AsistenciasRegistrarViewModel();
                        break;
                    case ViewType.CargosBorrar:
                        _navigator.CurrentViewModel = new CargosBorrarViewModel();
                        break;
                    case ViewType.CargosCrear:
                        _navigator.CurrentViewModel = new CargosCrearViewModel();
                        break;
                    case ViewType.CargosEditar:
                        _navigator.CurrentViewModel = new CargosEditarViewModel();
                        break;
                    case ViewType.UsuariosBorrar:
                        _navigator.CurrentViewModel = new UsuariosBorrarViewModel();
                        break;
                    case ViewType.UsuariosCrear:
                        _navigator.CurrentViewModel = new UsuariosCrearViewModel();
                        break;
                    case ViewType.UsuariosEditar:
                        _navigator.CurrentViewModel = new UsuariosEditarViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
