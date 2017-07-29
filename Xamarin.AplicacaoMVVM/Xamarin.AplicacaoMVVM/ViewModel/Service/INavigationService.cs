using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.AplicacaoMVVM.ViewModel.Service
{
    public interface INavigationService
    {
        //Task NavigateTo(string viewName, object param);
        Task NavigateToLogin();
        Task NavigateToRegister();
        Task NavigateToMain();
    }
}
