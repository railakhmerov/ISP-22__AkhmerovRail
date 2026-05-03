namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Введите строки: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите столбцы: ");
            int x = int.Parse(Console.ReadLine());

            int[,] m = new int[n, x];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < x; j++)
                    m[i, j] = rnd.Next(-10, 11);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < x; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            int maxSum = int.MinValue, maxRow = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < x; j++) sum += m[i, j];
                if (sum > maxSum) { maxSum = sum; maxRow = i; }
            }

            int[] r = new int[x];
            for (int j = 0; j < x; j++) r[j] = m[maxRow, j];

            Console.WriteLine($"\nстрока {maxRow + 1} (сумма {maxSum}):");
            for (int i = 0; i < x; i++)
                Console.Write($"{r[i],4}");
            Console.WriteLine();
        }
    }
}
