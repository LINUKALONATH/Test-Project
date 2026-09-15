namespace MyProject.API.Models;

public sealed class User
{
    public int Id { get; init; }
    public string Email { get; init; } = string.Empty;
    public string DisplayName { get; init; } = string.Empty;
}
