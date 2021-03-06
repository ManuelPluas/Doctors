using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Doctors
{
    using Doctors.ViewsModels;
    using Views;
   
    
	public partial class App : Application
	{
        #region constructor
        public App ()
		{
			InitializeComponent();
            MainViewModel.GetInstance().Login = new LoginViewModel();
			this.MainPage = new NavigationPage (new LoginPage());
		}
        #endregion
        
    
    #region metodos
    protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        #endregion
    }
}
