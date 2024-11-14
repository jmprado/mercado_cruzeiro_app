using MercadoApp.DTOs;
using MercadoApp.Services.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MercadoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TipoLojaController : Controller
    {
        private readonly ITipoLojaService _tipoLojaService;

        public TipoLojaController(ITipoLojaService tipoLojaService)
        {
            _tipoLojaService = tipoLojaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tipoLojas = await _tipoLojaService.GetAllAsync();
            return Ok(tipoLojas);
        }

        [HttpPost]
        public async Task<IActionResult> GetAll([FromBody] TipoLojaDTO tipoLojaDTO)
        {
            await _tipoLojaService.AddAsync(tipoLojaDTO);
            return Created();
        }
    }
}
