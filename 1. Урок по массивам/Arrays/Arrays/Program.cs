using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Одномерные массивы
            {
                //Объявления массивов, все способы равноценны
                {
                    int[] nums1;
                    nums1 = new int[4];

                    int[] nums2 = new int[4] { 1, 2, 3, 5 };

                    int[] nums3 = new int[] { 1, 2, 3, 5 };

                    int[] nums4 = new[] { 1, 2, 3, 5 };

                    int[] nums5 = { 1, 2, 3, 5 };
                }
                // Объявление ключевым словом var
                {
                    var nums6 = new int[4] { 1, 2, 3, 5 };

                    var nums7 = new int[] { 1, 2, 3, 5 };

                    var nums8 = new[] { 1, 2, 3, 5 };
                }
                // Обращение к массивам
                {
                    var nums = new int[4];
                    nums[0] = 1;
                    nums[1] = 2;
                    nums[2] = 3;
                    nums[3] = 5;
                    Console.WriteLine(nums[3]);  // На консоль выведется: 5
                }
                // Обращение к элементам массива через цикл
                {
                    int[] numbers = new int[] { 1, 2, 3, 4, 5 };
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i] + " "); // Будут выводиться все элементы массива
                    }
                }

                // Обращение к элементам массива через цикл c помощью ключевого слова foreach
                {
                    int[] numbers = new int[] { 1, 2, 3, 4, 5 };
                    // Работает также, как цикл, но вместо обращения по индексу, происходит извлечение элементов массива поочередно
                    foreach (int i in numbers)
                    {
                        Console.Write(i);
                    }
                }
            }

            // Многомерные массивы
            {
                // Как создать. Двумерные
                {
                    int[,] nums1;
                    nums1 = new int[10, 20];
                    int[,] nums2 = new int[2, 3];
                    int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };

                    int[,] nums4 = new int[,]
                    {
                    { 0, 1, 2 },
                    { 3, 4, 5 }
                    };

                    int[,] nums5 = new[,]
                    {
                    { 0, 1, 2 },
                    { 3, 4, 5 }
                    };

                    int[,] nums6 =
                    {
                    { 0, 1, 2 },
                    { 3, 4, 5 }
                    };
                }

                // Как создать с ключевым словом var
                {
                    var nums7 = new int[2, 3];
                    var nums8 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
                    var nums9 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
                    var nums10 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
                }

                // Обращение к двумерным массивам
                {
                    int[,] nums5 = new[,]
                    {
                        { 0, 1, 2 },
                        { 3, 4, 5 },
                        { 3, 4, 5 },
                        { 3, 4, 5 },
                        { 3, 4, 5 },
                        { 3, 4, 5 },
                        { 3, 4, 5 },
                        { 3, 4, 5 },
                        { 3, 4, 5 },
                        { 3, 4, 5 }
                    };
                    foreach (var item in nums5)
                    {
                        System.Console.Write($"[ {item} ] ");
                    }
                    System.Console.WriteLine($"\nРазмерность массива: {nums5.GetLowerBound(0) + 1} x {nums5.GetUpperBound(0) + 1}");
                    System.Console.WriteLine();
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            System.Console.Write($" [ {array[i, j]} ] ");
                        }
                        System.Console.WriteLine();
                    }

                }

                //Объявление трехмерных массивов
                {
                    int[,,] nums11 = new int[2, 3, 4];
                    int[,,] nums12 =
                    {
                        {
                            { 1, 3, 4 },
                            { 3, 5, 6}
                        },
                        {
                            { 4, 36, 5 },
                            { 33, 2, 1}
                        },
                        {
                            { 1, 3, 4 },
                            { 3, 5, 6}
                        }

                    };
                }
            }

        }
    }
}