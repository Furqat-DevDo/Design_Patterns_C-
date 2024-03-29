﻿namespace Builder;

// Директор отвечает только за выполнение шагов построения в определённой
// последовательности. Это полезно при производстве продуктов в определённом
// порядке или особой конфигурации. Строго говоря, класс Директор
// необязателен, так как клиент может напрямую управлять строителями.
public class Director
{
    private IBuilder _builder;
        
    public IBuilder Builder
    {
        set { _builder = value; } 
    }
        
    // Директор может строить несколько вариаций продукта, используя
    // одинаковые шаги построения.
    public void BuildMinimalViableProduct()
    {
        _builder.BuildPartA();
    }
        
    public void BuildFullFeaturedProduct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}