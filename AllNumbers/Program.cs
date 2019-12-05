using AllNumbers.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AllNumbers
{
    internal class Program
    {
        private static ICharactersCombination _charactersCombination;

        private static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                var input = Console.ReadLine();

                BuildDependencies();
                Console.Write(_charactersCombination.GetAllCombinations(Convert.ToInt32(input)));
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
                Console.ReadKey();
            }
        }

        private static void BuildDependencies()
        {
            var service = DependencyBuilding.Build();
            _charactersCombination = service.GetService<ICharactersCombination>();
        }
    }
}