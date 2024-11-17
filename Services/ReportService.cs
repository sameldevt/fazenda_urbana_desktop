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
    internal class ReportService : ServiceInterface<Report>
    {
        private readonly string ContextUrl = "relatorio";
        private static ReportService Instance;
    
        private ReportService() { }

        public static ReportService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ReportService();
            }
            return Instance;
        }
        public async Task<List<Report>> GetAll()
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar-todos";

            return null;
        }

        public async Task<Report> GetById(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/buscar/{id}";

            return null;
        }

        public async Task<string> Update(UpdateProductDto product)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/atualizar";

            return null;
        }

        public async Task<string> Register(RegisterProductDto product)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/cadastrar";

            return null;
        }

        public async Task<string> Delete(int id)
        {
            string url = $"{Network.BaseUrl}/{ContextUrl}/remover/{id}";


            return null;
        }
    }
}
