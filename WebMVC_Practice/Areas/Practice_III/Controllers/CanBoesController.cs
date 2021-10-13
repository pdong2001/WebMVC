using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;

namespace WebMVC_Practice.Areas.Practice_III.Controllers
{
    [Area("Practice_III")]
    public class CanBoesController : Controller
    {
        private readonly DataContext _context;

        public CanBoesController(DataContext context)
        {
            _context = context;
        }

        // GET: Practice_III/CanBoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CanBos.ToListAsync());
        }

        // GET: Practice_III/CanBoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canBo = await _context.CanBos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (canBo == null)
            {
                return NotFound();
            }

            return View(canBo);
        }

        // GET: Practice_III/CanBoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Practice_III/CanBoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Address,PhoneNumber,Image")] CanBo canBo)
        {
            if (ModelState.IsValid)
            {
                if (canBo.Image != null)
                {
                    var filePath = Path.Combine(Environment.CurrentDirectory, @"wwwroot\Assets\img\avatars", canBo.Image.FileName);
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await canBo.Image.CopyToAsync(stream);
                    }
                    canBo.ImageSrc = canBo.Image.FileName ;
                }

                _context.Add(canBo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(canBo);
        }

        // GET: Practice_III/CanBoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canBo = await _context.CanBos.FindAsync(id);
            if (canBo == null)
            {
                return NotFound();
            }
            return View(canBo);
        }

        // POST: Practice_III/CanBoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Address,PhoneNumber,Image")] CanBo canBo)
        {
            if (id != canBo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (canBo.Image != null)
                {
                    var filePath = Path.Combine(Environment.CurrentDirectory, @"wwwroot\Assets\img\avatars", canBo.Image.FileName);
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await canBo.Image.CopyToAsync(stream);
                    }
                    canBo.ImageSrc = canBo.Image.FileName;
                }
                try
                {
                    _context.Update(canBo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CanBoExists(canBo.ID))
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
            return View(canBo);
        }

        // GET: Practice_III/CanBoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canBo = await _context.CanBos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (canBo == null)
            {
                return NotFound();
            }

            return View(canBo);
        }

        // POST: Practice_III/CanBoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var canBo = await _context.CanBos.FindAsync(id);
            _context.CanBos.Remove(canBo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CanBoExists(int id)
        {
            return _context.CanBos.Any(e => e.ID == id);
        }
    }
}
