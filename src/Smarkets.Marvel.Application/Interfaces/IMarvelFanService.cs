using Smarkets.Marvel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarkets.Marvel.Application.Interfaces
{
    public interface IMarvelFanService
    {
        Task<IEnumerable<MarvelFan>> GetAllOrderedBySearchDateAsync();
    }
}
