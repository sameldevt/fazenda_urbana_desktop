using fazenda_verdeviva.Model.Common;
using fazenda_verdeviva.Model.Dto;
using fazenda_verdeviva.Model.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Services
{
    internal class EmployeeService
    {
        private static readonly string ContextUrl = "funcionario";

        public static async Task<List<Employee>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(responseBody);

                return employees;
            }

            return null;
        }

        public static async Task Update(Employee employee)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(employee);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            await Network.HttpClient.PutAsync(url, content);
        }

        public static async Task Register(RegisterEmployeeDto employee)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/cadastrar";

            string json = JsonConvert.SerializeObject(employee);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            await Network.HttpClient.PostAsync(url, content);
        }

        public static async Task Delete(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/remover/{id}";

            await Network.HttpClient.DeleteAsync(url);
        }
    }
}
