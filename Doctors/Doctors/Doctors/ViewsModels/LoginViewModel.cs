using System;
using System.Collections.Generic;
using System.Text;


namespace Doctors.ViewsModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    public class LoginViewModel : BaseViewModel //Esta heredando de basevM
    {

        #region atributos
        private bool isEnabled;
        #endregion

        #region propiedades
        //aqui irian las propiedades que fueron mencionadas para ser
        //capturadas ejemplo
        // public String Email{get;set}

        public bool IsEnabled { get; set; }
        #endregion

        #region construstores




        #endregion
        #region Comands //botones //debemos importar le s.w.Input
        public ICommand BuscarCommand
        {
            get
            {
                return new RelayCommand(Login);

            }
        }


        private void Login()
        {

        }
        #endregion


    }
}
