using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Products.Models;

namespace Products.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase {
        private readonly ProductContext _context;

        public ProductsController(ProductContext context) {
            _context = context;
        }

        private static readonly string[] Supplyers = new[] {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static List<Product> Products = new List<Product>() {
            new Product {
                Id = 0,
                Name = "Zebra Scanner FX-195652",
                Description = "Scanning machine",
                AddedAt = DateTime.Now.AddDays(1),
                Supplyer = Supplyers[0],
                Barcode = "SN2E389KK6563"
            },
            new Product {
                Id = 1,
                Name = "Zebra Printer ZX-120",
                Description = "Printing machine",
                AddedAt = DateTime.Now.AddDays(6),
                Supplyer = Supplyers[2],
                Barcode = "SN2E389KK6563"
            }
        };

        //GET:      api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            //_context.ProductItems
            return Products;
        }

        //GET:      api/products/n
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            //Product product = _context.ProductItems.Find(id);
            //if (product == null) { return NotFound(); }
            //return product;

            return Products.Find(product => product.Id == id);
        }

        //POST:     api/products
        [HttpPost]
        public ActionResult<Product> PostProduct(Product product) {
            //_context.ProductItems.Add(product);
            //_context.SaveChanges();
            //return CreatedAtAction("GetProductItem", new Product { Id = product.Id }, product);
            product.Id = Products.Count;
            Products.Add(product);
            return product;
        }

        //PUT:      api/products/n
        [HttpPut("{id}")]
        public ActionResult<Product> PutProductItem(int id, Product newProduct) {
            //if (id != newProduct.Id) { return BadRequest(); }
            //_context.Entry(newProduct).State = EntityState.Modified;
            //_context.SaveChanges();
            try {
                Products[Products.FindIndex(product => product.Id == id)] = newProduct;
                return newProduct;
            } catch (Exception e) {
                return null;
            }
        }

        //DELETE:   api/products/n
        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProductItem(int id) {
            //Product product = _context.ProductItems.Find(id);
            //if (product == null)  { return NotFound(); }
            //_context.ProductItems.Remove(product);
            //_context.SaveChanges();
            //return product;
            try {
                Product productToRemove = Products.Single(product => product.Id == id);
                Products.Remove(productToRemove);
                return productToRemove;
            } catch (Exception e) {
                    return null;
            }
        }
    }
}
