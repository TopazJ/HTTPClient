using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HTTPClient
{
    class GetProcessor
    {
        public static async Task<DataModel> loadData(string apiURL, string id)
        {
            string url = $"{apiURL}/?id={id}";

            using (HttpResponseMessage response = await RestClient.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    DataModel data = await response.Content.ReadAsAsync<DataModel>();
                    return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            
        }
    }
}
