using EFCore.Identity.Youtube.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Identity.Youtube.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class RoleController(RoleManager<AppRole> roleManager) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Create(string name, CancellationToken cancellationToken)
    {
        AppRole appRole = new()
        {
            Name = name,
        };

        IdentityResult result = await roleManager.CreateAsync(appRole);
        if (!result.Succeeded)
        {
            return BadRequest(result.Errors.Select(s => s.Description));
        }

        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {

        var roles = await roleManager.Roles.ToListAsync(cancellationToken);

        return Ok(roles);
    }

}
