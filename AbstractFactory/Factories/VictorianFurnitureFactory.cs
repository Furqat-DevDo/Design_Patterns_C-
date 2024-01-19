namespace AbstractFactory.Factories;

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IFurniture CreateSofa()
    {
        return new Sofa()
        {
            Name = "Sofa",
            Type = EFurnitureType.Victorian,
            Model = "Queens Heart"
        };
    }

    public IFurniture CreateTable()
    {
        return new Table()
        {
            Name = "Table",
            Type = EFurnitureType.Victorian,
            Model = "Queens Heart"
        };
    }

    public IFurniture CreateChair()
    {
        return new Chair()
        {
            Name = "Chair",
            Type = EFurnitureType.Victorian,
            Model = "Queens Heart"
        };
    }
}