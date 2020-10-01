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
            AreasBorrar,
            AreasCrear,
            AreasEditar,
            AreasPrincipal,
            AsistenciasBorrar,
            AsistenciasEditar,
            AsistenciasInformeGeneral,
            AsistenciasInformeIndividual,
            AsistenciasPrincipal,
            AsistenciasRegistrar,
            CargosBorrar,
            CargosCrear,
            CargosEditar,
            CargosPrincipal,
            UsuariosBorrar,
            UsuariosCrear,
            UsuariosEditar,
            UsuariosPrincipal
        }
    public interface INavigator
    {
        
        public ViewModelBase CurrentViewModel { get; set; }
        public ICommand UpdateCurrentViewModelCommand { get; }
    }
}
