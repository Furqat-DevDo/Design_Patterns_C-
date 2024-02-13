using Bridge;

internal class Program
{
    static void Main(string[] args)
    {
        var client = new Client();

        Abstraction abstraction;
        // Клиентский код должен работать с любой предварительно
        // сконфигурированной комбинацией абстракции и реализации.
        abstraction = new Abstraction(new ConcreteImplementationA());
        client.ClientCode(abstraction);
            
        Console.WriteLine();
            
        abstraction = new ExtendAbstraction(new ConcreteImplementationB());
        client.ClientCode(abstraction);
    }
}