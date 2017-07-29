using System;
using System.Threading.Tasks;
using Xamarin.AplicacaoMVVM.ViewModel.Service;
using Xamarin.Forms;

namespace Xamarin.AplicacaoMVVM.View.Service
{
    public class NavigationService: INavigationService
    {
       

        public async Task NavigateToLogin()
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LoginView());
            }
            catch (Exception e)
            {
                throw e;
            }

            
        }

        public async Task NavigateToRegister()
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new RegisterView());
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public async Task NavigateToMain()
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new MainView());
            }
            catch (Exception e)
            {
                
                throw e;
            }
            
        }
    }
}
