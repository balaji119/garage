using System.Collections.Generic;
using garage.Models;
using garage.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace garage.Controllers
{
    public class MakesController : ControllerBase
    {
        private readonly GarageDbContext context;
        public MakesController(GarageDbContext context)
        {
            this.context = context;

        }

        [HttpGet("api/makes")]
        public IEnumerable<Make> GetMakes()
        {
            return context.Makes;
        }

    }
}