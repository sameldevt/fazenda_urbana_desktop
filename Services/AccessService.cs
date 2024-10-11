using fazenda_verdeviva.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Services
{
    internal class AccessService
    {
        private readonly string ContextUrl = "funcionario";

        public async Task Login(string email, string password)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/login";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
            }
        }
    }
}
