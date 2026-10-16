
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tienda_online.api.Data;
using Tienda_online.api.Models;

namespace TiendaOnline.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MetodosPagoController : ControllerBase
    {
        private readonly Tienda_online_DbContext _context;

        public MetodosPagoController(Tienda_online_DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetodosPago>>> GetMetodosPago()
        {
            return await _context.MetodosPago.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<MetodosPago>> GetMetodoPago(int id)
        {
            var metodoPago = await _context.MetodosPago.FindAsync(id);

            if (metodoPago == null)
                return NotFound();

            return metodoPago;
        }

        [HttpPost]
        public async Task<ActionResult<MetodosPago>> PostMetodoPago(
            MetodosPago metodoPago)
        {
            _context.MetodosPago.Add(metodoPago);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetMetodoPago),
                new { id = metodoPago.IdMetodoPago },
                metodoPago
            );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMetodoPago(
            int id, MetodosPago metodoPago)
        {
            if (id != metodoPago.IdMetodoPago)
                return BadRequest();

            _context.Entry(metodoPago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _context.MetodosPago.AnyAsync(
                    m => m.IdMetodoPago == id))
                {
                    return NotFound();
                }

                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMetodoPago(int id)
        {
            var metodoPago = await _context.MetodosPago.FindAsync(id);

            if (metodoPago == null)
                return NotFound();

            _context.MetodosPago.Remove(metodoPago);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}