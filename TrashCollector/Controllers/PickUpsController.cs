﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class PickUpsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PickUpsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PickUps
        public async Task<IActionResult> Index()
        {
            return View(await _context.PickUps.ToListAsync());
        }

        // GET: PickUps/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUp = await _context.PickUps
                .FirstOrDefaultAsync(m => m.PickUpDay == id);
            if (pickUp == null)
            {
                return NotFound();
            }

            return View(pickUp);
        }

        // GET: PickUps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PickUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PickUpDay,Start,End,IsPickUp")] PickUp pickUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pickUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pickUp);
        }

        // GET: PickUps/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUp = await _context.PickUps.FindAsync(id);
            if (pickUp == null)
            {
                return NotFound();
            }
            return View(pickUp);
        }

        // POST: PickUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PickUpDay,Start,End,IsPickUp")] PickUp pickUp)
        {
            if (id != pickUp.PickUpDay)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pickUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PickUpExists(pickUp.PickUpDay))
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
            return View(pickUp);
        }

        // GET: PickUps/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUp = await _context.PickUps
                .FirstOrDefaultAsync(m => m.PickUpDay == id);
            if (pickUp == null)
            {
                return NotFound();
            }

            return View(pickUp);
        }

        // POST: PickUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pickUp = await _context.PickUps.FindAsync(id);
            _context.PickUps.Remove(pickUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PickUpExists(string id)
        {
            return _context.PickUps.Any(e => e.PickUpDay == id);
        }
    }
}
