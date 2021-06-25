using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[,] {
                {2,3,4,5,6},
                {2,3,44,5,6},
                {2,3,4,55,6},
                {2,332,4,5,6}
            };
            System.Console.WriteLine($"Ранг: {array.Rank}");
            System.Console.WriteLine($"Длинна: {array.Length}");
            for (int i = 0; i < array.Rank; i++)
            {
                System.Console.WriteLine($"Длинна измерения {i}: {array.GetLength(i)}");
            }
            System.Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write($" [ {array[i,j]} ]");
                }
                System.Console.WriteLine();
            }
        }
    }
}
