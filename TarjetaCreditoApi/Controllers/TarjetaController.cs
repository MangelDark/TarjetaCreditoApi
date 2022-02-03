using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarjetaCreditoApi.DTO;
using TarjetaCreditoApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TarjetaCreditoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public TarjetaController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: api/<TarjetaController>
        [HttpGet]
        public async Task<ActionResult<List<TarjetaCredito>>>  Get()
        {
            try
            {
                return Ok(await context.tarjetaCreditos.ToListAsync());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // GET api/<TarjetaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TarjetaCredito>>  Get(int id)
        {
            try
            {
                var tajerta = await context.tarjetaCreditos.FirstAsync(x => x.Id == id);
                return Ok(tajerta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST api/<TarjetaController>
        [HttpPost]
        public async Task<ActionResult<TarjetaCredito>> Post([FromBody] TarjetaCredito request)
        {
            try
            {
                //var tarjeta = new TarjetaCredito
                //{
                //    titular = request.titular,
                //    numeroTarjeta = request.numeroTarjeta,
                //    fechaExpiracion = request.fechaExpiracion,
                //    cvv = request.cvv  
                //};
                await context.AddAsync(request);
                await context.SaveChangesAsync();

                return Ok("La tarjeta  fue creada correctamente!");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

          
        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
