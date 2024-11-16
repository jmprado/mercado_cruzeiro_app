using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repository;
    private readonly IMapper _mapper;

    public ClienteService(IClienteRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ClienteDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<ClienteDTO>>(entities);
    }

    public async Task<ClienteDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<ClienteDTO>(entity);
    }

    public async Task<ClienteDTO> AddAsync(ClienteDTO dto)
    {
        var entity = _mapper.Map<Cliente>(dto);
        var addedEntity = await _repository.AddAsync(entity);
        return _mapper.Map<ClienteDTO>(addedEntity);
    }

    public async Task<bool> UpdateAsync(ClienteDTO dto)
    {
        var entity = _mapper.Map<Cliente>(dto);
        return await _repository.UpdateAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}
