using System;
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
        public async Task<IActionResult> IndexAsync()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            return View( await _context.PickUps.Where(c => c.customer == thiscusomter).ToListAsync());
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
                .FirstOrDefaultAsync(m => m.PickUpId == id&& m.customer == thiscusomter);
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
        public async Task<IActionResult> Create([Bind("PickUpId,PickUpDay,IsPickUp,Balance,Suspend,StartDate,EndDate,Id")] PickUp pickUp)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            pickUp = _context.PickUps.Where(p => p.customer == thiscusomter).FirstOrDefault();
            if (ModelState.IsValid)
            {
                _context.Add(pickUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexAsync));
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
            var pickUp = await _context.PickUps.Where(c => c.Id == id && c.customer == thiscusomter).FirstAsync();
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
        public async Task<IActionResult> Edit(int id, [Bind("PickUpId,PickUpDay,IsPickUp,Balance,Suspend,StartDate,EndDate,Id")] PickUp pickUp)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            pickUp = _context.PickUps.Where(p => p.customer == thiscusomter).FirstOrDefault();
            if (id != pickUp.PickUpId)
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
                    if (!PickUpExists(pickUp.PickUpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexAsync));
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
                .FirstOrDefaultAsync(m => m.PickUpId == id && m.customer == thiscusomter);
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
        {   var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var pickUp = await _context.PickUps.Where(p => p.PickUpId == id && p.customer == thiscusomter).FirstAsync();
            _context.PickUps.Remove(pickUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAsync));
        }

        private bool PickUpExists(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thiscusomter = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            return _context.PickUps.Any(e => e.PickUpId == id && e.customer == thiscusomter);
        }


    }
}
