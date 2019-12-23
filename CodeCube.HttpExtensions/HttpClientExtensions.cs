using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodeCube.HttpExtensions
{
    public static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> DeleteWithBodyAsync(this HttpClient httpClient, Uri requestUri, StringContent requestContent)
        {
            var requestMessage = new HttpRequestMessage
            {
                    Method = HttpMethod.Delete,
                    Content = requestContent,
                    RequestUri = requestUri
            };

            return await httpClient.SendAsync(requestMessage).ConfigureAwait(false);
        }
    }
}
