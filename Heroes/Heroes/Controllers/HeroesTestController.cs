using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Heroes.Models;

namespace Heroes.Controllers
{
    public class HeroesTestController : Controller
    {
        private readonly HeroesContext _context;

        public HeroesTestController(HeroesContext context)
        {
            _context = context;
        }

        // GET: HeroesTest
        public async Task<IActionResult> Index()
        {
            var heroesContext = _context.Hero.Include(h => h.Planet);
            return View(await heroesContext.ToListAsync());
        }

        // GET: HeroesTest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Hero
                .Include(h => h.Planet)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            return View(hero);
        }

        // GET: HeroesTest/Create
        public IActionResult Create()
        {
            ViewData["PlanetId"] = new SelectList(_context.Planet, "Id", "Id");
            return View();
        }

        // POST: HeroesTest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PlanetId")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlanetId"] = new SelectList(_context.Planet, "Id", "Id", hero.PlanetId);
            return View(hero);
        }

        // GET: HeroesTest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Hero.FindAsync(id);
            if (hero == null)
            {
                return NotFound();
            }
            ViewData["PlanetId"] = new SelectList(_context.Planet, "Id", "Id", hero.PlanetId);
            return View(hero);
        }

        // POST: HeroesTest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PlanetId")] Hero hero)
        {
            if (id != hero.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeroExists(hero.Id))
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
            ViewData["PlanetId"] = new SelectList(_context.Planet, "Id", "Id", hero.PlanetId);
            return View(hero);
        }

        // GET: HeroesTest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Hero
                .Include(h => h.Planet)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            return View(hero);
        }

        // POST: HeroesTest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hero = await _context.Hero.FindAsync(id);
            _context.Hero.Remove(hero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeroExists(int id)
        {
            return _context.Hero.Any(e => e.Id == id);
        }
    }
}
