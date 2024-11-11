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
    internal class OrderService : ServiceInterface<Order>
    {
        private readonly string ContextUrl = "pedido";
        private static OrderService? Instance;

        private OrderService() { }

        public static OrderService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new OrderService();
            }
            return Instance;
        }

        public async Task<List<Order>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(responseBody);

                return orders;
            }

            return null;
        }

        public async Task Update(Order order)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(order);
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
