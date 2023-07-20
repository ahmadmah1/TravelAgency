using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Models;

namespace TravelAgency.Controllers
{
    public class TicketInfoesController : Controller
    {
        private readonly TicketInfoDbContext _context;

        public TicketInfoesController(TicketInfoDbContext context)
        {
            _context = context;
        }

        // GET: TicketInfoes
        public async Task<IActionResult> Index()
        {
              return _context.TicketInfo != null ? 
                          View(await _context.TicketInfo.ToListAsync()) :
                          Problem("Entity set 'TicketInfoDbContext.TicketInfo'  is null.");
        }

        // GET: TicketInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TicketInfo == null)
            {
                return NotFound();
            }

            var ticketInfo = await _context.TicketInfo
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (ticketInfo == null)
            {
                return NotFound();
            }

            return View(ticketInfo);
        }

        // GET: TicketInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TicketInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketID,CustomerID,OrderID,SeatNo,TravelDate,Airline,Country,City,Arrival,Departure")] TicketInfo ticketInfo)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(ticketInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketInfo);
        }

        // GET: TicketInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TicketInfo == null)
            {
                return NotFound();
            }

            var ticketInfo = await _context.TicketInfo.FindAsync(id);
            if (ticketInfo == null)
            {
                return NotFound();
            }
            return View(ticketInfo);
        }

        // POST: TicketInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketID,CustomerID,OrderID,SeatNo,TravelDate,Airline,Country,City,Arrival,Departure")] TicketInfo ticketInfo)
        {
            if (id != ticketInfo.TicketID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticketInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketInfoExists(ticketInfo.TicketID))
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
            return View(ticketInfo);
        }

        // GET: TicketInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TicketInfo == null)
            {
                return NotFound();
            }

            var ticketInfo = await _context.TicketInfo
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (ticketInfo == null)
            {
                return NotFound();
            }

            return View(ticketInfo);
        }

        // POST: TicketInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TicketInfo == null)
            {
                return Problem("Entity set 'TicketInfoDbContext.TicketInfo'  is null.");
            }
            var ticketInfo = await _context.TicketInfo.FindAsync(id);
            if (ticketInfo != null)
            {
                _context.TicketInfo.Remove(ticketInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketInfoExists(int id)
        {
          return (_context.TicketInfo?.Any(e => e.TicketID == id)).GetValueOrDefault();
        }
    }
}
