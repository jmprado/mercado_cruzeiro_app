using MercadoApp.Services.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MercadoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("{idLoja}")]
        public async Task<IActionResult> GetByIdLojaAsync([FromRoute] int idLoja)
        {
            return Ok(await _produtoService.GetByIdLojaAsync(idLoja));
        }
    }
}
