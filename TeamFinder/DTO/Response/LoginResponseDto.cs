namespace TeamFinder.DTO.Response
{
    public class LoginResponseDto
    {
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
        public string tokenType { get; set; }
        public long accessTokenExpiryDur { get; set; }

        public override string ToString()
        {
            return $"{{ {nameof(accessToken)}: {accessToken}, {nameof(refreshToken)}: {refreshToken}, {nameof(tokenType)}: {tokenType}, {nameof(accessTokenExpiryDur)}: {accessTokenExpiryDur} }}";
        }
    }
}