using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabajoD.Models;


namespace TrabajoD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ProductosContext context;
        public ValuesController(ProductosContext dbContext)
        {
            context = dbContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Productos>> Get()
        {
            return context.Productos.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Productos> Get(int id)
        {
            return context.Productos.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Producto([FromBody] Productos value)
        {            
            context.Productos.Add(value);
            context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Productos value)
        {
            var Product = context.Productos.Find(id);
            if (Product != null)
            {
            Product.ProductoId = value.ProductoId;
            Product.Titulo = value.Titulo;
            Product.Titulo = value.Titulo;
            Product.Descripcion = value.Descripcion;
            context.SaveChanges();    
            }
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Product = context.Productos.Find(id);
            if (Product != null)
            {
            context.Productos.Remove(Product);
            context.SaveChanges();        
            }      
        }
    }
}
