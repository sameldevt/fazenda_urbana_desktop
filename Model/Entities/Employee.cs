﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Entities
{
    public class Employee : User
    {
        [JsonProperty("cargo")]
        public string Position { get; set; }

        [JsonProperty("numeroRegistro")]
        public string RegistrationNumber { get; set; }
    }
}