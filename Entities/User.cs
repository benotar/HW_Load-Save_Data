using HL_26_12_2023.Abstractions;

namespace HL_26_12_2023.Entities;

public class User : Entity
{
    public string UserName { get; set; }
    public string? RealName { get; set; }
    public override string ToString() =>
        $"User {UserName} ({RealName ?? "N/A"})";
}
