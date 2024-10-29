using fazenda_verdeviva.Model.Common;
using fazenda_verdeviva.Model.Dto;
using fazenda_verdeviva.Model.Entities;
using Newtonsoft.Json;
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
        private static readonly string ContextUrl = "cliente";

        public static async Task<List<Client>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(responseBody);

                return clients;
            }

            return null;
        }


        public static async Task<string> Update(Client client)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(client);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PutAsync(url, content);

            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> Delete(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/remover/{id}";

            var response = await Network.HttpClient.DeleteAsync(url);

            return await response.Content.ReadAsStringAsync();

        }
    }
}
