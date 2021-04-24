using Microsoft.AspNetCore.Mvc;
using TaxaJurosAPI.Models;

namespace TaxaJurosAPI.Controllers
{

    [ApiController]
    public class TaxaDeJurosController : ControllerBase
    {
        [HttpGet("taxaJuros")]
        public decimal ObterTaxaDeJuros()
        {
            return new TaxaJuros().valor;
        }
    }
}
