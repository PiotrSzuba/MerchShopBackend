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
    public class ItemStatisticsController : ControllerBase
    {
        private readonly MerchShopContext _context;

        public ItemStatisticsController(MerchShopContext context)
        {
            _context = context;
        }

        // GET: api/ItemStatistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemStatistics>>> GetItemStatistics()
        {
            return await _context.ItemStatistics.ToListAsync();
        }

        // GET: api/ItemStatistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemStatistics>> GetItemStatistics(int id)
        {
            var itemStatistics = await _context.ItemStatistics.FindAsync(id);

            if (itemStatistics == null)
            {
                return NotFound();
            }

            return itemStatistics;
        }

        // PUT: api/ItemStatistics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemStatistics(int id, ItemStatistics itemStatistics)
        {
            if (id != itemStatistics.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemStatistics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemStatisticsExists(id))
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

        // POST: api/ItemStatistics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemStatistics>> PostItemStatistics(ItemStatistics itemStatistics)
        {
            _context.ItemStatistics.Add(itemStatistics);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemStatistics", new { id = itemStatistics.Id }, itemStatistics);
        }

        // DELETE: api/ItemStatistics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemStatistics(int id)
        {
            var itemStatistics = await _context.ItemStatistics.FindAsync(id);
            if (itemStatistics == null)
            {
                return NotFound();
            }

            _context.ItemStatistics.Remove(itemStatistics);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemStatisticsExists(int id)
        {
            return _context.ItemStatistics.Any(e => e.Id == id);
        }
    }
}
