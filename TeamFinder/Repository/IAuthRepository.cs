using System;
using TeamFinder.DTO.Response;

namespace TeamFinder.Repository
{
    public interface IAuthRepository
    {
        void Login(string username, string password, Action<BaseResponseDto<LoginResponseDto>> callback);
    }
}