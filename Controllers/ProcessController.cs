using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _41505212__API.Models;

namespace _41505212__API.Controllers
{
    public class ProcesseController : Controller
    {
        private readonly NwutechTrendsContext _context;

        public ProcesseController(NwutechTrendsContext context)
        {
            _context = context;
        }

        // GET: Processe
        public async Task<IActionResult> Index()
        {
            return View(await _context.Processes.ToListAsync());
        }

        // GET: Processe/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var process = await _context.Processes
                .FirstOrDefaultAsync(m => m.ProcessId == id);
            if (process == null)
            {
                return NotFound();
            }

            return View(process);
        }

        // GET: Processe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Processe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProcessId,ProcessName,ProcessType,IsFramework,RequiresDefaultConfig,Submitter,DateSubmitted,ProcessConfigUrl,ReportUrl,ProjectId,DefaultGeography,DefaultBusinessFunction,Platform")] Process process)
        {
            if (ModelState.IsValid)
            {
                process.ProcessId = Guid.NewGuid();
                _context.Add(process);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(process);
        }

        // GET: Processe/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var process = await _context.Processes.FindAsync(id);
            if (process == null)
            {
                return NotFound();
            }
            return View(process);
        }

        // POST: Processe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProcessId,ProcessName,ProcessType,IsFramework,RequiresDefaultConfig,Submitter,DateSubmitted,ProcessConfigUrl,ReportUrl,ProjectId,DefaultGeography,DefaultBusinessFunction,Platform")] Process process)
        {
            if (id != process.ProcessId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(process);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcessExists(process.ProcessId))
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
            return View(process);
        }

        // GET: Processe/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var process = await _context.Processes
                .FirstOrDefaultAsync(m => m.ProcessId == id);
            if (process == null)
            {
                return NotFound();
            }

            return View(process);
        }

        // POST: Processe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var process = await _context.Processes.FindAsync(id);
            if (process != null)
            {
                _context.Processes.Remove(process);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcessExists(Guid id)
        {
            return _context.Processes.Any(e => e.ProcessId == id);
        }
    }
}
