using System.Collections.Generic;
using System.Text;

namespace AllNumbers.Utilities;

public static class DataMapping
{
    private static readonly Dictionary<int, string> NumberToCharacters = new()
    {
        [2] = "ABC",
        [3] = "DEF",
        [4] = "GHI",
        [5] = "GKL",
        [6] = "MNO",
        [7] = "PQRS",
        [8] = "TUV",
        [9] = "WXYZ"
    };

    /// <summary>
    /// Converts a numeric input into a string containing the mapped characters for each digit.
    /// Digits 0 and 1 are ignored as they have no mappings.
    /// </summary>
    /// <param name="number">The numeric input to map.</param>
    /// <returns>Concatenated mapped characters for the number.</returns>
    public static string GetCharactersByNumber(int number)
    {
        var result = new StringBuilder();

        foreach (char digitChar in number.ToString())
        {
            if (!char.IsDigit(digitChar)) continue;

            int digit = digitChar - '0';

            if (NumberToCharacters.TryGetValue(digit, out var mappedChars))
            {
                result.Append(mappedChars);
            }
        }

        return result.ToString();
    }
}
