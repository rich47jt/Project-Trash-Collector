﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            return View(_context.PickUps.Where(p =>p.CustomerId == thiscusomter.Id));
        }

        // GET: PickUps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var pickUp = await _context.PickUps
                .Where(p => p.CustomerId == thiscusomter.Id)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pickUp == null)
            {
                return NotFound();
            }

            return View(pickUp);
        }

        // GET: PickUps/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
            return View();
        }

        // POST: PickUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PickUpDay,Balance,Suspend,StartTime,EndDate,CustomerId")] PickUp pickUp)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            pickUp.CustomerId = thiscusomter.Id;
            if (ModelState.IsValid)
            {
                _context.Add(pickUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pickUp);
        }

        // GET: PickUps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            id = thiscusomter.Id;
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,PickUpDay,Balance,Suspend,StartTime,EndDate,CustomerId")] PickUp pickUp)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            pickUp.CustomerId = thiscusomter.Id;
            if (id != pickUp.Id)
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
                    if (!PickUpExists(pickUp.Id))
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var pickUp = await _context.PickUps
                .Where(p => p.CustomerId == thiscusomter.Id)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pickUp == null)
            {
                return NotFound();
            }

            return View(pickUp);
        }

        // POST: PickUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pickUp = await _context.PickUps.FindAsync(id);
            _context.PickUps.Remove(pickUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PickUpExists(int id)
        {
            return _context.PickUps.Any(e => e.Id == id);
        }
    }
}
