using System;

public class StringUtility
{
    static string SummerizeText(string text, int MaxLength = 20)
    {
        const int maxLength = 20;

        if (text.Length < maxLength)
            return text;
        else
        {
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            var summary = String.Join(" ", summaryWords) + "...";
            }
        }
    }
}
