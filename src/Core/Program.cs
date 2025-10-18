using System.ComponentModel.Design;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Core;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        ServiceContainer serviceContainer = new ServiceContainer();
        
        AppStateMachine appStateMachine = new AppStateMachine(serviceContainer);
        
        IWebDriver driver = new ChromeDriver();
        await driver.Navigate().GoToUrlAsync("https://ukr.net");
        
        Console.WriteLine("Loaded");
        
        //appStateMachine.Enter<BootStrapState>();
    }
}

internal class AppStateMachine(IServiceContainer serviceContainer)
{
    public T Enter<T>() where T : new()
    {
        return new T();
    }
}