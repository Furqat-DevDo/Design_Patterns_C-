namespace AbstractFactory;

public class Sofa : IFurniture
{
    public string Name { get; set; }
    public string Model { get; set; }
    public EFurnitureType Type { get; set; }
    
    public override string ToString()
        => $"Name : {Name} ; Type : {Type.ToString()} ; Model : {Model} ;\n";
}