using fazenda_verdeviva.Model.Common;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.UserControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Services
{
    internal class AccessService
    {
        private static readonly string ContextUrl = "operador";

        public static async Task<bool> Login(string email, string password)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/entrar";

            var loginData = new
            {
                email = email,
                senha = password
            };

            string json = JsonConvert.SerializeObject(loginData);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Network.HttpClient.PostAsync(url, content);
            var responseBody = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var employee = JsonConvert.DeserializeObject<Employee>(responseBody);
                var dashboard = DashboardControl.GetInstance();
                dashboard.SaveUser(employee);

                return true;
            }

            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            MessageBox.Show($"Erro ao logar. Motivo: {responseData["Message"]}");
            return false;
        }

        public static async Task<bool> Register(string name, string email, string password)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/registrar";

            var registerData = new
            {
                nome = name,
                senha = password,
                contato = new 
                {
                    telefone = "",
                    email = email
                }
            };

            string json = JsonConvert.SerializeObject(registerData);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Network.HttpClient.PostAsync(url, content);
            var responseBody = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Funcíonario cadastrado com sucesso.");
                return true;
            }

            var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);

            MessageBox.Show($"Erro ao cadastrar funcionário. Motivo: {responseData["Message"]}");
            return false;
        }

        public static async Task ChangePassword(string email, string newPassword)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/alterar-senha";

            var changePasswordData = new
            {
                email = email,
                novaSenha = newPassword
            };

            string json = JsonConvert.SerializeObject(changePasswordData);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            await Network.HttpClient.PostAsync(url, content);
        }
    }
}
