namespace Bridge;

// Каждая Конкретная Реализация соответствует определённой платформе и
// реализует интерфейс Реализации с использованием API этой платформы.

public class ConcreteImplementationA :IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform A.\n";
    }
}