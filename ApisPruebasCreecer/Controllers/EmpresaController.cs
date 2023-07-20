using ApisPruebasCreecer.Contexts;
using ApisPruebasCreecer.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApisPruebasCreecer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly ConexionSqlServer context;
        public EmpresaController(ConexionSqlServer context)
        {
            this.context = context;
        }

        // GET: api/<EmpresaController>
        [HttpGet]
        public IEnumerable<Empresa> Get()
        {
            return context.Empresa.ToArray();
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpresaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
