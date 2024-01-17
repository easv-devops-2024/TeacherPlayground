using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(GetGreetingMessage());
    }

    public static string GetGreetingMessage()
    {
        bool isDroneCI = Environment.GetEnvironmentVariable("DRONE") == "true";

        if (isDroneCI)
        {
            return "Hello, Drone CI!";
        }
        else
        {
            return "Hello, World!";
        }
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return b - a;
    }
}