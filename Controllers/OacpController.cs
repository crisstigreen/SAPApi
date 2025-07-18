using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAPApi.Models;

namespace SAPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OacpController : ControllerBase
    {
        private readonly AbnRo20190130Context _context;
        public OacpController(AbnRo20190130Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oacg>>> GetOacg()
        {
            return await _context.Oacgs.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Oacg>> GetOacg(int id)
        {
            var oacg = await _context.Oacgs.FindAsync(id);

            if (oacg == null)
            {
                return NotFound();
            }

            return oacg;
        }

        [HttpPost]
        public async Task<ActionResult<Oacg>> PostOacg(Oacg oacg)
        {
            _context.Oacgs.Add(oacg);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOacg", new { id = oacg.AbsId }, oacg);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOacg(int id, Oacg oacg)
        {
            if (id != oacg.AbsId)
            {
                return BadRequest();
            }

            _context.Entry(oacg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OacgExists(id))
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

        private bool OacgExists(int id)
        {
            return _context.Oacgs.Any(e => e.AbsId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOacg(int id)
        {
            var oacg = await _context.Oacgs.FindAsync(id);
            if (oacg == null)
            {
                return NotFound();
            }

            _context.Oacgs.Remove(oacg);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
