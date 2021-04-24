using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace CalculoJurosAPI.Controllers
{
    public class CalculaJurosController : Controller
    {


        [HttpGet("calculajuros")]
        [ProducesResponseType(typeof(IActionResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> ObterCalculoDeJuros([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            if (meses <= 0 || meses >= 13 || valorInicial < 0 || meses.Equals(null) || valorInicial.Equals(null))
                return BadRequest();


            return Ok(0);
        }
    }
}
