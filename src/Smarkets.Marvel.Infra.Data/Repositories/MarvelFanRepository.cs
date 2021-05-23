using Smarkets.Marvel.Domain.Entities;
using Smarkets.Marvel.Domain.Repositories;
using Smarkets.Marvel.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smarkets.Marvel.Infra.Data.Repositories
{
	public class MarvelFanRepository : BaseRepository<MarvelFan>, IMarvelFanRepository
	{
		public MarvelFanRepository(MarvelFanContext context)
			: base(context)
		{ }

		public Task<IEnumerable<MarvelFan>> GetAllOrderedBySearchNameAsync()
		{
			return Task.FromResult(DbSet.AsQueryable().OrderByDescending(x => x.Name).AsEnumerable());
		}
	}
}