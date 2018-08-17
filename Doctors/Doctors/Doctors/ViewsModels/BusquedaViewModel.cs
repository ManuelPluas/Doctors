using System;
using System.Collections.Generic;
using System.Text;

namespace Doctors.ViewsModels
{
    public class BusquedaViewModel
    {
        private LoginViewModel loginViewModel;

        public BusquedaViewModel()
        {
        }

        public BusquedaViewModel(LoginViewModel loginViewModel)
        {
            this.loginViewModel = loginViewModel;
        }
    }
}
