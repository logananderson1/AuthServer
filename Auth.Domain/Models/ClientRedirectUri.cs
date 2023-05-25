namespace Auth.Domain.Models;

public class ClientRedirectUri : Entity
{
    public string RedirectUri { get; set; }
    public Clients Client { get; set; }
}