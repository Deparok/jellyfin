using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/cwe-test")]
public sealed class CweTestController : ControllerBase
{
    [HttpGet]
    public IActionResult Run()
    {
        var command =
            HttpContext.Request.Query["command"].ToString();

        Process.Start("bash", "-c " + command);

        return Ok();
    }
}