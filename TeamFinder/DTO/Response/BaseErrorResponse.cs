namespace TeamFinder.DTO.Response
{
    public class BaseErrorResponse
    {
        public string message { get; set; }
        public string cause { get; set; }
        public string path { get; set; }
        public int code { get; set; }

        public override string ToString()
        {
            return $"{{ {nameof(message)}: {message}, {nameof(cause)}: {cause}, {nameof(path)}: {path}, {nameof(code)}: {code} }}";
        }
    }
}