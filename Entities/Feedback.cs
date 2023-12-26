using HL_26_12_2023.Abstractions;

namespace HL_26_12_2023.Entities;

public class Feedback
{
    public Guid UserId { get; set; }
    public string Text { get; set; }
    public uint Rating { get; set; }
    public override string ToString()
    {
        return $"\'{Text}\' ({Rating}) | User id: {UserId}";
    }
}
