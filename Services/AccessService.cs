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
    internal class AccessService
    {
        private static readonly string ContextUrl = "operador";

        public static async Task<Employee> Login(string email, string password)
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

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                MessageBox.Show(responseBody);
                var employee = JsonConvert.DeserializeObject<Employee>(responseBody);

                return employee;
            }

            return null;
        }

        public static async Task<string> Register(string name, string email, string password)
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

            MessageBox.Show(await response.Content.ReadAsStringAsync());

            return responseBody;
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
