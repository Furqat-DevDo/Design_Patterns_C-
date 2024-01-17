using FactoryMethod.Products;

namespace FactoryMethod.Factories;

public  abstract class ProductFactory
{
    public virtual IProduct CreateProduct()
    {
        return  new Product();
    }
}