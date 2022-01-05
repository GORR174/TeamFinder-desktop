using System;
using System.Windows;

namespace TeamFinder.ViewModels
{
    public class LoginScreenViewModel : BaseViewModel
    {
        private string _loginText;
        public string LoginText
        {
            get => _loginText;
            set
            {
                _loginText = value;
                OnPropertyChanged();
            }
        }

        public BaseCommand LoginCommand
        {
            get => new BaseCommand(obj => { LoginText = "123"; Console.WriteLine("Clicked!"); });
        }
    }
}