using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class PedidoProdutoService : IPedidoProdutoService
{
    private readonly IPedidoProdutoRepository _repository;
    private readonly IMapper _mapper;

    public PedidoProdutoService(IPedidoProdutoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PedidoProdutoDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<PedidoProdutoDTO>>(entities);
    }

    public async Task<PedidoProdutoDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<PedidoProdutoDTO>(entity);
    }

    public async Task<PedidoProdutoDTO> AddAsync(PedidoProdutoDTO dto)
    {
        var entity = _mapper.Map<PedidoProduto>(dto);
        var addedEntity = await _repository.AddAsync(entity);
        return _mapper.Map<PedidoProdutoDTO>(addedEntity);
    }

    public async Task<bool> UpdateAsync(PedidoProdutoDTO dto)
    {
        var entity = _mapper.Map<PedidoProduto>(dto);
        return await _repository.UpdateAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}
