using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class UnidadeProdutoService : IUnidadeProdutoService
{
    private readonly IUnidadeProdutoRepository _repository;
    private readonly IMapper _mapper;

    public UnidadeProdutoService(IUnidadeProdutoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UnidadeProdutoDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<UnidadeProdutoDTO>>(entities);
    }

    public async Task<UnidadeProdutoDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<UnidadeProdutoDTO>(entity);
    }

    public async Task<UnidadeProdutoDTO> AddAsync(UnidadeProdutoDTO dto)
    {
        var entity = _mapper.Map<UnidadeProduto>(dto);
        var addedEntity = await _repository.AddAsync(entity);
        return _mapper.Map<UnidadeProdutoDTO>(addedEntity);
    }

    public async Task<bool> UpdateAsync(UnidadeProdutoDTO dto)
    {
        var entity = _mapper.Map<UnidadeProduto>(dto);
        return await _repository.UpdateAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}

