using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id=1,Name="Цикорий",Category="Бакалея",Price=100},
            new Product {Id=2,Name="Чебурашка",Category="Игрушки",Price=150},
            new Product {Id=3,Name="Молоток",Category="Инструменты",Price=50},
        };
        public IEnumerable<Product> GetAllProducts() => products;
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
