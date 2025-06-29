using AllNumbers.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllNumbers.Test;

[TestClass]
public class CharactersCombinationTest
{
    readonly ICharactersCombination _charactersCombination;

    public CharactersCombinationTest()
    {
        var service = DependencyBuilding.Build();
        _charactersCombination = service.GetService<ICharactersCombination>();
    }

    [TestMethod]
    public void GetAllCombinationsTest()
    {
        var result = _charactersCombination.GetAllCombinations(23);
        Assert.AreEqual(result.Length, 5760);        
    }
}