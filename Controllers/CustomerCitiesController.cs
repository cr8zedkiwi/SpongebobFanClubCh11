using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SongebobFanClub.Data;
using SongebobFanClub.Models;

namespace SongebobFanClub.Controllers
{
    public class CustomerCitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerCitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerCities
        public async Task<IActionResult> Index()
        {
              return _context.CustomerCity != null ? 
                          View(await _context.CustomerCity.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CustomerCity'  is null.");
        }

        // GET: CustomerCities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CustomerCity == null)
            {
                return NotFound();
            }

            var customerCity = await _context.CustomerCity
                .FirstOrDefaultAsync(m => m.CustomerCityId == id);
            if (customerCity == null)
            {
                return NotFound();
            }

            return View(customerCity);
        }

        // GET: CustomerCities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerCities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerCityId,City")] CustomerCity customerCity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerCity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerCity);
        }

        // GET: CustomerCities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CustomerCity == null)
            {
                return NotFound();
            }

            var customerCity = await _context.CustomerCity.FindAsync(id);
            if (customerCity == null)
            {
                return NotFound();
            }
            return View(customerCity);
        }

        // POST: CustomerCities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerCityId,City")] CustomerCity customerCity)
        {
            if (id != customerCity.CustomerCityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerCity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerCityExists(customerCity.CustomerCityId))
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
            return View(customerCity);
        }

        // GET: CustomerCities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CustomerCity == null)
            {
                return NotFound();
            }

            var customerCity = await _context.CustomerCity
                .FirstOrDefaultAsync(m => m.CustomerCityId == id);
            if (customerCity == null)
            {
                return NotFound();
            }

            return View(customerCity);
        }

        // POST: CustomerCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CustomerCity == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CustomerCity'  is null.");
            }
            var customerCity = await _context.CustomerCity.FindAsync(id);
            if (customerCity != null)
            {
                _context.CustomerCity.Remove(customerCity);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerCityExists(int id)
        {
          return (_context.CustomerCity?.Any(e => e.CustomerCityId == id)).GetValueOrDefault();
        }
    }
}
