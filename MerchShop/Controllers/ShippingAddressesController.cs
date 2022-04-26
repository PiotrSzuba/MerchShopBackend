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
    public class ShippingAddressesController : ControllerBase
    {
        private readonly MerchShopContext _context;

        public ShippingAddressesController(MerchShopContext context)
        {
            _context = context;
        }

        // GET: api/ShippingAddresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShippingAddress>>> GetShippingAddress()
        {
            return await _context.ShippingAddress.ToListAsync();
        }

        // GET: api/ShippingAddresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShippingAddress>> GetShippingAddress(int id)
        {
            var shippingAddress = await _context.ShippingAddress.FindAsync(id);

            if (shippingAddress == null)
            {
                return NotFound();
            }

            return shippingAddress;
        }

        // PUT: api/ShippingAddresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShippingAddress(int id, ShippingAddress shippingAddress)
        {
            if (id != shippingAddress.ShippingAddressId)
            {
                return BadRequest();
            }

            _context.Entry(shippingAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShippingAddressExists(id))
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

        // POST: api/ShippingAddresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShippingAddress>> PostShippingAddress(ShippingAddress shippingAddress)
        {
            _context.ShippingAddress.Add(shippingAddress);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShippingAddress", new { id = shippingAddress.ShippingAddressId }, shippingAddress);
        }

        // DELETE: api/ShippingAddresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShippingAddress(int id)
        {
            var shippingAddress = await _context.ShippingAddress.FindAsync(id);
            if (shippingAddress == null)
            {
                return NotFound();
            }

            _context.ShippingAddress.Remove(shippingAddress);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShippingAddressExists(int id)
        {
            return _context.ShippingAddress.Any(e => e.ShippingAddressId == id);
        }
    }
}
