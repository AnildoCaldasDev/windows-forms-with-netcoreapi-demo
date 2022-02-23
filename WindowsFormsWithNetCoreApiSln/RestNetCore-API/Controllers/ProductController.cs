using Microsoft.AspNetCore.Mvc;
using RestNetCore_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestNetCore_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Alicate", Category = "Tools", Price = 100 },
            new Product { Id = 2, Name = "Mesa Retangular", Category = "Office", Price = 356.75M },
            new Product { Id = 3, Name = "Martelo", Category = "Hardware", Price = 169.99M }
        };

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>>  Get()
        {
            return products.ToList();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>>  Get(int id)
        {
            return products.Where(p => p.Id == id).FirstOrDefault();
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult<Product>> Post([FromBody] Product product)
        {
            //validação pra forççar badrequest
            if (!ModelState.IsValid || product == null || string.IsNullOrWhiteSpace(product.Name))
                return BadRequest("Objeto do Produto é inválido");

            var filterList = products.ToList();
            int maxId = filterList.Max(x => x.Id);
            product.Id = maxId + 1;
            filterList.Add(product);

            products = filterList.ToArray();
            var productAdded = products.Where(p => p.Id == product.Id).FirstOrDefault();

            return CreatedAtAction(nameof(Post), new { Name = product.Name }, productAdded);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Put(int id, [FromBody] Product product)
        {
            //validação pra forççar badrequest
            if (!ModelState.IsValid || product == null || string.IsNullOrWhiteSpace(product.Name) || id != product.Id)
                return BadRequest("Objeto do Produto é inválido");

            var filterList = products.ToList();

            var productUpdate = filterList.FirstOrDefault(x => x.Id == id);

            filterList.Remove(productUpdate);
            filterList.Add(product);

            products = filterList.ToArray();
            var productAdded = products.Where(p => p.Id == product.Id).FirstOrDefault();

            return CreatedAtAction(nameof(Put), new { Name = product.Name }, productAdded);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = products.Where(p => p.Id == id).FirstOrDefault();
            if(product == null)
            {
                return NotFound();
            }

            var filterList = products.ToList();

            filterList.Remove(product);

            products = filterList.ToArray();

            return Ok(new { success= true, message= "Excluído com sucesso!" });
        }
    }
}
