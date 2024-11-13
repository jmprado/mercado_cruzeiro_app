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

    public async Task AddAsync(UnidadeProdutoDTO dto)
    {
        var entity = _mapper.Map<UnidadeProduto>(dto);
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(UnidadeProdutoDTO dto)
    {
        var entity = _mapper.Map<UnidadeProduto>(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}
