using FactoryMethod.Products;

namespace FactoryMethod.Factories;

public class DynamicProductFactory : ProductFactory
{
    public override DynamicProduct CreateProduct()
    {
        return new DynamicProduct();
    }
}