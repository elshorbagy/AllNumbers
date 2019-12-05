using AllNumbers.Common;
using System;
using System.Text;

namespace AllNumbers.Models
{
    public class CharactersCombination : ICharactersCombination
    {
        private readonly StringBuilder _stringResult = new StringBuilder();

        /// <summary>
        /// Get All Possible Characters Combination
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetAllCombinations(int number)
        {
            try
            {
                var stringFromNumber = DataMapping.GetCharactersByNumber(number);

                //Convert the string into a character array
                var charArray = stringFromNumber.ToCharArray();                
                CreateCombination(charArray, 0, charArray.Length - 1);

                return _stringResult.ToString();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        private void SwitchCharacter(ref char firstChar, ref char secondChar)
        {
            if (firstChar == secondChar) return;

            var temp = firstChar;
            firstChar = secondChar;
            secondChar = temp;
        }

        private void CreateCombination(char[] charArray, int start, int end)
        {
            if (start == end)
            {
                _stringResult.Append(new string(charArray) + "\n");
            }
            else
                for (var i = start; i <= end; i++)
                {
                    SwitchCharacter(ref charArray[start], ref charArray[i]);
                    CreateCombination(charArray, start + 1, end);
                    SwitchCharacter(ref charArray[start], ref charArray[i]);
                }
        }
    }
}