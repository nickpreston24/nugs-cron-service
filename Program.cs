// See https://aka.ms/new-console-template for more information

using CodeMechanic.FileSystem;
using CodeMechanic.Types;
using Coravel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World! " + DateTime.Now.ToFriendlyDateString());

        // DotEnv.Load();
        // IHost host = CreateHostBuilder(args)
        //     .UseSystemd()
        //     .Build();
    }

    // public static IHostBuilder CreateHostBuilder(string[] args) =>
    //     Host.CreateDefaultBuilder(args)
    //         .ConfigureServices(services =>
    //         {
    //             services.AddScheduler();
    //             services.AddTransient<AmmoScraperInvocable>();
    //         });
}
//
// public class AmmoScraperInvocable
// {
// }