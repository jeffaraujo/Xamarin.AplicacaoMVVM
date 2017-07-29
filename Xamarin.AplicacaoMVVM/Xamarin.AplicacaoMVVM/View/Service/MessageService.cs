using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.AplicacaoMVVM.View.Service
{
    public class MessageService: ViewModel.Service.IMessageService
    {
        public async Task ShowAsync(string message)
        {
            await Xamarin.AplicacaoMVVM.App.Current.MainPage.DisplayAlert("MVVM", message, "ok");
        }
    }
}
