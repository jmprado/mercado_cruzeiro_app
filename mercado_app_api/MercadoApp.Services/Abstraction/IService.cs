namespace MercadoApp.Services.Abstraction;

public interface IService<TDto> where TDto : class
{
    Task<IEnumerable<TDto>> GetAllAsync();
    Task<TDto> GetByIdAsync(int id);
    Task<TDto> AddAsync(TDto dto);
    Task<bool> UpdateAsync(TDto dto);
    Task<bool> DeleteAsync(int id);
}

