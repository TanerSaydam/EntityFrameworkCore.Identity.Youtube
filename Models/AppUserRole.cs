using Microsoft.AspNetCore.Identity;

namespace EFCore.Identity.Youtube.Models;

public sealed class AppUserRole
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
}
