using System.Collections.Generic;
using System.Threading.Tasks;
using aspdotnetblog.Controllers.Resources;
using aspdotnetblog.Persistence;
using aspdotnetblog.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspdotnetblog.Controllers.Resources
{
    public class FeaturesController: Controller
    {
         private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        [HttpGet("/api/features")]
        public async Task<IEnumerable<KeyValuePairResource>> GetMakes()
        {
            var features = await context.Features.ToListAsync();

            return mapper.Map<List<Feature>,List<KeyValuePairResource>>(features);
        }
    }
}