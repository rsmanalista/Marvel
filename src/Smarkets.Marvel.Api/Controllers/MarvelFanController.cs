using Microsoft.AspNetCore.Mvc;
using Smarkets.Marvel.Domain.Entities;
using Smarkets.Marvel.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Smarkets.Marvel.Application.Services;
using Smarkets.Marvel.Application.ViewModels;
using Smarkets.Marvel.Application.Interfaces;

namespace Smarkets.Marvel.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class MarvelFanController : Controller
    {

        private readonly IMapper mapper;
        private readonly IMarvelFanService marvelFanService;


        public MarvelFanController(
            IMapper mapper,
            IMarvelFanService marvelFanService)
        {
            this.mapper = mapper;
            this.marvelFanService = marvelFanService;
        }

        [HttpGet]
        public async Task<IActionResult> SearchCharacterAsync()
        {
            var characters = await this.marvelFanService.GetAllOrderedBySearchDateAsync();
            var result = this.mapper.Map<IEnumerable<MarvelFanViewModel>>(characters.ToList());

            return Json(result);
        }

        

        }
}
