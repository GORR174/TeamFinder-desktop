using System;
using RestSharp;
using TeamFinder.DTO.Request;
using TeamFinder.DTO.Response;
using TeamFinder.Extensions;

namespace TeamFinder.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private RestClient _restClient;

        public AuthRepository(RestClient restClient)
        {
            _restClient = restClient;
        }
        
        public async void Login(string username, string password, Action<BaseResponseDto<LoginResponseDto>> callback)
        {
            var body = new LoginRequestDto
            {
                username = username,
                password = password,
                deviceInfo = new DeviceInfoDto()
                {
                    deviceId = "856386538",
                    deviceType = "DEVICE_TYPE_ANDROID"
                }
            };

            var response = await _restClient.SendPostRequest<LoginResponseDto>("auth/login", body);

            callback.Invoke(response.Data);
        }
    }
}