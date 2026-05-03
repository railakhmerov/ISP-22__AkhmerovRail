namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(0, 50) * 2;

            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
