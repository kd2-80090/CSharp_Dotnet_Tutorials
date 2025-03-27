using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Test cases
        string[] testAddresses =
        {
            "12345 ThisIsAnExtremelyLongWordThatExceedsTheCharacterLimitOfThirtyFiveCharactersAndNeedsSplitting 67890",
            "Short address example",
            "OneVeryLongWordThatExceedsTheLimitWithoutSpaces",
            "Multiple words with someLongWordThatExceedsTheLimit and normal words",
            "This is a perfectly fine address with words under the limit",
            "123456789012345678901234567890123 House 789",
            ""
        };

        int maxLength = 35;

        foreach (string address in testAddresses)
        {
            Console.WriteLine($"Input Address: {address}");
            List<string> parts = GetTrimmedAddressParts(address, maxLength);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"RemitterDtl{i + 1}: {(i < parts.Count ? parts[i] : "")}");
            }
            Console.WriteLine(new string('-', 80));
        }
    }

    private static List<string> GetTrimmedAddressParts(string? address, int maxLength)
    {
        List<string> parts = new List<string>();

        if (string.IsNullOrWhiteSpace(address))
        {
            return parts;
        }

        string[] words = address.Split(' ');
        string currentPart = "";

        foreach (var word in words)
        {
            if (word.Length > maxLength)
            {
                // If the currentPart is not empty, push it first
                if (!string.IsNullOrEmpty(currentPart))
                {
                    parts.Add(currentPart);
                    currentPart = "";
                }

                // Split the long word into chunks of maxLength
                for (int i = 0; i < word.Length; i += maxLength)
                {
                    parts.Add(word.Substring(i, Math.Min(maxLength, word.Length - i)));
                }
            }
            else if ((currentPart.Length + word.Length + 1) <= maxLength)
            {
                // Append to current part if space is available
                currentPart = string.IsNullOrEmpty(currentPart) ? word : $"{currentPart} {word}";
            }
            else
            {
                // Save the current part and start a new one
                parts.Add(currentPart);
                currentPart = word;
            }
        }

        if (!string.IsNullOrEmpty(currentPart))
        {
            parts.Add(currentPart);
        }

        return parts;
    }
}
