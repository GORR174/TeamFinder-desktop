namespace TeamFinder.DTO.Response
{
    public class BaseResponseDto<T>
    {
        public BaseErrorResponse error { get; set; }
        public T response { get; set; }
        public string timestamp { get; set; }

        public override string ToString()
        {
            return $"{{ {nameof(error)}: {error}, {nameof(response)}: {response}, {nameof(timestamp)}: {timestamp} }}";
        }
    }
}