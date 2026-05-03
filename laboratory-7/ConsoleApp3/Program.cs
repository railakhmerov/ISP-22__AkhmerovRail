
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] n = new int[15, 9];
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 9; j++)
                    n[i, j] = rnd.Next(-50, 51);

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 9; j++)
                    Console.Write($"{n[i, j],6}");
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < 15; i++)
            {
                int min = n[i, 0];
                for (int j = 1; j < 9; j++)
                    if (n[i, j] < min) min = n[i, j];
                Console.WriteLine($"строка {i + 1}: минимум = {min}");
            }
        }
    }
}
