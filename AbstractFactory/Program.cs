using AbstractFactory.Factories;


IFurnitureFactory factory;

Console.WriteLine("Choose the Type Of Furniture : \n 1 = Modern.\n 2 = Classic. \n 3 = Victorian.");

int.TryParse(Console.ReadLine(),out var type);

switch (type)
{
    case 1 :
        factory = new ModernFurnitureFactory();
        break;
    case 2:
        factory = new ClassicFurnitureFactory();
        break;
    case 3 :
        factory = new VictorianFurnitureFactory();
        break;
    default:
        factory = new ClassicFurnitureFactory();
        break;
}

var sofa = factory.CreateSofa();
var chair = factory.CreateChair();
var table = factory.CreateTable();

Console.WriteLine(sofa +"" +chair+""+ table);