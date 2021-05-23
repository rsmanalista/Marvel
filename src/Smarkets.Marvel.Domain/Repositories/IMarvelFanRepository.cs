using Smarkets.Marvel.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smarkets.Marvel.Domain.Repositories
{
	public interface IMarvelFanRepository : IReadRepository<MarvelFan>, 
                                                IWriteRepository<MarvelFan>
    {
        Task<IEnumerable<MarvelFan>> GetAllOrderedBySearchNameAsync();
    }
}