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
    internal class CultureService : ServiceInterface<Culture>
    {
        private readonly string ContextUrl = "cultura";
        private static CultureService? Instance;

        private CultureService() { }

        public static CultureService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CultureService();
            }
            return Instance;
        }

        public async Task<Culture> GetById(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar/{id}";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                Culture culture = JsonConvert.DeserializeObject<Culture>(responseBody);

                return culture;
            }

            return null;
        }

        public async Task<List<Culture>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Culture> cultures = JsonConvert.DeserializeObject<List<Culture>>(responseBody);

                return cultures;
            }

            return null;
        }

        public async Task<Culture> Update(Culture culture)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(culture);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PutAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    var updatedCulture = JsonConvert.DeserializeObject<Culture>(responseBody);
                    return updatedCulture;
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

        public async Task Register(RegisterCultureDto culture)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/cadastrar";

            string json = JsonConvert.SerializeObject(culture);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            switch (response.StatusCode)
            {
                case HttpStatusCode.Created:
                    MessageBox.Show("Cultura criada com sucesso.");
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
                    MessageBox.Show("Cultura deletada com sucesso.");
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
