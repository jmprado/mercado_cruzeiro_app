using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Services.Abstraction;

namespace MercadoApp.Services.Implementation;

public class ImagemProdutoService : IImagemProdutoService
{
    private readonly IImagemProdutoRepository _repository;
    private readonly IMapper _mapper;

    public ImagemProdutoService(IImagemProdutoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ImagemProdutoDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<ImagemProdutoDTO>>(entities);
    }

    public async Task<ImagemProdutoDTO> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return _mapper.Map<ImagemProdutoDTO>(entity);
    }

    public async Task<ImagemProdutoDTO> AddAsync(ImagemProdutoDTO dto)
    {
        var entity = _mapper.Map<ImagemProduto>(dto);
        var addedEntity = await _repository.AddAsync(entity);
        return _mapper.Map<ImagemProdutoDTO>(addedEntity);
    }

    public async Task<bool> UpdateAsync(ImagemProdutoDTO dto)
    {
        var entity = _mapper.Map<ImagemProduto>(dto);
        return await _repository.UpdateAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}

