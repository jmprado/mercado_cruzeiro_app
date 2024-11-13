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

    public async Task AddAsync(PedidoProdutoDTO dto)
    {
        var entity = _mapper.Map<PedidoProduto>(dto);
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(PedidoProdutoDTO dto)
    {
        var entity = _mapper.Map<PedidoProduto>(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}
