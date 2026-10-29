// Работа Vitalii Prytchak

class Program
{
    static (double, double)
    Calculate(double c_1, double c_2)
    {
        double a_1 = 1;
        double a_2 = 2;
        double b_1 = 3;
        double b_2 = 4;

        double d = a_1 * b_2 - a_2 * b_1;

        double x = (c_1 * b_2 - a_2 * b_1) / d;
        double y = (a_1 * c_2 - c_2 * c_1) / d;

        return (x, y);
    }

    static double?
    Check(string? raw_number)
    {
        if (double.TryParse(raw_number, out double number))
        {
            return number;
        }
        else
        {
            Console.WriteLine($"{raw_number} это не число.");
            return null;
        }
    }

    static void
    Main()
    {
        Console.WriteLine("Введите первое число: ");
        string? raw_c_1 = Console.ReadLine();
        double? c_1 = Check(raw_c_1);
        if (c_1 == null)
        {
            return;
        }

        Console.WriteLine("Введите второе число: ");
        string? raw_c_2 = Console.ReadLine();
        double? c_2 = Check(raw_c_2);
        if (c_2 == null)
        {
            return;
        }

        (double x, double y) = Calculate(c_1.Value, c_2.Value);

        Console.WriteLine($"\nРезультат:\nx = {x};\ny = {y};");
    }
}