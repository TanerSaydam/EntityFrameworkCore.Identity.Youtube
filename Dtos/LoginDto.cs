namespace EFCore.Identity.Youtube.Dtos;

public sealed record LoginDto(
    string UserNameOrEmail,
    string Password);
