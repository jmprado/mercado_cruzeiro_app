using MercadoApp.DTOs;
using MercadoApp.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace MercadoApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClientesController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    // GET: api/Clientes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClienteDTO>>> GetClientes()
    {
        var clientes = await _clienteService.GetAllAsync();
        return Ok(clientes);
    }

    // GET: api/Clientes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ClienteDTO>> GetCliente(int id)
    {
        var cliente = await _clienteService.GetByIdAsync(id);

        if (cliente == null)
        {
            return NotFound();
        }

        return Ok(cliente);
    }

    // PUT: api/Clientes/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCliente(int id, ClienteDTO clienteDTO)
    {
        if (id != clienteDTO.Id)
        {
            return BadRequest();
        }

        var result = await _clienteService.UpdateAsync(clienteDTO);

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }

    // POST: api/Clientes
    [HttpPost]
    public async Task<ActionResult<ClienteDTO>> PostCliente(ClienteDTO clienteDTO)
    {
        var createdCliente = await _clienteService.AddAsync(clienteDTO);
        return CreatedAtAction(nameof(GetCliente), new { id = createdCliente.Id }, createdCliente);
    }

    // DELETE: api/Clientes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCliente(int id)
    {
        var result = await _clienteService.DeleteAsync(id);

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}
