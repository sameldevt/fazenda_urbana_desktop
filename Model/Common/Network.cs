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
        public static readonly string BaseUrl = "http://18.233.63.60:8080";
        public static readonly HttpClient HttpClient = new HttpClient();
    }
}
    