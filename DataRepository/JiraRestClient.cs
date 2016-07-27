using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.RestClients
{
    internal class JiraRestClient
    {
        string uri = string.Empty;

        public JiraRestClient(string Uri)
        {
            uri = Uri;
        }

        private async void ProcessRequest()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    throw new NotImplementedException();
                }
            }

        }
    }
}
