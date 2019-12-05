using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllNumbers.Common
{
    public static class DataMapping
    {
        private static readonly Dictionary<int, string> DataDictionary = new Dictionary<int, string>();

        static DataMapping()
        {
            //Map Data to the dictionary
            DataDictionary[2] = "ABC";
            DataDictionary[3] = "DEF";
            DataDictionary[4] = "GHI";
            DataDictionary[5] = "GKL";
            DataDictionary[6] = "MNO";
            DataDictionary[7] = "PQRS";
            DataDictionary[8] = "TUV";
            DataDictionary[9] = "WXYZ";
        }

        /// <summary>
        /// Return Mapped characters by number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetCharactersByNumber(int number)
        {
            var stringFromNumber = new StringBuilder();

            //Convert Numbers to Character Array
            var numbersArray = number.ToString().Select(c => c - '0').ToArray();

            //Get string value by number
            for (var i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == 1 || numbersArray[i] == 0) continue;
                stringFromNumber.Append(DataDictionary[numbersArray[i]]);
            }
            
            return stringFromNumber.ToString();
        }
    }
}