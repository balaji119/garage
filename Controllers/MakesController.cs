using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using garage.Controllers.Resources;
using garage.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace garage.Controllers
{
    public class MakesController : Controller
    {
        private readonly garageDbContext context;
        private readonly IMapper mapper;
        public MakesController(garageDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes =  await context.Makes.Include(m=> m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}