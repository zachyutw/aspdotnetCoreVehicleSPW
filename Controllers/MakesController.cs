using System.Collections.Generic;
using System.Threading.Tasks;
using aspdotnetblog.Models;
using aspdotnetblog.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspdotnetblog.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext context;
        public MakesController(VegaDbContext context)
        {
            this.context = context;

        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m=>m.Models).ToListAsync();
        }
    }
}