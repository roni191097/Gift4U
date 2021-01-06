using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gift4U.Data;
using Gift4U.Models;

namespace Gift4U.Controllers
{
    public class StoreSalesController : Controller
    {
        private readonly Gift4UContext _context;

        public StoreSalesController(Gift4UContext context)
        {
            _context = context;
        }

        // GET: StoreSales
        public async Task<IActionResult> Index()
        {
            var gift4UContext = _context.StoreSale.Include(s => s.Sale).Include(s => s.Store);
            return View(await gift4UContext.ToListAsync());
        }

        // GET: StoreSales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeSale = await _context.StoreSale
                .Include(s => s.Sale)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.SaleId == id);
            if (storeSale == null)
            {
                return NotFound();
            }

            return View(storeSale);
        }

        // GET: StoreSales/Create
        public IActionResult Create()
        {
            ViewData["StoreID"] = new SelectList(_context.Set<Sale>(), "Id", "Name");
            ViewData["SaleId"] = new SelectList(_context.Stores, "Id", "Name");
            return View();
        }

        // POST: StoreSales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoreID,SaleId")] StoreSale storeSale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storeSale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StoreID"] = new SelectList(_context.Set<Sale>(), "Id", "Name", storeSale.StoreID);
            ViewData["SaleId"] = new SelectList(_context.Stores, "Id", "Name", storeSale.SaleId);
            return View(storeSale);
        }

        // GET: StoreSales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeSale = await _context.StoreSale.FindAsync(id);
            if (storeSale == null)
            {
                return NotFound();
            }
            ViewData["StoreID"] = new SelectList(_context.Set<Sale>(), "Id", "Name", storeSale.StoreID);
            ViewData["SaleId"] = new SelectList(_context.Stores, "Id", "Name", storeSale.SaleId);
            return View(storeSale);
        }

        // POST: StoreSales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StoreID,SaleId")] StoreSale storeSale)
        {
            if (id != storeSale.SaleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(storeSale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoreSaleExists(storeSale.SaleId))
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
            ViewData["StoreID"] = new SelectList(_context.Set<Sale>(), "Id", "Name", storeSale.StoreID);
            ViewData["SaleId"] = new SelectList(_context.Stores, "Id", "Name", storeSale.SaleId);
            return View(storeSale);
        }

        // GET: StoreSales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeSale = await _context.StoreSale
                .Include(s => s.Sale)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.SaleId == id);
            if (storeSale == null)
            {
                return NotFound();
            }

            return View(storeSale);
        }

        // POST: StoreSales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var storeSale = await _context.StoreSale.FindAsync(id);
            _context.StoreSale.Remove(storeSale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoreSaleExists(int id)
        {
            return _context.StoreSale.Any(e => e.SaleId == id);
        }
    }
}
