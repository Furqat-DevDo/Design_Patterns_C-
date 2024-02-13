using AbstractFactory.Factories;
using static System.Int32;


IFurnitureFactory factory;

Console.WriteLine("Choose the Type Of Furniture : \n 1 = Modern.\n 2 = Classic. \n 3 = Victorian.");

TryParse(Console.ReadLine(),out var type);

factory = type switch
{
    1 => new ModernFurnitureFactory(),
    2 => new ClassicFurnitureFactory(),
    3 => new VictorianFurnitureFactory(),
    _ => new ClassicFurnitureFactory()
};

var sofa = factory.CreateSofa();
var chair = factory.CreateChair();
var table = factory.CreateTable();

Console.WriteLine(sofa +"" +chair+""+ table);