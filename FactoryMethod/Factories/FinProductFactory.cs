using FactoryMethod.Products;

namespace FactoryMethod.Factories;

public class FinProductFactory : ProductFactory
{
    public override FinProduct CreateProduct()
    {
        return new FinProduct();
    }
}