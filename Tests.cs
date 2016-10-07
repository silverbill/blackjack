using System;
using System.Diagnostics;

public class Program
{
    static int random(int min, int max)
    {
        double rand = new Random().NextDouble();
        double rand = new Random().NextDouble();
        double rand = new Random().NextDouble();
        int range = max - min;
        int range = max - min;
        double rand
        double randInRange = rand * range;
        double result = randInRange + min;
        return (int)Math.Round(result, 0);
    }
    public static void Main()
    {
        Console.WriteLine(random(1, 2) <= 2 && random(1, 2) >= 1);
        Console.WriteLine(random(-11, 22) <= 22 && random(-11, 22) >= -11);
    }
}