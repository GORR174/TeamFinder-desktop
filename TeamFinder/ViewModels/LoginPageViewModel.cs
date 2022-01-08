using TeamFinder.Repository;

namespace TeamFinder.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
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

        private bool _isSignedIn;
        public bool IsSignedIn
        {
            get => _isSignedIn;
            set
            {
                _isSignedIn = value;
                OnPropertyChanged();
            }
        }
        
        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }

        public LoginPageViewModel(IAuthRepository repository)
        {
            _authRepository = repository;
        }

        public BaseCommand LoginCommand
        {
            get => new BaseCommand(obj =>
            {
                IsLoading = true;

                _authRepository.Login(_username, _password, response =>
                {
                    IsLoading = false;
                    IsSignedIn = response.response != null;
                });
            });
        }
    }
}