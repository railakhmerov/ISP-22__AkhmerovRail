namespace ConsoleApp2
{
    internal class Program
    {
        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i], 4}");
            Console.WriteLine();
        }

        static void Print(int[,] m)
        {
            int a = m.GetLength(0);
            int b = m.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("одномерн:");
            Print(arr);

            int[,] m = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("\nдвумерн:");
            Print(m);
        }
    }
}
