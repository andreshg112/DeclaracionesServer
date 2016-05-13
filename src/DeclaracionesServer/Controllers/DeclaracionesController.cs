using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using DeclaracionesServer.Models;

namespace DeclaracionesServer.Controllers
{
    [Produces("application/json")]
    [Route("api/Declaraciones")]
    public class DeclaracionesController : Controller
    {
        private DeclaracionDbContext _context;

        public DeclaracionesController(DeclaracionDbContext context)
        {
            _context = context;
        }

        // GET: api/Declaraciones
        [HttpGet]
        public IEnumerable<Declaracion> GetDeclaraciones()
        {
            return _context.Declaraciones;
        }

        // GET: api/Declaraciones/5
        [HttpGet("{id}", Name = "GetDeclaracion")]
        public async Task<IActionResult> GetDeclaracion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            Declaracion declaracion = await _context.Declaraciones.SingleAsync(m => m.DeclaracionId == id);

            if (declaracion == null)
            {
                return HttpNotFound();
            }

            return Ok(declaracion);
        }

        // PUT: api/Declaraciones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeclaracion([FromRoute] int id, [FromBody] Declaracion declaracion)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            if (id != declaracion.DeclaracionId)
            {
                return HttpBadRequest();
            }

            _context.Entry(declaracion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeclaracionExists(id))
                {
                    return HttpNotFound();
                }
                else
                {
                    throw;
                }
            }

            return new HttpStatusCodeResult(StatusCodes.Status204NoContent);
        }

        // POST: api/Declaraciones
        [HttpPost]
        public async Task<IActionResult> PostDeclaracion([FromBody] Declaracion declaracion)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            _context.Declaraciones.Add(declaracion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DeclaracionExists(declaracion.DeclaracionId))
                {
                    return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetDeclaracion", new { id = declaracion.DeclaracionId }, declaracion);
        }

        // DELETE: api/Declaraciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeclaracion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            Declaracion declaracion = await _context.Declaraciones.SingleAsync(m => m.DeclaracionId == id);
            if (declaracion == null)
            {
                return HttpNotFound();
            }

            _context.Declaraciones.Remove(declaracion);
            await _context.SaveChangesAsync();

            return Ok(declaracion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DeclaracionExists(int id)
        {
            return _context.Declaraciones.Count(e => e.DeclaracionId == id) > 0;
        }
    }
}