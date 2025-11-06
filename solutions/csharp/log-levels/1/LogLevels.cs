using System;

static class LogLine
{
    // Extracts and returns the message part of the log line.
    public static string Message(string logLine)
    {
        // Split at ": " and take the part after it, then trim whitespace.
        var parts = logLine.Split(": ");
        return parts[1].Trim();
    }

    // Extracts and returns the log level part of the log line in lowercase.
    public static string LogLevel(string logLine)
    {
        // The level is between [ and ], so we can find its position.
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');
        string level = logLine.Substring(start, end - start);
        return level.ToLower();
    }

    // Reformats the log line to: "message (level)"
    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        return $"{message} ({level})";
    }
}
