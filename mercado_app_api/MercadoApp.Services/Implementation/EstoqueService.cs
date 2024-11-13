using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class EstoqueService : IEstoqueService
{
    private readonly IEstoqueRepository _repository;
    private readonly IMapper _mapper;

    public EstoqueService(IEstoqueRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<EstoqueDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<EstoqueDTO>>(entities);
    }

    public async Task<EstoqueDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<EstoqueDTO>(entity);
    }

    public async Task AddAsync(EstoqueDTO dto)
    {
        var entity = _mapper.Map<Estoque>(dto);
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(EstoqueDTO dto)
    {
        var entity = _mapper.Map<Estoque>(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}