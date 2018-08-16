using System;
using System.Collections.Generic;
using System.Text;

namespace Doctors.ViewsModels

{

    public class MainViewModel
    {

        #region ViewModels 
        //este Login es que se va a ligar a la Login
        public LoginViewModel Login
        {
            get;
            set;
        }

        //estoy instanciando el Busqueda ya que este esta en el Main bindado
        public BusquedaViewModel Busqueda { get; set; }
        #endregion


        #region constructores

        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }

        #endregion

        //
        #region Singleton 
            //patron singleton 
            // va  a permitir hacer un llamado a la viewModel
            //sin necesidad de volverla a instasiar desde cualquier clase
        private static MainViewModel instance;//le damos el nombre de instance
        public static MainViewModel GetInstance() // le damos el nombre GetInstance
        {
            if(instance == null)
            {

                return new MainViewModel();
            }
            return instance;

        }
        #endregion

    }
}
