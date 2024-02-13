namespace OddsOracle.Storage.Entities;

public class Role
{
    public string? Id { get; set; } = Guid.NewGuid().ToString("N");
    public string? Name { get; set; }
    public ICollection<UserRole>? UserRoles { get; set; }
}