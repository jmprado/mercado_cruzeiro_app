using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class LojaService : ILojaService
{
    private readonly ILojaRepository _repository;
    private readonly IMapper _mapper;

    public LojaService(ILojaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<LojaDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<LojaDTO>>(entities);
    }

    public async Task<LojaDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<LojaDTO>(entity);
    }

    public async Task AddAsync(LojaDTO dto)
    {
        var entity = _mapper.Map<Loja>(dto);
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(LojaDTO dto)
    {
        var entity = _mapper.Map<Loja>(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}