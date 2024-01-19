namespace AbstractFactory.Factories;

public class ClassicFurnitureFactory : IFurnitureFactory
{
    public IFurniture CreateSofa()
    {
        return new Sofa()
        {
            Name = "Sofa",
            Type = EFurnitureType.Classic,
            Model = "Classic Soft AH"
        };
    }

    public IFurniture CreateTable()
    {
        return new Table()
        {
            Name = "Table",
            Type = EFurnitureType.Classic,
            Model = "Classic Soft AH"
        };
    }

    public IFurniture CreateChair()
    {
        return new Chair()
        {
            Name = "Chair",
            Type = EFurnitureType.Classic,
            Model = "Classic Soft AH"
        };
    }
}