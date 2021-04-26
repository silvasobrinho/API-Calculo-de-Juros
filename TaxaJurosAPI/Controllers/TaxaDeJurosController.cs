using Microsoft.AspNetCore.Mvc;
using TaxaJurosAPI.Models;

namespace TaxaJurosAPI.Controllers
{

    [ApiController]
    public class TaxaDeJurosController : ControllerBase
    {

        /// <summary>
        /// Taxa de Juros
        /// </summary>
        /// <param name="Taxa de Juros"></param>
        /// <returns>Retorna <see cref="decimal"/></returns>
        /// <response code="200">Retorna o valor da taxa de juros</response>
        /// <response code="400">Formato de envio invalido</response>
        /// <response code="401">Não autorizado</response>
        /// <response code="403">Não permitido</response>
        /// <response code="404">Não foi encontrado</response>
        /// <response code="500">Erro de acesso ao servidor</response>
        [HttpGet("taxaJuros")]
        public ActionResult ObterTaxaDeJuros()
        {
            return Ok(new TaxaJuros().valor);
        }
    }
}
