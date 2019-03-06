using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HTTPClient
{
    class PostProcessor
    {
        public static async Task<DataModelResult> postData(string apiURL, DataModel data)
        {
            string url = apiURL;

            using (HttpResponseMessage response = await RestClient.APIClient.PostAsJsonAsync(url, data))
            {
                if (response.IsSuccessStatusCode)
                {
                    //return await response.Content.ReadAsStringAsync();
                    return await response.Content.ReadAsAsync<DataModelResult>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }


}
