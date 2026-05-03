namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] n = new int[5, 8];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    n[i, j] = rnd.Next(-20, 21);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write($"{n[i, j],6}");
                Console.WriteLine();
            }

            Console.Write("\nстолбцы с отрицательными: ");
            bool first = true;
            for (int j = 0; j < 8; j++)
            {
                bool neg = false;
                for (int i = 0; i < 5; i++)
                    if (m[i, j] < 0) { neg = true; break; }

                if (neg)
                {
                    if (!first) Console.Write(", ");
                    Console.Write(j + 1);
                    first = false;
                }
            }
            Console.WriteLine();
        }
    }
}
