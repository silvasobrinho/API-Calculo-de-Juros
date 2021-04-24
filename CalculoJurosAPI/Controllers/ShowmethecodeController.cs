using Microsoft.AspNetCore.Mvc;

namespace CalculoJurosAPI.Controllers
{
    public class ShowmethecodeController : Controller
    {
        [HttpGet("showmethecode")]
        public string ObtemLinkRepositorioGitHub()
        {
            return "https://github.com/silvasobrinho/API-Calculo-de-Juros";
        }
    }
}
