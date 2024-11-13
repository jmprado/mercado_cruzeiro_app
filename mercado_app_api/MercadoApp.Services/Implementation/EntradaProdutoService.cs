using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class EntradaProdutoService : IEntradaProdutoService
{
    private readonly IEntradaProdutoRepository _repository;
    private readonly IMapper _mapper;

    public EntradaProdutoService(IEntradaProdutoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<EntradaProdutoDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<EntradaProdutoDTO>>(entities);
    }

    public async Task<EntradaProdutoDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<EntradaProdutoDTO>(entity);
    }

    public async Task AddAsync(EntradaProdutoDTO dto)
    {
        var entity = _mapper.Map<EntradaProduto>(dto);
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(EntradaProdutoDTO dto)
    {
        var entity = _mapper.Map<EntradaProduto>(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}