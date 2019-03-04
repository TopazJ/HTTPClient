using System.Net.Http;
using System.Net.Http.Headers;

namespace HTTPClient
{
    public static class RestClient
    {

        public static HttpClient APIClient { get; set; }

        public static void InitializeClient()
        {
            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}
