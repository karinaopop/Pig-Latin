using System;
using System.Text.RegularExpressions;

public static class PigLatin
{
    public static string Translate(string word)
    {
        string[] words = word.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            string w = words[i];

            if (Regex.IsMatch(w, @"^(xr|yt|[aeiou])", RegexOptions.IgnoreCase))
            {
                w = w + "ay";
            }
            else if (Regex.IsMatch(w, @"^([^aeiou]?qu)", RegexOptions.IgnoreCase))
            {
                w = Regex.Replace(w, @"^([^aeiou]?qu)(.*)", "$2$1ay");
            }
            else if (Regex.IsMatch(w, @"^([^aeiouy]+)(y.*)", RegexOptions.IgnoreCase))
            {
                w = Regex.Replace(w, @"^([^aeiouy]+)(y.*)", "$2$1ay");
            }
            else
            {
                w = Regex.Replace(w, @"^([^aeiou]+)(.*)", "$2$1ay");
            }

            words[i] = w;
        }

        return string.Join(" ", words);
    }
}
