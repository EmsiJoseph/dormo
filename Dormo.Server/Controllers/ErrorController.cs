using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Dormo.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ErrorController : ControllerBase
{
    [HttpGet("")]
    public IActionResult HandleError()
    {
        var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
        var exception = context?.Error;
        var code = 500;


        return Problem(detail: exception?.Message, statusCode: code);
    }
}