using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Entity;

namespace WebMVC_Practice.Areas.Practice_IV.Views
{
    [Area("Practice_IV")]
    public class ProductsController : Controller
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        // GET: Practice_IV/Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        // GET: Practice_IV/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Practice_IV/Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Practice_IV/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Descriptionn,Image,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.Image != null)
                {
                    string fileName = product.Image.FileName;

                    var filePath = Path.Combine(Environment.CurrentDirectory, @"wwwroot\Assets\img\products", fileName);
                    while (Directory.Exists(filePath))
                    {
                        fileName = Path.GetRandomFileName();
                        filePath = Path.Combine(Environment.CurrentDirectory, @"wwwroot\Assets\img\products", fileName);
                    }
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await product.Image.CopyToAsync(stream);
                    }
                    product.ImagePath = fileName;
                }

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Practice_IV/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Practice_IV/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Descriptionn,Image,Price")] Product product)
        {
            if (id != product.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                if (product.Image != null)
                {
                    product.ImagePath = _context.Products.AsQueryable().AsNoTracking().FirstOrDefault(p => p.ID == product.ID).ImagePath;

                    //if (product.ImagePath != null)
                    //{
                    //    System.IO.File.Delete(Path.Combine(Environment.CurrentDirectory, @"wwwroot\Assets\img\products", product.ImagePath));
                    //}
                    string fileName = product.Image.FileName;

                    var filePath = Path.Combine(Environment.CurrentDirectory, @"wwwroot\Assets\img\products", fileName);
                    
                    while (System.IO.File.Exists(filePath))
                    {
                        fileName = Guid.NewGuid() + "." + product.Image.FileName.Substring(product.Image.FileName.LastIndexOf('.'));
                        filePath = Path.Combine(Environment.CurrentDirectory, @"wwwroot\Assets\img\products", fileName);
                    }

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await product.Image.CopyToAsync(stream);
                    }
                    product.ImagePath = fileName;
                }
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
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
            return View(product);
        }

        // GET: Practice_IV/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Practice_IV/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
