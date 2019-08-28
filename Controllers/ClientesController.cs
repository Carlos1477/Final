using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabajoD.Models;


namespace ClientesController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private ProductosContext context;
        
        public ClientesController(ProductosContext dbContext)
        {
            context = dbContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return context.Clientes.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)
        {
         return context.Clientes.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Clientes([FromBody] Cliente value)
        {
            context.Clientes.Add(value);
            context.SaveChanges();
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente value)
        {
            var post = context.Clientes.Find(id);
            post.Nombre = value.Nombre;
            post.Apellido = value.Apellido;
            post.Username = value.Username;
            context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Clientes = context.Clientes.Find(id);
            context.Clientes.Remove(Clientes);
            context.SaveChanges();
        }
        
    }
        
}
