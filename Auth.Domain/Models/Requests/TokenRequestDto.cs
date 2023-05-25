namespace Auth.Domain.Models.Requests;

public record TokenRequestDto(string ClientId, string Secret, string Grant_type, string Scopes);