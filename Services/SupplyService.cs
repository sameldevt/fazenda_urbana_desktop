using fazenda_verdeviva.Model.Common;
using fazenda_verdeviva.Model.Dto;
using fazenda_verdeviva.Model.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Services
{
    internal class SupplyService : ServiceInterface<Supply>
    {
        private readonly string ContextUrl = "insumo";
        private static SupplyService? Instance;

        private SupplyService() { }

        public static SupplyService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SupplyService();
            }
            return Instance;
        }

        public async Task<List<Supply>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Supply> supplies = JsonConvert.DeserializeObject<List<Supply>>(responseBody);

                return supplies;
            }

            return null;
        }

        public async Task<Supply> Update(Supply supply)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(supply);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PutAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    var updatedSupply = JsonConvert.DeserializeObject<Supply>(responseBody);
                    return updatedSupply;
                case HttpStatusCode.BadRequest:
                    MessageBox.Show($"{responseData["Message"]}");
                    return null;
                case HttpStatusCode.NotFound:
                    MessageBox.Show($"{responseData["Message"]}");
                    return null;
                default:
                    return null;
            }
        }

        public async Task Register(RegisterSupplyDto supply)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/cadastrar";

            string json = JsonConvert.SerializeObject(supply);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            switch (response.StatusCode)
            {
                case HttpStatusCode.Created:
                    MessageBox.Show("Insumo criado com sucesso.");
                    break;
                case HttpStatusCode.BadRequest:
                    MessageBox.Show($"{responseData["Message"]}");
                    break;
                case HttpStatusCode.NotFound:
                    MessageBox.Show($"{responseData["Message"]}");
                    break;
                default:
                    MessageBox.Show($"{responseData["Message"]}");
                    break;
            }
        }

        public async Task Delete(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/remover/{id}";

            var response = await Network.HttpClient.DeleteAsync(url);

            string responseBody = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    MessageBox.Show("Insumo deletado com sucesso.");
                    break;
                case HttpStatusCode.BadRequest:
                    MessageBox.Show($"{responseData["Message"]}");
                    break;
                case HttpStatusCode.NotFound:
                    MessageBox.Show($"{responseData["Message"]}");
                    break;
                default:
                    break;
            }
        }
    }
}
