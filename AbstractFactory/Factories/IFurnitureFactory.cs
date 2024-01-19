namespace AbstractFactory.Factories;

public interface IFurnitureFactory
{
    public IFurniture CreateSofa();
    public IFurniture CreateTable();
    public IFurniture CreateChair();
}