using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tomappto.Api.Dtos;
using Tomappto.Domain.Repositories;

namespace Tomappto.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TomatoesController : ControllerBase
    {
        private readonly ITomatoesRepository tomatoesRepository;

        public TomatoesController(ITomatoesRepository tomatoesRepository)
        {
            this.tomatoesRepository = tomatoesRepository;
        }


        [HttpGet]
        public IEnumerable<TomatoDto> GetTomatoes() 
        {

            return TomatoDto.ToDto(tomatoesRepository.GetTomatoes());
        }



    }
}
