using Adapter;

internal class Program
{
    ///Применимость: Паттерн можно часто встретить в C#-коде,
    /// особенно там, где требуется конвертация разных типов данных или совместная работа классов с разными интерфейсами.
    /// Признаки применения паттерна: Адаптер получает конвертируемый объект в конструкторе или через параметры своих методов.
    /// Методы Адаптера обычно совместимы с интерфейсом одного объекта.
    /// Они делегируют вызовы вложенному объекту, превратив перед этим параметры вызова в формат, поддерживаемый вложенным объектом.
    public static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter.Adapter(adaptee);

        Console.WriteLine("Adaptee interface is incompatible with the client.");
        Console.WriteLine("But with adapter client can call it's method.");

        Console.WriteLine(target.GetRequest());
    }
}