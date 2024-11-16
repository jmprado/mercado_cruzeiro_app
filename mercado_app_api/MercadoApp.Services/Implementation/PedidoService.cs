using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class PedidoService : IPedidoService
{
    private readonly IPedidoRepository _repository;
    private readonly IMapper _mapper;

    public PedidoService(IPedidoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PedidoDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<PedidoDTO>>(entities);
    }

    public async Task<PedidoDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<PedidoDTO>(entity);
    }

    public async Task<PedidoDTO> AddAsync(PedidoDTO dto)
    {
        var entity = _mapper.Map<Pedido>(dto);
        var addedEntity = await _repository.AddAsync(entity);
        return _mapper.Map<PedidoDTO>(addedEntity);
    }

    public async Task<bool> UpdateAsync(PedidoDTO dto)
    {
        var entity = _mapper.Map<Pedido>(dto);
        return await _repository.UpdateAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}
