namespace ConsoleApp6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] n = new int[5, 10];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 10; j++)
                    n[i, j] = rnd.Next(-10, 31);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{n[i, j],6}");
                Console.WriteLine();
            }

            Console.Write("\nстроки с положительными знач: ");
            bool first = true;
            for (int i = 0; i < 5; i++)
            {
                bool pos = true;
                for (int j = 0; j < 10; j++)
                    if (n[i, j] <= 0) { pos = false; break; }

                if (pos)
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
