using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rookies.BackEnd.Data;
using Rookies.BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rookies.ShareClassdLibrary;

namespace Rookies.BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult<ProductVM>> GetProduct(int id)
        {
            var product = await _context
                                .Product
                                .Where(x => x.Id == id)
                                .FirstOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            var productVM = new ProductVM
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CreatedDate = product.CreatedDate
            };

            return productVM;
        }
        //    [HttpGet]
        //    public async Task<IActionResult> GetProduct()
        //    {
        //        var product = await _context.Product.ToListAsync();

        //        return View(product);
        //    }
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        var productdetail = await _context.Product
        //            .FirstAsync(x => x.Id == id);

        //        if (productdetail == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(productdetail);
        //    }


        //    //[Authorize] Making code for admin
        //    public async Task<IActionResult> Create(Product product)
        //    {
        //        _context.Add(product);
        //        await _context.SaveChangesAsync();
        //        return View();
        //    }

        //    [HttpGet]
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var product = await _context.Product.FindAsync(id);
        //        if (product == null)
        //        {
        //            return NotFound();
        //        }
        //        ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "Id", "Name", product.CategoryId);
        //        return View(product);
        //    }

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, Product product)
        //    {
        //        if (id != product.Id)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(product);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!ProductExists(product.Id))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "Id", "Id", product.CategoryId);
        //        return View(product);
        //    }
        //    //[HttpGet]
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var product = await _context.Product
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (product == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(product);
        //    }

        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var product = await _context.Product.FindAsync(id);
        //        _context.Product.Remove(product);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool ProductExists(int id)
        //    {
        //        return _context.Product.Any(e => e.Id == id);
        //    }
    }
}
