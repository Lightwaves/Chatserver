using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using MaterialDesignTest.Networking.Networking2.Packets;
using MaterialDesignTest.Networking.Networking2;
using System.Windows.Input;

namespace MaterialDesignTest.ViewModel
{
    public class LoginCardViewModel : ViewModelBase
    {
        private ICommand loginCommand;

        private bool canExecute = true;
        public static Func<string> PasswordHandler { get; set; }

        private string username;

        public ICommand LoginCommand 
        {
            get 
            {
                return loginCommand;
            }
            set 
            {
                loginCommand = value;
            }
        }

        public bool CanExecute 
        {
            get
            {
                return canExecute;
            }
            set
            {
                if (this.canExecute == value)
                {
                    return;

                }
                this.canExecute = value;
            }
        }

        public string UserName 
        {
            get { return username; }
            set { this.username = value; }
        }

        public void Login(object obj)
        {
            ClientSocket sock = new ClientSocket();
            sock.Connect("45.63.1.88", 1060);
            Thread.Sleep(100);
            MyMessage AuthRequest = new MyMessage(UserName + "\r\n" + PasswordHandler(), 10);
            sock.Send(AuthRequest.Data);
        }

        public LoginCardViewModel()
        {
            LoginCommand = new RelayCommand(Login, param => this.canExecute);
        }
    
    
    
    
    }
    


}
