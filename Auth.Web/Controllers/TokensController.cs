using Auth.Domain.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Web.Controllers;

[AllowAnonymous]
[Route("/connect")]
public class TokensController : ControllerBase
{
    private readonly ILogger<TokensController> _logger;

    public TokensController(ILogger<TokensController> logger)
    {
        _logger = logger;
    }

    [HttpPost("token")]
    public IActionResult GenerateToken([FromBody] TokenRequestDto requestDto)
    {
        return Ok();
    }    
}