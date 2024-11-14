using MercadoApp.Security;
using MercadoApp.Services.Abstraction;
using MercadoApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ILojaService _lojaService;
    private readonly JwtSettings _jwtSettings;

    public AuthController(ILojaService lojaService, IOptions<JwtSettings> options)
    {
        _lojaService = lojaService;
        _jwtSettings = options.Value;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] AuthenticationModel authenticationModel)
    {
        var authResponse = await _lojaService.Authenticate(authenticationModel);
        if (authResponse == null)
        {
            return Unauthorized();
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_jwtSettings.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(
            [
                new Claim(ClaimTypes.Email, authResponse.Email)
            ]),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            Issuer = _jwtSettings.Issuer,
            Audience = _jwtSettings.Audience
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var tokenString = tokenHandler.WriteToken(token);

        return Ok(new { Token = tokenString });
    }
}
