using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAPApi.Models;

namespace SAPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OagcController : ControllerBase
    {
        private readonly AbnRo20190130Context _context;
        public OagcController(AbnRo20190130Context context)
        {
            _context = context;    
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oacp>>> GetOacg()
        {
            return await _context.Oacps.ToListAsync();
        }
    }
}
