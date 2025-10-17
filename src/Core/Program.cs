using System.ComponentModel.Design;

namespace Core;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        ServiceContainer serviceContainer = new ServiceContainer();
        
        AppStateMachine appStateMachine = new AppStateMachine(serviceContainer);
        appStateMachine.Enter<BootStrapState>();
    }
}

internal class AppStateMachine(IServiceContainer serviceContainer)
{
    public T Enter<T>()
    {
        
    }
}