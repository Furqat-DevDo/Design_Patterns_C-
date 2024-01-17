namespace FactoryMethod.Products;

public class Product : IProduct
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Dictionary<string, string> Names { get; set; } = new();
}