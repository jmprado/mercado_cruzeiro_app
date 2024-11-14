﻿using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class TipoLojaService : ITipoLojaService
{
    private readonly ITipoLojaRepository _repository;
    private readonly IMapper _mapper;

    public TipoLojaService(ITipoLojaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TipoLojaDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<TipoLojaDTO>>(entities);
    }

    public async Task<TipoLojaDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<TipoLojaDTO>(entity);
    }

    public async Task AddAsync(TipoLojaDTO dto)
    {
        var entity = _mapper.Map<TipoLoja>(dto);
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(TipoLojaDTO dto)
    {
        var entity = _mapper.Map<TipoLoja>(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}