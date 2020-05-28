using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CodeCube.HttpExtensions
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// Send an asynchronous DELETE-request with a requestbody to the specified endpoint.
        /// </summary>
        /// <param name="httpClient">The HTTP-Client</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="requestContent">The content for the DELETE-request</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> DeleteWithBodyAsync(this HttpClient httpClient, string requestUri, StringContent requestContent)
        {
            return await DeleteWithBodyAsync(httpClient, new Uri(requestUri), requestContent, default);
        }

        /// <summary>
        /// Send an asynchronous DELETE-request with a requestbody to the specified endpoint.
        /// </summary>
        /// <param name="httpClient">The HTTP-Client</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="requestContent">The content for the DELETE-request</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> DeleteWithBodyAsync(this HttpClient httpClient, Uri requestUri, StringContent requestContent)
        {
            return await DeleteWithBodyAsync(httpClient, requestUri, requestContent, default);
        }

        /// <summary>
        /// Send an asynchronous DELETE-request with a requestbody to the specified endpoint.
        /// </summary>
        /// <param name="httpClient">The HTTP-Client</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="requestContent">The content for the DELETE-request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or thread to receive notification of cancellation.</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> DeleteWithBodyAsync(this HttpClient httpClient, string requestUri, StringContent requestContent, CancellationToken cancellationToken)
        {
            return await DeleteWithBodyAsync(httpClient, new Uri(requestUri), requestContent, cancellationToken);
        }

        /// <summary>
        /// Send an asynchronous DELETE-request with a requestbody to the specified endpoint.
        /// </summary>
        /// <param name="httpClient">The HTTP-Client</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="requestContent">The content for the DELETE-request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or thread to receive notification of cancellation.</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> DeleteWithBodyAsync(this HttpClient httpClient, Uri requestUri, StringContent requestContent, CancellationToken cancellationToken)
        {
            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                Content = requestContent,
                RequestUri = requestUri
            };

            return await httpClient.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);
        }
    }
}