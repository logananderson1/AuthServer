namespace Auth.Domain.Models;

public class ClientScopes : Entity
{
    public string? Scope { get; set; } 
    public Clients? Client { get; set; }
}