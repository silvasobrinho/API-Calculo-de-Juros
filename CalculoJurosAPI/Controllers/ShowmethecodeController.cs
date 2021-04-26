using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CalculoJurosAPI.Controllers
{
    [ApiController]
    public class ShowmethecodeController : Controller
    {
        private readonly IConfiguration _configuration;
        public ShowmethecodeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Link para o codigo no GitHub - Show me the code
        /// </summary>
        /// <param name="Show me the code"></param>
        /// <returns>Retorna <see cref="string"/></returns>
        /// <response code="200">Retorna o Link do repositorio no Github</response>
        /// <response code="400">Formato de envio invalido</response>
        /// <response code="401">Não autorizado</response>
        /// <response code="403">Não permitido</response>
        /// <response code="404">Não foi encontrado</response>
        /// <response code="500">Erro de acesso ao servidor</response>
        [HttpGet("showmethecode")]
        public ActionResult ObtemLinkRepositorioGitHub()
        {
            var teste = _configuration.GetValue<string>("Endpoints:UrlGithub");
            return Ok(_configuration.GetValue<string>("Endpoints:UrlGithub"));
        }
    }
}
