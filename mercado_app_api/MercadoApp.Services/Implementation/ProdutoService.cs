using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repository;
    private readonly IMapper _mapper;

    public ProdutoService(IProdutoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProdutoDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<ProdutoDTO>>(entities);
    }

    public async Task<ProdutoDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<ProdutoDTO>(entity);
    }

    public async Task<ProdutoDTO> AddAsync(ProdutoDTO dto)
    {
        var entity = _mapper.Map<Produto>(dto);
        var addedEntity = await _repository.AddAsync(entity);
        return _mapper.Map<ProdutoDTO>(addedEntity);
    }

    public async Task<bool> UpdateAsync(ProdutoDTO dto)
    {
        var entity = _mapper.Map<Produto>(dto);
        return await _repository.UpdateAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProdutoDTO>> GetByIdLojaAsync(int idLoja)
    {
        return _mapper.Map<IEnumerable<ProdutoDTO>>(await _repository.GetByIdLojaAsync(idLoja));
    }
}

