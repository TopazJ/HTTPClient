using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HTTPClient
{
    class GetProcessor
    {
        public static async Task<DataModelParent> loadData(int id, string apiURL)
        {
            string url = $"{apiURL}?id={id}";

            using (HttpResponseMessage response = await RestClient.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    DataModelParent data = await response.Content.ReadAsAsync<DataModelParent>();
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
