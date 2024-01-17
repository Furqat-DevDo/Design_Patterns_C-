namespace FactoryMethod.Products;

public class FinProduct : IProduct
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }
    public Dictionary<string, string> Names { get; set; } = new();
    public long FinOrgId { get; set; }
}