namespace CleanArchitecture.Domain.Entities;

public class Login : AuditableEntity
{
    public string? Email { get; set; }

    public string? Password { get; set; }
}
