﻿using fazenda_verdeviva.Model.Common;
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
        private static readonly string ContextUrl = "funcionario";

        public static async Task Login(string email, string password)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/login";

            var loginData = new
            {
                email = email,
                senha = password
            };

            string json = JsonConvert.SerializeObject(loginData);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            await Network.HttpClient.PostAsync(url, content);
        }

        public static async Task Register(string name, string email, string password)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/register";

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

            await Network.HttpClient.PostAsync(url, content);
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
