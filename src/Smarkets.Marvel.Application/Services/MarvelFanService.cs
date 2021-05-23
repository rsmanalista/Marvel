using Smarkets.Marvel.Application.Interfaces;
using Smarkets.Marvel.Domain.Entities;
using Smarkets.Marvel.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarkets.Marvel.Application.Services
{
    public class MarvelFanService : IMarvelFanService
    {
        private readonly IMarvelFanRepository marvelFanRepository;
        private readonly IUnitOfWork unitOfWork;

        public MarvelFanService(IMarvelFanRepository marvelFanRepository,
                                IUnitOfWork unitOfWork)
        {
            this.marvelFanRepository = marvelFanRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<MarvelFan>> GetAllOrderedBySearchDateAsync()
        {
            return await marvelFanRepository.GetAllOrderedBySearchNameAsync();
        }

        
    }
}
