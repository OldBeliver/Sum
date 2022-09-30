using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRandomValue = 100;
            int firstDevider = 3;
            int secondDevider = 5;
            int sum = 0;

            Random random = new Random();
            int randomValue = random.Next(maxRandomValue + 1);

            Console.WriteLine($"случайно сгенерированное число: {randomValue}");
            Console.WriteLine($"числа кратные {firstDevider} или {secondDevider} в диапазоне до {randomValue} включительно:");

            for (int i = 1; i <= randomValue; i++)
            {
                if (i % firstDevider == 0 || i % secondDevider == 0)
                {
                    Console.Write($"{i} ");
                    sum += i;
                }
            }

            Console.WriteLine($"\nсумма чисел: {sum}");
        }
    }
}
