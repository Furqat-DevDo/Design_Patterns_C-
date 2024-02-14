using Composite;

internal class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        // Таким образом, клиентский код может поддерживать простые
        // компоненты-листья...
        Leaf leaf = new Leaf();
        Console.WriteLine("Client: I get a simple component:");
        client.ClientCode(leaf);

        // ...а также сложные контейнеры.
        Composite.Composite tree = new Composite.Composite();
        Composite.Composite branch1 = new Composite.Composite();
        branch1.Add(new Leaf());
        branch1.Add(new Leaf());
        Composite.Composite branch2 = new Composite.Composite();
        branch2.Add(new Leaf());
        tree.Add(branch1);
        tree.Add(branch2);
        Console.WriteLine("Client: Now I've got a composite tree:");
        client.ClientCode(tree);

        Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
        client.ClientCode2(tree, leaf);
    }
}