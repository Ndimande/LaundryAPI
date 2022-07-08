namespace CleanArchitecture.Domain.Entities;

public class SignUp : AuditableEntity
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
