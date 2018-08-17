using System;
using System.Collections.Generic;
using System.Text;


namespace Doctors.ViewsModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Views;

    public class LoginViewModel : BaseViewModel //Esta heredando de basevM
    {

        #region atributos
        //private bool isEnabled;
        #endregion

        #region propiedades
        //aqui irian las propiedades que fueron mencionadas para ser
        //capturadas ejemplo
        // public String Email{get;set}

        
        #endregion

        #region construstores




        #endregion

        #region Comands //botones //debemos importar le s.w.Input
        public ICommand BuscarCommand //es de solo lectura
        {
            get
            {
                return new RelayCommand(Buscar);

            }
        }

        //pushAsyn siginifa que estamos aplinado otra pagina
        //llamar a la otra pagina
        private async void Buscar()
        {
            //GetInstance llamamos al singleton
            MainViewModel.GetInstance().Busqueda = new BusquedaViewModel();// antes de lanzar la page iniciarmos la ViewModel
            await App.Current.MainPage.Navigation.PushAsync(new BusquedaPage());
        }
        #endregion


    }
}
