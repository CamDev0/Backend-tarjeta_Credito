using FBCreditCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FBCreditCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly AplicationDBContext _context;
        
        //Constructor e inyectamos el contexto
        public CardController(AplicationDBContext context) 
        {
            _context = context;
        }

        // GET: api/<CardController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                //Como es un metodo async le ponemos el await pa que espere los datos
                var listCard = await _context.creditCard.ToListAsync();
                //Retornamos un status 200, con el listado de tarjetas
                return Ok(listCard);
            }
            catch (Exception e)
            {
                //return error 400
                return BadRequest(e.Message);
            }
        }


        // POST api/<CardController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreditCard card)
        {
            try
            {
                _context.Add(card);
                await _context.SaveChangesAsync();
                return Ok(card);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<CardController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CreditCard card)
        {
            try
            {
                //Si no encuentra el id ingresado en los id registrados retornamos un 404.
                if(id != card.id)
                {
                    return NotFound();
                }
                //Sino actualizamos, guardamos y retornamos un 200.
                _context.Update(card);
                await _context.SaveChangesAsync();
                return Ok(new { message = "La tarjeta fué actualizada con éxito" });

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // DELETE api/<CardController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                //Validamos si el id se traído se encuentra en nuestros registros.
                var card = await _context.creditCard.FindAsync(id);

                if (card == null)
                {
                    return NotFound();
                }

                _context.creditCard.Remove(card);
                await _context.SaveChangesAsync();
                return Ok(new {message = "La tarjeta fué eliminada con éxito"});
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
