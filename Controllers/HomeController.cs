using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AuthApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace AuthApi.Controllers;

[ApiController]
[Route("V1")]
public class HomeController : ControllerBase
{
    [HttpGet]
    [Route("Anominous")]
    [AllowAnonymous]
    public string Anomino()
        => ("Anominous");

    [HttpGet]
    [Route("Admin")]
    [Authorize(Roles = "admin")]
    public string AutorizadoAdmin()
     => ("Admin autorizado");

    [HttpGet]
    [Route("gerente")]
    [Authorize(Roles = "admin, funcionaria")]
    public string Gerente()
        => "Gerente";
}
