using AllNumbers.Utilities;
using System.Text;

namespace AllNumbers.Services;

public class CharactersCombination : ICharactersCombination
{
    /// <summary>
    /// Generates all possible character combinations from the string mapped to the given number.
    /// </summary>
    /// <param name="number">The number used to retrieve the character string.</param>
    /// <returns>A string containing all possible combinations, separated by new lines.</returns>
    public string GetAllCombinations(int number)
    {
        var input = DataMapping.GetCharactersByNumber(number);
        var charArray = input.ToCharArray();

        var result = new StringBuilder();
        GeneratePermutations(charArray, 0, charArray.Length - 1, result);

        return result.ToString();
    }

    private static void GeneratePermutations(char[] array, int start, int end, StringBuilder result)
    {
        if (start == end)
        {
            result.AppendLine(new string(array));
            return;
        }

        for (int i = start; i <= end; i++)
        {
            Swap(ref array[start], ref array[i]);
            GeneratePermutations(array, start + 1, end, result);
            Swap(ref array[start], ref array[i]); // Backtrack
        }
    }

    private static void Swap(ref char a, ref char b)
    {
        if (a == b) return;
        (a, b) = (b, a);
    }
}
