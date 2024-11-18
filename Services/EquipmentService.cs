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
    internal class EquipmentService : ServiceInterface<Equipment>
    {
        private readonly string ContextUrl = "equipamento";
        private static EquipmentService? Instance;

        private EquipmentService() { }

        public static EquipmentService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EquipmentService();
            }
            return Instance;
        }

        public async Task<List<Equipment>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Equipment> equipments = JsonConvert.DeserializeObject<List<Equipment>>(responseBody);

                return equipments;
            }

            return null;
        }

        public async Task<Equipment> Update(Equipment equipment)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(equipment);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PutAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    var updatedEquipment = JsonConvert.DeserializeObject<Equipment>(responseBody);
                    return updatedEquipment;
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

        public async Task Register(RegisterEquipmentDto equipment)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/cadastrar";

            string json = JsonConvert.SerializeObject(equipment);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            switch (response.StatusCode)
            {
                case HttpStatusCode.Created:
                    MessageBox.Show("Equipamento criado com sucesso.");
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
                    MessageBox.Show("Equipamento deletado com sucesso.");
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
