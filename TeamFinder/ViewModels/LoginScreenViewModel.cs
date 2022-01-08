using System;
using System.Collections.Generic;
using System.Windows;
using Ninject.Activation;
using RestSharp;
using TeamFinder.DTO.Request;
using TeamFinder.DTO.Response;
using TeamFinder.Repository;
using DataFormat = RestSharp.DataFormat;

namespace TeamFinder.ViewModels
{
    public class LoginScreenViewModel : BaseViewModel
    {
        private IAuthRepository _authRepository;
        
        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }
        
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public LoginScreenViewModel(IAuthRepository repository)
        {
            _authRepository = repository;
        }

        public BaseCommand LoginCommand
        {
            get => new BaseCommand(obj =>
            {
                Console.WriteLine($"Clicked! Username: {_username}, Password: {_password}");

                _authRepository.Login(_username, _password, Console.WriteLine);
            });
        }
    }
}