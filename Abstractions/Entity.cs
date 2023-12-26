namespace HL_26_12_2023.Abstractions;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreateTime { get; set; } = DateTime.Now;
    public DateTime UpdateTime {  get; set; } = DateTime.Now;
}
