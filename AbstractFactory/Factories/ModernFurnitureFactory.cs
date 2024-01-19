namespace AbstractFactory.Factories;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IFurniture CreateSofa()
    {
        return new Sofa()
        {
            Name = "Sofa",
            Type = EFurnitureType.Modern,
            Model ="As123H"
        };
    }

    public IFurniture CreateTable()
    {
        return new Table()
        {
            Name = "Table",
            Type = EFurnitureType.Modern,
            Model = "As123H"
        };
    }

    public IFurniture CreateChair()
    {
        return new Chair()
        {
            Name = "Chair",
            Type = EFurnitureType.Modern,
            Model = "As123H"
        };
    }
}