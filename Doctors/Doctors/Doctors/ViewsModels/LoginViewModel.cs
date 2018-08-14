using System;
using System.Collections.Generic;
using System.Text;


namespace Doctors.ViewsModels
{
    using System.Windows.Input;
    class LoginViewModel
    {

        #region propiedades
        //aqui irian las propiedades que fueron mencionadas para ser
        //capturadas ejemplo
        // public String Email{get;set}
        #endregion

        #region Comands //botones //debemos importar le s.w.Input
        public ICommand BuscarCommand { get; set; }
        #endregion


    }
}
