namespace Builder;

// Имеет смысл использовать паттерн Строитель только тогда, когда ваши
// продукты достаточно сложны и требуют обширной конфигурации.
//
// В отличие от других порождающих паттернов, различные конкретные строители
// могут производить несвязанные продукты. Другими словами, результаты
// различных строителей  могут не всегда следовать одному и тому же
// интерфейсу.
public class Product
{
    private readonly List<object> _parts = new();
        
    public void Add(string part)
    {
        _parts.Add(part);
    }
        
    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "Product parts: " + str + "\n";
    }
}