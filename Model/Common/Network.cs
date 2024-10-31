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
        public static readonly string BaseUrl = "http://3.21.97.78:8080/verdeviva";
        public static readonly HttpClient HttpClient = new HttpClient();
    }
}
