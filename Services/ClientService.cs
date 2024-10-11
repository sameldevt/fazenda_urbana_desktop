using fazenda_verdeviva.Model.Common;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Services
{
    internal class ClientService
    {
        private readonly string ContextUrl = "clientes";

        public async Task GelAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
        }

        public async Task GetById(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar/{id}";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
        }

        public async Task GetByEmail(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar/{id}";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
        }

        public async Task Update(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar/{id}";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
        }

        public async Task Register()
        {
 
        }

        public async Task Delete(int id)
        {
            
        }
    }
}
