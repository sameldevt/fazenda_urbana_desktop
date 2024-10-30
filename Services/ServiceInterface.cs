using fazenda_verdeviva.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Services
{
    internal interface ServiceInterface<T> where T : EntityInterface
    {
        Task<List<T>> GetAll();
    }
}
