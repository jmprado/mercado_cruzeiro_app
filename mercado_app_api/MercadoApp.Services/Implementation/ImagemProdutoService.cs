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

    public async Task AddAsync(ImagemProdutoDTO dto)
    {
        var entity = _mapper.Map<ImagemProduto>(dto);
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(ImagemProdutoDTO dto)
    {
        var entity = _mapper.Map<ImagemProduto>(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}
