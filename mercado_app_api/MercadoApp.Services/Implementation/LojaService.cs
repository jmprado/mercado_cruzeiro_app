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

    public async Task<LojaDTO> AddAsync(LojaDTO dto)
    {
        var entity = _mapper.Map<Loja>(dto);
        var addedEntity = await _repository.AddAsync(entity);
        return _mapper.Map<LojaDTO>(addedEntity);

    }

    public async Task<bool> UpdateAsync(LojaDTO dto)
    {
        var entity = _mapper.Map<Loja>(dto);
        return await _repository.UpdateAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}