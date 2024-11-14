using MercadoApp.DTOs;
using MercadoApp.ViewModel;

namespace MercadoApp.Services.Abstraction;

public interface ILojaService : IService<LojaDTO>
{
    public Task<AuthenticationModel?> Authenticate(AuthenticationModel authenticationModel);
}
