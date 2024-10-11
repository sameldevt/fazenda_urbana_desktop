using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Common
{
    public static class Network
    {
        public static readonly string BaseUrl = "http://18.191.183.78:8080/verdeviva";
        public static readonly HttpClient HttpClient = new HttpClient();
    }
}
