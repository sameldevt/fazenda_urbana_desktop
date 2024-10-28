﻿using fazenda_verdeviva.Model.Common;
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
    internal class SupplierService
    {
        private static readonly string ContextUrl = "fornecedores";

        public static async Task<List<Supplier>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/listar-todos";

            HttpResponseMessage response = await Network.HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                List<Supplier> suppliers = JsonConvert.DeserializeObject<List<Supplier>>(responseBody);

                return suppliers;
            }

            return null;
        }

        public static async Task Update(Supplier supplier)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            string json = JsonConvert.SerializeObject(supplier);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            await Network.HttpClient.PutAsync(url, content);
        }

        public static async Task Register(RegisterSupplierDto supplier)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/cadastrar";

            string json = JsonConvert.SerializeObject(supplier);
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