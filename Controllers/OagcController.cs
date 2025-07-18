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

        [HttpGet("{id}")]
        public async Task<ActionResult<Oacp>> GetOacg(int id)
        {
            var oacp = await _context.Oacps.FindAsync(id);

            if (oacp == null)
            {
                return NotFound();
            }

            return oacp;
        }

        [HttpPost]
        public async Task<ActionResult<Oacp>> PostOacg(Oacp oacp)
        {
            _context.Oacps.Add(oacp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOacg", new { id = oacp.CntctCode }, oacp);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOacg(int id, Oacp oacp)
        {
            if (id != oacp.CntctCode)
            {
                return BadRequest();
            }

            _context.Entry(oacp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OacpExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool OacpExists(int id)
        {
            return _context.Oacps.Any(e => e.CntctCode == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOacg(int id)
        {
            var oacp = await _context.Oacps.FindAsync(id);
            if (oacp == null)
            {
                return NotFound();
            }

            _context.Oacps.Remove(oacp);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
