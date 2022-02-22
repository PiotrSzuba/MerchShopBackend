#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MerchShop.Data;
using MerchShop.Models;

namespace MerchShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericItemsController : ControllerBase
    {
        private readonly MerchShopContext _context;

        public GenericItemsController(MerchShopContext context)
        {
            _context = context;
        }

        // GET: api/GenericItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenericItem>>> GetGenericItem()
        {
            return await _context.GenericItem.ToListAsync();
        }

        // GET: api/GenericItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GenericItem>> GetGenericItem(int id)
        {
            var genericItem = await _context.GenericItem.FindAsync(id);

            if (genericItem == null)
            {
                return NotFound();
            }

            return genericItem;
        }

        // PUT: api/GenericItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenericItem(int id, GenericItem genericItem)
        {
            if (id != genericItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(genericItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenericItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GenericItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GenericItem>> PostGenericItem(GenericItem genericItem)
        {

            _context.GenericItem.Add(genericItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGenericItem", new { id = genericItem.Id }, genericItem);
        }

        // DELETE: api/GenericItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenericItem(int id)
        {
            var genericItem = await _context.GenericItem.FindAsync(id);
            if (genericItem == null)
            {
                return NotFound();
            }

            _context.GenericItem.Remove(genericItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GenericItemExists(int id)
        {
            return _context.GenericItem.Any(e => e.Id == id);
        }
    }
}
