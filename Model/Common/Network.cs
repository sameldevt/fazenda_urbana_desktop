using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.Model.Common
{
    public static class Network
    {
        //public static readonly string BaseUrl = "http://localhost:5085";
        public static readonly string BaseUrl = "http://52.54.99.249:8080";
        public static readonly HttpClient HttpClient = new HttpClient();
    }
}
    