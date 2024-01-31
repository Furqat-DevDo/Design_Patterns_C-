using Singleton;

var s1 = Singleton.Singleton.GetInstance();
var s2 = Singleton.Singleton.GetInstance();

Console.WriteLine(s1 == s2
    ? "Singleton works, both variables contain the same instance."
    : "Singleton failed, variables contain different instances.");
    
// Клиентский код.
            
Console.WriteLine(
    "{0}\n{1}\n\n{2}\n",
    "If you see the same value, then singleton was reused (yay!)",
    "If you see different values, then 2 singletons were created (booo!!)",
    "RESULT:"
);
            
var process1 = new Thread(() =>
{
    TestSingleton("FOO");
});
var process2 = new Thread(() =>
{
    TestSingleton("BAR");
});
            
process1.Start();
process2.Start();
            
process1.Join();
process2.Join();

static void TestSingleton(string value)
{
    MultiThreadingSingleton singleton = MultiThreadingSingleton.GetInstance(value);
    Console.WriteLine(singleton.Value);
} 