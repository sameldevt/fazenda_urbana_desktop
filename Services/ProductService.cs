using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fazenda_verdeviva.Model.Common;
using fazenda_verdeviva.Model.Dto;
using fazenda_verdeviva.Model.Entities;
using Newtonsoft.Json;

namespace fazenda_verdeviva.Services
{
    internal class ProductService : ServiceInterface<Product>
    {
        private readonly string ContextUrl = "produtos";
        private static ProductService? Instance;

        private ProductService() { }

        public static ProductService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ProductService();
            }
            return Instance;
        }

        public async Task<List<Product>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(responseBody);

                return products;
            }

            return null;
        }

        public async Task<Product> GetById(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar/{id}";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                Product product = JsonConvert.DeserializeObject<Product>(responseBody);

                return product;
            }

            return null;
        }

        public async Task<string> Update(Product product)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(product);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PutAsync(url, content);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> Register(RegisterProductDto product)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/cadastrar";

            string json = JsonConvert.SerializeObject(product);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PostAsync(url, content);


            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> Delete(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/remover/{id}";

            var response = await Network.HttpClient.DeleteAsync(url);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
