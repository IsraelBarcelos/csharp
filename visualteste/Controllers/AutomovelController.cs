using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using visualteste.Models;

namespace visualteste.Controllers
{
    public class AutomovelController : Controller
    {
        private readonly AutomovelContexto _context;

        public AutomovelController(AutomovelContexto context)
        {
            _context = context;
        }

        // GET: Automovel
        public async Task<IActionResult> Index()
        {
            return View(await _context.Automoveis.ToListAsync());
        }

        // GET: Automovel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automovel = await _context.Automoveis
                .FirstOrDefaultAsync(m => m.id == id);
            if (automovel == null)
            {
                return NotFound();
            }

            return View(automovel);
        }

        // GET: Automovel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Automovel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,proprietario,data_lancamento,valor,numero_de_portas,avariacoes")] Automovel automovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(automovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(automovel);
        }

        // GET: Automovel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automovel = await _context.Automoveis.FindAsync(id);
            if (automovel == null)
            {
                return NotFound();
            }
            return View(automovel);
        }

        // POST: Automovel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,proprietario,data_lancamento,valor,numero_de_portas,avariacoes")] Automovel automovel)
        {
            if (id != automovel.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(automovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutomovelExists(automovel.id))
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
            return View(automovel);
        }

        // GET: Automovel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automovel = await _context.Automoveis
                .FirstOrDefaultAsync(m => m.id == id);
            if (automovel == null)
            {
                return NotFound();
            }

            return View(automovel);
        }

        // POST: Automovel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var automovel = await _context.Automoveis.FindAsync(id);
            _context.Automoveis.Remove(automovel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutomovelExists(int id)
        {
            return _context.Automoveis.Any(e => e.id == id);
        }
    }
}
