using System;

static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";

        bool isQuestion = statement.Trim().EndsWith("?");
        bool isYelling = statement.ToUpper() == statement && statement.ToLower() != statement;

        if (isYelling && isQuestion)
            return "Calm down, I know what I'm doing!";
        if (isYelling)
            return "Whoa, chill out!";
        if (isQuestion)
            return "Sure.";

        return "Whatever.";
    }
}
