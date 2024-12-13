using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlMigracion.Data;
using ControlMigracion.Models;

namespace ControlMigracion.Controllers
{
    public class ViajerosController : Controller
    {
        private readonly ControlMigracionContext _context;

        public ViajerosController(ControlMigracionContext context)
        {
            _context = context;
        }

        // GET: Viajeros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Viajeros.ToListAsync());
        }

        // GET: Viajeros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viajero = await _context.Viajeros
                .FirstOrDefaultAsync(m => m.ViajeroID == id);
            if (viajero == null)
            {
                return NotFound();
            }

            return View(viajero);
        }

        // GET: Viajeros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Viajeros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Apellido,Pasaporte,FechaNacimiento,Nacionalidad")] Viajero viajero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viajero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viajero);
        }

        // GET: Viajeros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viajero = await _context.Viajeros.FindAsync(id);
            if (viajero == null)
            {
                return NotFound();
            }
            return View(viajero);
        }

        // POST: Viajeros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ViajeroID,Nombre,Apellido,Pasaporte,FechaNacimiento,Nacionalidad")] Viajero viajero)
        {
            if (id != viajero.ViajeroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viajero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViajeroExists(viajero.ViajeroID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(viajero);
        }

        // GET: Viajeros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viajero = await _context.Viajeros
                .FirstOrDefaultAsync(m => m.ViajeroID == id);
            if (viajero == null)
            {
                return NotFound();
            }

            return View(viajero);
        }

        // POST: Viajeros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var viajero = await _context.Viajeros.FindAsync(id);
            _context.Viajeros.Remove(viajero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViajeroExists(int id)
        {
            return _context.Viajeros.Any(e => e.ViajeroID == id);
        }
    }
}

