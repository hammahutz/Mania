using System;

namespace Mania.Library;

public static class GameDebug
{
    public static DebugLevel Level = DebugLevel.Log;
    private static ConsoleColor _consoleColor = Console.ForegroundColor;

    public static void Log<T>(T text)
    {
        if (Level <= DebugLevel.Log)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"LOG - {text}");
            Console.ForegroundColor = _consoleColor;
        }
    }
    public static void Debug<T>(T text)
    {
        if (Level <= DebugLevel.Debug)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"DEBUG - {text}");
            Console.ForegroundColor = _consoleColor;
        }
    }
    public static void WriteLine<T>(T text)
    {
        if (Level <= DebugLevel.Normal)
        {
            Console.ForegroundColor = _consoleColor;
            Console.WriteLine($"{text}");
        }
    }
    public static void Warning<T>(T text)
    {
        if (Level <= DebugLevel.Warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"WARNING - {text}");
            Console.ForegroundColor = _consoleColor;
        }
    }
    public static void Error<T>(T text)
    {
        if (Level <= DebugLevel.Error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR - {text}");
            Console.ForegroundColor = _consoleColor;
        }
    }

}

public enum DebugLevel
{
    Log,
    Debug,
    Normal,
    Warning,
    Error
}