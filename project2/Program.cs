class Program
{
    static Random random = new Random();

    private static int[]
    Task0()
    {
        int[] array = new int[10];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = random.Next(1, 101);
        }

        return array;
    }

    private static void
    Task1(int[] array, string number)
    {   
        Console.WriteLine($"\x1b[33m1. Содержимое {number} массива:\x1b[0m");

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write($"{array[index]} ");
        }

        Console.Write("\n");
    }

    private static double
    Task2(int[] array)
    {
        Console.WriteLine("\x1b[34m2. Среднее Арифметическое:\x1b[0m");

        int number = 0;

        for (int index = 0; index < array.Length; index++)
        {
            number += array[index];
        }

        double arithmetic_mean = number / array.Length;
        Console.WriteLine(arithmetic_mean);

        return arithmetic_mean;
    }

    private static int
    Task3(int[] array, double arithmetic_mean)
    {
        Console.WriteLine("\x1b[36m3. Чисел больше среднего арифметического:\x1b[0m");

        int quantity = 0;

        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] > arithmetic_mean)
            {
                quantity += 1;
            }
        }

        Console.WriteLine(quantity);

        return quantity;
    }

    private static int[]
    Task4(int[] array, double arithmetic_mean, int quantity)
    {
        int[] new_array = new int[quantity];
        int new_array_index = 0;

        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] > arithmetic_mean)
            {
                new_array[new_array_index] = array[index];
                new_array_index += 1;
            }
        }

        return new_array;
    }

    private static void
    Main()
    {
        int[] array = Task0();

        Task1(array, "первого");
        double arithmetic_mean = Task2(array);
        int quantity = Task3(array, arithmetic_mean);

        Console.Write("\n");
        int[] new_array = Task4(array, arithmetic_mean, quantity);
        Task1(new_array, "второго");

    }
}
