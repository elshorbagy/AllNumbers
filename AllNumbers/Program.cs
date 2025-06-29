using AllNumbers.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AllNumbers;

internal class Program
{
    private static void Main()
    {
        using var serviceProvider = BuildDependencies();

        var characterService = serviceProvider.GetRequiredService<ICharactersCombination>();

        Console.WriteLine("Enter a number:");

        var input = Console.ReadLine();

        if (!int.TryParse(input, out var number))
        {
            Console.WriteLine("Invalid number. Please enter a valid integer.");
            WaitForExit();
            return;
        }

        try
        {
            var result = characterService.GetAllCombinations(number);
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        WaitForExit();
    }

    private static ServiceProvider BuildDependencies()
    {
        var services = new ServiceCollection();

        services.AddTransient<ICharactersCombination, CharactersCombination>();

        return services.BuildServiceProvider();
    }

    private static void WaitForExit()
    {
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
