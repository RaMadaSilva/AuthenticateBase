

using AuthApi.DTO;
using AuthApi.Models;
using AuthApi.Repository;
using AuthApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.Controllers;


[ApiController]
[Route("v1")]
public class LoginController : ControllerBase
{
    [HttpPost]
    [Route("login")]
    public async Task<ActionResult<dynamic>> LoginAsync([FromBody] UtilizadorDTO model)
    {
        var utl = UtilizadorRepository.GetUtilizador(model.UserName, model.Password);

        if (utl == null)
            return NotFound(new { message = "Utilizador ou senha incorrecta" });

        var token = TokenService.GenerateToken(utl);

        utl.Password = "*****";

        return new
        {
            nome = utl.UserName,
            password = utl.Password,
            token = token
        };

    }

}
