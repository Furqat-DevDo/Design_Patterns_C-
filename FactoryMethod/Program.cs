using FactoryMethod.Factories;

ProductFactory factory = new DynamicProductFactory();

var dynamicProduct = factory.CreateProduct();

Console.WriteLine(dynamicProduct.GetType());

factory = new FinProductFactory();

var finProduct = factory.CreateProduct();

Console.WriteLine(finProduct.GetType());