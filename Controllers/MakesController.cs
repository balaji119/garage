using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using garage.Models;
using garage.Models.Resources;
using garage.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace garage.Controllers
{
    public class MakesController : ControllerBase
    {
        private readonly GarageDbContext context;
        private readonly IMapper mapper;
        public MakesController(GarageDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet("api/makes")]
        public IEnumerable<MakeResource> GetMakes()
        {
            var makes = context.Makes.Include(m => m.Models).ToList();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}