namespace ProgramService.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using ProgramsService.Domain;
    using ProgramsService.Domain.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        public readonly IProgramsRepository _programsRepository;

        public ProgramsController(IProgramsRepository programsRepository)
        {
            _programsRepository = programsRepository;
        }

        // GET api/programs
        [HttpGet, Route("")]
        public IList<Programs> Get()
        {
            var programs = _programsRepository.GetAll().ToList();

            return programs;
        }
    }
}