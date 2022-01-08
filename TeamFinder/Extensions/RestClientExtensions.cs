using System.Threading.Tasks;
using RestSharp;
using TeamFinder.DTO.Response;

namespace TeamFinder.Extensions
{
    public static class RestClientExtensions
    {
        public static Task<RestResponse<BaseResponseDto<T>>> SendPostRequest<T>(this RestClient restClient, string url, object body) =>
            restClient.SendRequest<T>(url, Method.Post, body);
        
        public static async Task<RestResponse<BaseResponseDto<T>>> SendRequest<T>(this RestClient restClient, string url, Method method, object body)
        {
            var request = new RestRequest(url, method);
            request.AddOrUpdateHeader("Accept", "application/json");
            request.AddJsonBody(body);

            var response = await restClient.ExecutePostAsync<BaseResponseDto<T>>(request);

            return response;
        }
    }
}