namespace FactoryMethod.Products;

public interface IProduct
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Dictionary<string, string> Names { get; set; }
}