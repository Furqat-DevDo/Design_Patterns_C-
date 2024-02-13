namespace Bridge;

// Можно расширить Абстракцию без изменения классов Реализации.
public class ExtendAbstraction: Abstraction
{
    public ExtendAbstraction(IImplementation implementation) : base(implementation)
    {
    }
        
    public override string Operation()
    {
        return "ExtendedAbstraction: Extended operation with:\n" +
              _implementation.OperationImplementation();
    }
}