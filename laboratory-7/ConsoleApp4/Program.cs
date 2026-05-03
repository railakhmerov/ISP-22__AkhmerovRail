namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] n = new int[6, 11];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 11; j++)
                    n[i, j] = rnd.Next(-100, 101);

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 11; j++)
                    Console.Write($"{n[i, j],6}");
                Console.WriteLine();
            }

            int sum = 0;
            Console.WriteLine();
            for (int j = 0; j < 11; j++)
            {
                int max = n[0, j];
                for (int i = 1; i < 6; i++)
                    if (n[i, j] > max) max = n[i, j];
                Console.WriteLine($"столбец {j + 1}: максимум = {max}");
                sum += max;
            }
            Console.WriteLine($"\nсумма: {sum}");
        }
    }
}
