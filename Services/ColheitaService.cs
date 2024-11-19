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
    internal class ColheitaService : ServiceInterface<Harvest>
    {
        private readonly string ContextUrl = "colheita";
        private static ColheitaService? Instance;

        private ColheitaService() { }

        public static ColheitaService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ColheitaService();
            }
            return Instance;
        }

        public async Task<Harvest> GetById(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar/{id}";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                var harvest = JsonConvert.DeserializeObject<Harvest>(responseBody);

                return harvest;
            }

            return null;
        }

        public async Task<List<Harvest>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Harvest> harvests = JsonConvert.DeserializeObject<List<Harvest>>(responseBody);

                return harvests;
            }

            return null;
        }

        public async Task<Harvest> Update(Harvest harvest)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(harvest);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PutAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    var updatedCrop = JsonConvert.DeserializeObject<Harvest>(responseBody);
                    return updatedCrop;
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

        public async Task Register(RegisterHarvestDto harvest)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/cadastrar";

            string json = JsonConvert.SerializeObject(harvest);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            switch (response.StatusCode)
            {
                case HttpStatusCode.Created:
                    MessageBox.Show("Colheita criada com sucesso.");
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
                    MessageBox.Show("Colheita deletada com sucesso.");
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
