using AllNumbers.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AllNumbers
{
    public static class DependencyBuilding
    {
        public static ServiceProvider Build()
        {
            var serviceProvider = new ServiceCollection();
            serviceProvider.AddScoped<ICharactersCombination, CharactersCombination>();

            var services = serviceProvider.BuildServiceProvider();

            return services;
        }
    }
}