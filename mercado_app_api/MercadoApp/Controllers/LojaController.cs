using MercadoApp.DTOs;
using MercadoApp.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace MercadoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LojaController : ControllerBase
    {
        private readonly ILojaService _lojaService;

        public LojaController(ILojaService lojaService)
        {
            _lojaService = lojaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LojaDTO>>> GetAll()
        {
            var lojas = await _lojaService.GetAllAsync();
            return Ok(lojas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LojaDTO>> GetById(int id)
        {
            var loja = await _lojaService.GetByIdAsync(id);
            if (loja == null)
            {
                return NotFound();
            }
            return Ok(loja);
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] LojaDTO lojaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _lojaService.AddAsync(lojaDto);
            return CreatedAtAction(nameof(GetById), new { id = lojaDto.Id }, lojaDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] LojaDTO lojaDto)
        {
            if (id != lojaDto.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _lojaService.UpdateAsync(lojaDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var loja = await _lojaService.GetByIdAsync(id);
            if (loja == null)
            {
                return NotFound();
            }

            await _lojaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
