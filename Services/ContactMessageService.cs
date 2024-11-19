using fazenda_verdeviva.Model.Common;
using fazenda_verdeviva.Model.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Services
{
    internal class ContactMessageService : ServiceInterface<ContactMessage>
    {
        private readonly string ContextUrl = "contato";
        private static ContactMessageService? Instance;

        private ContactMessageService() { }

        public static ContactMessageService GetInstance()
        {
            if(Instance == null)
            {
                Instance = new ContactMessageService();
            }
            return Instance;
        }

        public async Task<List<ContactMessage>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todas";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<ContactMessage> messages = JsonConvert.DeserializeObject<List<ContactMessage>>(responseBody);

                return messages;
            }

            return null;
        }


        public async Task Update(ContactMessage contactMessage)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(contactMessage);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            await Network.HttpClient.PutAsync(url, content);
        }

        public async Task Delete(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/remover/{id}";

            await Network.HttpClient.DeleteAsync(url);
        }
    }
}
