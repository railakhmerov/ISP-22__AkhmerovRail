namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] n = new int[7, 4];
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 4; j++)
                    n[i, j] = rnd.Next(-15, 16);

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{n[i, j],6}");
                Console.WriteLine();
            }

            Console.Write("\nстроки с нечетным отрицательным: ");
            bool first = true;
            for (int i = 0; i < 7; i++)
            {
                bool odd = false;
                for (int j = 0; j < 4; j++)
                    if (n[i, j] < 0 && n[i, j] % 2 != 0)
                    { odd = true; break; }

                if (odd)
                {
                    if (!first) Console.Write(", ");
                    Console.Write(i + 1);
                    first = false;
                }
            }
            if (first) Console.Write("нет");
            Console.WriteLine();
        }
    }
}
