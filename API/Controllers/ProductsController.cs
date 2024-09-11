using Microsoft.AspNetCore.Mvc;
using Core.Entities;
using Core.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IGenericRepository<Product> Repo) : ControllerBase
    {
        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts()
        {
            return Ok(await Repo.ListAllAsync());
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await Repo.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            if (!ProductExists(id))
            {
                return NotFound();
            }

            Repo.Update(product);

            if (await Repo.SaveAllAsync())
            {
                return NoContent();
            }
            return BadRequest("Problem updating the product");
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            Repo.Add(product);
            if (await Repo.SaveAllAsync())
            {
                return CreatedAtAction("GetProduct", new { id = product.Id }, product);
            }
            return BadRequest("Problem creating the product");
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await Repo.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            Repo.Delete(product);
            if (await Repo.SaveAllAsync())
            {
                return NoContent();
            }

            return BadRequest("Problem Deleting the product");
        }

        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<string>>> GetBrands()
        {
            return Ok();
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<string>>> GetTypes()
        {
            return Ok();
        }

        private bool ProductExists(int id)
        {
            return Repo.Exists(id);
        }
    }
}
