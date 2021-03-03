using Caliburn.Micro;
using RetailDesktopUI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _username = "";
        private string _password = "";

        private IAPIHelper _apiHelper;

        private LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyOfPropertyChange(() => Username);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn
        {
            get
            {
                bool output = false;
                if(Username.Length > 0 && Password.Length > 0)
                {
                    output = true;
                }
                return output;
            }

        }

        public Task LogIn(string username, string password)
        {
            var result = _apiHelper.Authenticate(Username, Password);
        }
    }
}
