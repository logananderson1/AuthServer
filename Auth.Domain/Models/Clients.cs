namespace Auth.Domain.Models;

public class Clients : Entity
{
    public string ClientId { get; set; }
    public string ClientName { get; set; }
    public bool RequireConsent { get; set; }
    public int TokenTimeout { get; set; } = 3600;

}