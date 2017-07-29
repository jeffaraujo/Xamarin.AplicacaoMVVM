using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.AplicacaoMVVM.ViewModel
{
    public class LoginViewModel: ViewModelBase
    {


        private readonly Service.IMessageService _messageService;
        private readonly Service.INavigationService _navigationService;
        public LoginViewModel()
        {
            this.LoginCommand = new Command(Login);
            this.RegisterCommand = new Command(Register);
            //Capturando o objeto da Injeção de Dependência
            this._messageService = DependencyService.Get<Service.IMessageService>();
            this._navigationService = DependencyService.Get<Service.INavigationService>();
        }

        private string email;

        public string Email
        {
            get { return email;}
            set
            {
                email = value;
                this.OnPropertyChanged("Email");
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; this.OnPropertyChanged("Password"); }
        }


        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public  void Login()
        {
            try
            {
                if (this.Email == "adm@adm.com" && this.Password == "123")
                {
                    //Redirecionar para a página principal
                    _navigationService.NavigateToMain();
                }
                else
                {
                    //Mostrar aviso erro
                    _messageService.ShowAsync("Login e/ou password Incorretos");
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }
            
        }

        public  void Register()
        {
            try
            {
                _navigationService.NavigateToRegister();
            }
            catch (Exception e)
            {
                
                throw e;
            }
            
        }



    }
}
