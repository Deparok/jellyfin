using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Jellyfin.Api.Controllers;

/// <summary>
/// Controller used to demonstrate the CodeQL CWE security gate.
/// </summary>
[ApiController]
[Route("api/cwe-test")]
public sealed class CweTestController : ControllerBase
{
    /// <summary>
    /// Starts a shell command supplied through the request query.
    /// This action is intentionally vulnerable and must only be used on an isolated test branch.
    /// </summary>
    /// <returns>An HTTP success response.</returns>
    [HttpGet]
    public IActionResult Run()
    {
        var command = HttpContext.Request.Query["command"].ToString();
        Process.Start("bash", "-c " + command);
        return Ok();
    }
}
