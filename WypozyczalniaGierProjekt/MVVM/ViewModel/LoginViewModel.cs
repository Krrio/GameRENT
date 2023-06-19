using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Windows.Input;


namespace WypozyczalniaGierProjekt.MVVM.ViewModel
{
    internal class LoginViewModel : ViewModelBase
    {
        //Fields
        private string _username="Username";
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;

        public string Username 
        { 
            get
            {
                return _username;
            }

            set
            {
                _username = value;
                OnProperyChanged(nameof(Username));
            }
        }

        public SecureString Password
        {
            get
            {
                return (SecureString)_password;
            }

            set
            {
                _password = value;
                OnProperyChanged(nameof(Password));
            }
        }

        public string ErrorMessage 
        { 
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnProperyChanged(nameof(ErrorMessage));
            }
        } 
        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }
            set
            {
                _isViewVisible = value;
                OnProperyChanged(nameof(_isViewVisible));
            }
        }

        //->Commands
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }

        //Constructor
        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(p=>ExecuteRecoverPassCommand("",""));
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 ||
                Password == null || Password.Length < 3)
                validData = false;
            else 
                validData = true;
            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            throw new NotImplementedException();
        }
        private void ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }


    }
}
