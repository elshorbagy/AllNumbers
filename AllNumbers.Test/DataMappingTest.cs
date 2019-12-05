using AllNumbers.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllNumbers.Test
{
    [TestClass]
    public class DataMappingTest
    {
        [TestMethod]
        public void GetCharactersByNumberTest()
        {
            var result = DataMapping.GetCharactersByNumber(2);
            Assert.AreEqual(result, "ABC");
        }
    }
}