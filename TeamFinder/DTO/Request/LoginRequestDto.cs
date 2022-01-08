namespace TeamFinder.DTO.Request
{
    public class LoginRequestDto
    {
        public string username { get; set; }
        public string password { get; set; }
        public DeviceInfoDto deviceInfo { get; set; }
    }
}