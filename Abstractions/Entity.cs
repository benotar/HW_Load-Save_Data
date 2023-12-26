namespace HL_26_12_2023.Abstractions;

public abstract class Entity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime CreateTime { get; init; } = DateTime.Now;
    public DateTime UpdateTime {  get; set; } = DateTime.Now;
}
